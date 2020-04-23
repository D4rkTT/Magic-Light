using MSIRGB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Linq.Enumerable;
using CSCore;
using CSCore.Codecs;
using CSCore.DSP;
using CSCore.SoundOut;
using CSCore.SoundIn;
using CSCore.Streams;
using CSCore.Streams.Effects;
using WinformsVisualization.Visualization;

namespace MSI_Audio_Virtualizer
{
    public partial class Form1 : Form
    {
        private Lighting MSI;
        private WasapiCapture _soundIn;
        private ISoundOut _soundOut;
        private IWaveSource _source;
        private PitchShifter _pitchShifter;
        private LineSpectrum _lineSpectrum;
        private bool Music = false;
        private bool Police = false;
        private bool Rainbow = false;
        private bool isMouseDown = false;
        private Point mouseOffset;
        private double Sens = 0;
        private bool M_Rainbow = true;
        private bool M_GR = false;
        private bool M_OC = false;
        private Color OC_C = Color.Red;
        private Color P_C1 = Color.Red;
        private Color P_C2 = Color.Blue;
        private int P_Speed_value = 20;
        private bool Allowed = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Stop();
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Hide();
            MagicIcon.BalloonTipTitle = "Magic Light";
            MagicIcon.BalloonTipText = "Magic Light is here for quick actions ;)";
            MagicIcon.ShowBalloonTip(2000);
        }
        private void APPcontrolbar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        private void APPcontrolbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point Mpos = Control.MousePosition;
                Mpos.Offset(mouseOffset.X, mouseOffset.Y);
                this.Location = Mpos;
            }
        }
        private void APPcontrolbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }
        /// <summary>
        /// Convert HSV to RGB
        /// h is from 0-360
        /// s,v values are 0-1
        /// r,g,b values are 0-255
        /// Based upon http://ilab.usc.edu/wiki/index.php/HSV_And_H2SV_Color_Space#HSV_Transformation_C_.2F_C.2B.2B_Code_2
        /// </summary>
        void HsvToRgb(double h, double S, double V, out int r, out int g, out int b)
        {
            // ######################################################################
            // T. Nathan Mundhenk
            // mundhenk@usc.edu
            // C/C++ Macro HSV to RGB

            double H = h;
            while (H < 0) { H += 360; };
            while (H >= 360) { H -= 360; };
            double R, G, B;
            if (V <= 0)
            { R = G = B = 0; }
            else if (S <= 0)
            {
                R = G = B = V;
            }
            else
            {
                double hf = H / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = V * (1 - S);
                double qv = V * (1 - S * f);
                double tv = V * (1 - S * (1 - f));
                switch (i)
                {

                    // Red is the dominant color

                    case 0:
                        R = V;
                        G = tv;
                        B = pv;
                        break;

                    // Green is the dominant color

                    case 1:
                        R = qv;
                        G = V;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = V;
                        B = tv;
                        break;

                    // Blue is the dominant color

                    case 3:
                        R = pv;
                        G = qv;
                        B = V;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = V;
                        break;

                    // Red is the dominant color

                    case 5:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // Just in case we overshoot on our math by a little, we put these here. Since its a switch it won't slow us down at all to put these here.

                    case 6:
                        R = V;
                        G = tv;
                        B = pv;
                        break;
                    case -1:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // The color is not defined, we should throw an error.

                    default:
                        //LFATAL("i Value error in Pixel conversion, Value is %d", i);
                        R = G = B = V; // Just pretend its black/white
                        break;
                }
            }
            r = Clamp((int)(R * 255.0));
            g = Clamp((int)(G * 255.0));
            b = Clamp((int)(B * 255.0));
        }

        /// <summary>
        /// Clamp a value to 0-255
        /// </summary>
        int Clamp(int i)
        {
            if (i < 0) return 0;
            if (i > 255) return 255;
            return i;
        }
        void Convert2MSI(Color Color, out System.Windows.Media.Color CFinal) {
            byte R = Convert.ToByte(((Color.R / 16) - 15) * -1);
            byte G = Convert.ToByte(((Color.G / 16) - 15) * -1);
            byte B = Convert.ToByte(((Color.B / 16) - 15) * -1);
            CFinal = System.Windows.Media.Color.FromRgb(R, G, B);
        }

        private void Music_Apply_Click(object sender, EventArgs e)
        {
            if (Music_Apply.Text == "Start")
            {
                if (!Audio_Visualizer.IsBusy)
                {
                    Control_Service("Music", 1);
                    Audio_Visualizer.RunWorkerAsync();
                }
            }
            else {
                Control_Service("Music", 0);
                Audio_Visualizer.CancelAsync();
            }
        }

        private void Music_Sync(object sender, DoWorkEventArgs e)
        {
            MSI = new Lighting(Allowed);
            double i = 0;
            while (Music)
            {
                int r = 0, g = 0, b = 0;
                var fftBuffer = new float[(int)FftSize.Fft128];
                if (_lineSpectrum.SpectrumProvider.GetFftData(fftBuffer, this))
                {
                    double bass = 0.0;
                    for (int z = 0; z < 8; z++)
                    {
                        bass += (fftBuffer[z] * 4);
                    }

                    bass += Sens;
                    if (bass > 1.0)
                    {
                        bass = 1.0;
                    }
                    else if (bass < 0.0) {
                        bass = 0.0;
                    }

                    if (M_Rainbow)
                    {
                        HsvToRgb(i, 1, bass, out r, out g, out b);
                    }
                    else if (M_GR)
                    {
                        double val = bass * 255.0;
                        r = Convert.ToInt32(val);
                        g = 255 - Convert.ToInt32(val);
                        b = 0; // For better color effect
                    }
                    else if (M_OC)
                    {
                        r = Convert.ToInt32(OC_C.R * bass);
                        g = Convert.ToInt32(OC_C.G * bass);
                        b = Convert.ToInt32(OC_C.B * bass);
                    }
                }
                Color bcolor = Color.FromArgb(r, g, b);
                System.Windows.Media.Color colour;
                Convert2MSI(bcolor,out colour);

                Image image = Visualizer_Image.Image;
                var newImage = _lineSpectrum.CreateSpectrumLine(Visualizer_Image.Size, Color.FromArgb(r, g, b), Color.FromArgb(r, g, b), Color.FromArgb(0 ,30, 30, 35), true);
                Music_Apply.BackColor = Color.FromArgb(r, g, b);

                if (newImage != null)
                {
                    Visualizer_Image.Image = newImage;
                    if (image != null)
                        image.Dispose();
                }

                MSI.BatchBegin();
                foreach (byte index in Range(1, 8))
                {
                    MSI.SetColour(index, colour);
                }
                MSI.BatchEnd();

                System.Threading.Thread.Sleep(50);
                if (i == 360)
                {
                    i = 0;
                    i = i + 1;
                }
                else {
                    i += 1;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Stop();
            _soundIn = new WasapiLoopbackCapture();
            _soundIn.Initialize();

            var soundInSource = new SoundInSource(_soundIn);
            ISampleSource source = soundInSource.ToSampleSource().AppendSource(x => new PitchShifter(x), out _pitchShifter);
            SetupSampleSource(source);

            byte[] buffer = new byte[_source.WaveFormat.BytesPerSecond / 2];
            soundInSource.DataAvailable += (s, aEvent) =>
            {
                int read;
                while ((read = _source.Read(buffer, 0, buffer.Length)) > 0) ;
            };

            _soundIn.Start();
            try
            {
                MSI = new Lighting(Allowed);
            }
            catch (MSIRGB.Lighting.Exception ex)
            {
                if (ex.GetErrorCode() == Lighting.ErrorCode.DriverLoadFailed)
                {
                    MessageBox.Show("Please run program as administrator.");
                    Close();
                }
                else if (ex.GetErrorCode() == Lighting.ErrorCode.MotherboardModelNotSupported)
                {
                    if (MessageBox.Show("Your motherboard not supported but it will work, Application will run at your own risk", "MSI Magic Light", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        Allowed = true;
                    }
                    else
                    { 
                        Close();
                    }
                }
                else if (ex.GetErrorCode() == Lighting.ErrorCode.MotherboardVendorNotSupported)
                {
                    MessageBox.Show("Your motherboard not supported at all, We are sorry :(");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unknown Error, Please report it on github");
                    this.Close();
                }
            }
        }
        private void SetupSampleSource(ISampleSource aSampleSource)
        {
            const FftSize fftSize = FftSize.Fft128;
            var spectrumProvider = new BasicSpectrumProvider(aSampleSource.WaveFormat.Channels,
                aSampleSource.WaveFormat.SampleRate, fftSize);
            _lineSpectrum = new LineSpectrum(fftSize)
            {
                SpectrumProvider = spectrumProvider,
                UseAverage = true,
                BarCount = 50,
                BarSpacing = 2,
                IsXLogScale = true,
                ScalingStrategy = ScalingStrategy.Linear
            };
            var notificationSource = new SingleBlockNotificationStream(aSampleSource);
            notificationSource.SingleBlockRead += (s, a) => spectrumProvider.Add(a.Left, a.Right);
            _source = notificationSource.ToWaveSource(16);

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Stop();
        }
        private void Stop()
        {

            Music = false;
            if (_soundOut != null)
            {
                _soundOut.Stop();
                _soundOut.Dispose();
                _soundOut = null;
            }
            if (_soundIn != null)
            {
                _soundIn.Stop();
                _soundIn.Dispose();
                _soundIn = null;
            }
            if (_source != null)
            {
                _source.Dispose();
                _source = null;
            }
        }
        private void M_Sens_Scroll(object sender, EventArgs e)
        {
            Sens = Convert.ToDouble(M_Sens.Value) / 10.0;
            if (M_Sens.Value == 0)
            {
                lbl_S_Value.Text = "0 (default)";
            }
            else {
                lbl_S_Value.Text = M_Sens.Value.ToString();
            }
        }

        private void RD_Rainbow_CheckedChanged(object sender, EventArgs e)
        {
            if (RD_Rainbow.Checked)
            {
                M_Rainbow = true;
                M_GR = false;
                M_OC = false;
            }
            else if (RD_GR.Checked)
            {
                M_GR = true;
                M_Rainbow = false;
                M_OC = false;
            }
            else if (RD_OC.Checked)
            {
                M_OC = true;
                M_GR = false;
                M_Rainbow = false;
            }
        }

        private void PickerVal_Click(object sender, EventArgs e)
        {
            if (Picker.ShowDialog() == DialogResult.OK) {
                PickerVal.BackColor = Picker.Color;
                OC_C = Picker.Color;
            }
        }

        private void Police_Mode_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Windows.Media.Color colour;
            MSI = new Lighting(Allowed);
            int i = 0;
            while (Police) {
                if (i == 0)
                {
                    Convert2MSI(P_C1, out colour);
                    PoliceBTN.BackColor = P_C1;
                    i = 1;
                }
                else {
                    Convert2MSI(P_C2, out colour);
                    PoliceBTN.BackColor = P_C2;
                    i = 0;
                }
                
                MSI.BatchBegin();
                foreach (byte index in Range(1, 8))
                {
                    MSI.SetColour(index, colour);
                }
                MSI.BatchEnd();
                System.Threading.Thread.Sleep((100 / P_Speed_value) * 50);
            }
        }
        private void Navigate(string menu) {
            if (menu == "Music")
            {
                Visualizer_Image.Visible = true;
                Music_Controller_Panel.Visible = true;
                Police_Control_Panel.Visible = false;
            }
            else if (menu == "Police")
            {
                Visualizer_Image.Visible = false;
                Music_Controller_Panel.Visible = false;
                Police_Control_Panel.Visible = true;

            }
            else if (menu == "Rainbow")
            {
                Visualizer_Image.Visible = false;
                Music_Controller_Panel.Visible = false;
                Police_Control_Panel.Visible = false;
            }
        }

        private void Police_Speed_TB_Scroll(object sender, EventArgs e)
        {
            P_Speed_value = Police_Speed_TB.Value;
            if (Police_Speed_TB.Value == 20)
            {
                lbl_P_Val.Text = "20 (Default)";
            }
            else
            {
                lbl_P_Val.Text = Police_Speed_TB.Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Navigate("Music");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Navigate("Police");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (PoliceBTN.Text == "Start")
            {
                if (!Police_Mode.IsBusy) {
                    Control_Service("Police", 1);
                    Police_Mode.RunWorkerAsync();
                }
            }
            else {
                Control_Service("Police", 0);
                Police_Mode.CancelAsync();
            }
        }

        private void Police_Color1_Click(object sender, EventArgs e)
        {
            if (Picker.ShowDialog() == DialogResult.OK) {
                P_C1 = Picker.Color;
                Police_Color1.BackColor = Picker.Color;
            }
        }

        private void Police_Color2_Click(object sender, EventArgs e)
        {
            if (Picker.ShowDialog() == DialogResult.OK)
            {
                P_C2 = Picker.Color;
                Police_Color2.BackColor = Picker.Color;
            }
        }
        private void Control_Service(string Service, int stat) {
            if (Service == "Music")
            {
                if (stat == 0 /* OFF */)
                {
                    Music = false;
                    Music_Apply.Text = "Start";
                }
                else {
                    // ON
                    Music = true;
                    Police = false;
                    Rainbow = false;
                    Music_Apply.Text = "Stop";
                    PoliceBTN.Text = "Start";
                }
            }
            else if (Service == "Police")
            {
                if (stat == 0 /* OFF */)
                {
                    Police = false;
                    PoliceBTN.Text = "Start";
                }
                else
                {
                    // ON
                    Music = false;
                    Police = true;
                    Rainbow = false;
                    PoliceBTN.Text = "Stop";
                    Music_Apply.Text = "Start";
                }
            }
            else if (Service == "Rainbow") {
                if (stat == 0 /* OFF */)
                {
                    Rainbow = false;
                }
                else
                {
                    // ON
                    Music = false;
                    Police = false;
                    Rainbow = true;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void policeModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            Navigate("Police");
        }

        private void rainbowModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rainbowModeToolStripMenuItem.Checked = true;
            greenToRedToolStripMenuItem.Checked = false;
            fromBlackTo1ColorToolStripMenuItem.Checked = false;
            RD_Rainbow.Checked = true;
            RD_GR.Checked = false;
            RD_OC.Checked = false;
        }

        private void greenToRedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rainbowModeToolStripMenuItem.Checked = false;
            greenToRedToolStripMenuItem.Checked = true;
            fromBlackTo1ColorToolStripMenuItem.Checked = false;
            RD_Rainbow.Checked = false;
            RD_GR.Checked = true;
            RD_OC.Checked = false;
        }

        private void fromBlackTo1ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rainbowModeToolStripMenuItem.Checked = false;
            greenToRedToolStripMenuItem.Checked = false;
            fromBlackTo1ColorToolStripMenuItem.Checked = true;
            RD_Rainbow.Checked = false;
            RD_GR.Checked = false;
            RD_OC.Checked = true;
        }

        private void MagicIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        
    }
}
