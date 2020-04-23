namespace MSI_Audio_Virtualizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Audio_Visualizer = new System.ComponentModel.BackgroundWorker();
            this.Visualizer_Image = new System.Windows.Forms.PictureBox();
            this.Music_Panel = new System.Windows.Forms.Panel();
            this.Police_Control_Panel = new System.Windows.Forms.Panel();
            this.Police_Color2 = new System.Windows.Forms.PictureBox();
            this.Police_Color1 = new System.Windows.Forms.PictureBox();
            this.Police_Speed_TB = new System.Windows.Forms.TrackBar();
            this.lbl_P_Val = new System.Windows.Forms.Label();
            this.PoliceBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_P_Speed = new System.Windows.Forms.Label();
            this.Music_Controller_Panel = new System.Windows.Forms.Panel();
            this.lblSensitivity = new System.Windows.Forms.Label();
            this.Color_Mode_Panel = new System.Windows.Forms.Panel();
            this.PickerVal = new System.Windows.Forms.PictureBox();
            this.RD_OC = new System.Windows.Forms.RadioButton();
            this.Music_Apply = new System.Windows.Forms.Button();
            this.RD_GR = new System.Windows.Forms.RadioButton();
            this.RD_Rainbow = new System.Windows.Forms.RadioButton();
            this.M_Sens = new System.Windows.Forms.TrackBar();
            this.lblCM = new System.Windows.Forms.Label();
            this.lbl_S_Value = new System.Windows.Forms.Label();
            this.APPcontrolbar = new System.Windows.Forms.Panel();
            this.APPnamelbl = new System.Windows.Forms.Label();
            this.APPicon = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Picker = new System.Windows.Forms.ColorDialog();
            this.Police_Mode = new System.ComponentModel.BackgroundWorker();
            this.MagicIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.IconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.musicVisualizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rainbowModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromBlackTo1ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Visualizer_Image)).BeginInit();
            this.Music_Panel.SuspendLayout();
            this.Police_Control_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Police_Color2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Police_Color1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Police_Speed_TB)).BeginInit();
            this.Music_Controller_Panel.SuspendLayout();
            this.Color_Mode_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PickerVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_Sens)).BeginInit();
            this.APPcontrolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.APPicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.IconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Audio_Visualizer
            // 
            this.Audio_Visualizer.WorkerReportsProgress = true;
            this.Audio_Visualizer.WorkerSupportsCancellation = true;
            this.Audio_Visualizer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Music_Sync);
            // 
            // Visualizer_Image
            // 
            this.Visualizer_Image.BackColor = System.Drawing.Color.Transparent;
            this.Visualizer_Image.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Visualizer_Image.Location = new System.Drawing.Point(0, 192);
            this.Visualizer_Image.Name = "Visualizer_Image";
            this.Visualizer_Image.Size = new System.Drawing.Size(641, 234);
            this.Visualizer_Image.TabIndex = 5;
            this.Visualizer_Image.TabStop = false;
            // 
            // Music_Panel
            // 
            this.Music_Panel.Controls.Add(this.Police_Control_Panel);
            this.Music_Panel.Controls.Add(this.Music_Controller_Panel);
            this.Music_Panel.Controls.Add(this.Visualizer_Image);
            this.Music_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Music_Panel.Location = new System.Drawing.Point(0, 0);
            this.Music_Panel.Name = "Music_Panel";
            this.Music_Panel.Size = new System.Drawing.Size(641, 426);
            this.Music_Panel.TabIndex = 6;
            // 
            // Police_Control_Panel
            // 
            this.Police_Control_Panel.Controls.Add(this.Police_Color2);
            this.Police_Control_Panel.Controls.Add(this.Police_Color1);
            this.Police_Control_Panel.Controls.Add(this.Police_Speed_TB);
            this.Police_Control_Panel.Controls.Add(this.lbl_P_Val);
            this.Police_Control_Panel.Controls.Add(this.PoliceBTN);
            this.Police_Control_Panel.Controls.Add(this.label3);
            this.Police_Control_Panel.Controls.Add(this.label1);
            this.Police_Control_Panel.Controls.Add(this.lbl_P_Speed);
            this.Police_Control_Panel.Location = new System.Drawing.Point(4, 1);
            this.Police_Control_Panel.Name = "Police_Control_Panel";
            this.Police_Control_Panel.Size = new System.Drawing.Size(641, 186);
            this.Police_Control_Panel.TabIndex = 11;
            this.Police_Control_Panel.Visible = false;
            // 
            // Police_Color2
            // 
            this.Police_Color2.BackColor = System.Drawing.Color.Blue;
            this.Police_Color2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Police_Color2.Location = new System.Drawing.Point(337, 118);
            this.Police_Color2.Name = "Police_Color2";
            this.Police_Color2.Size = new System.Drawing.Size(72, 26);
            this.Police_Color2.TabIndex = 11;
            this.Police_Color2.TabStop = false;
            this.Police_Color2.Click += new System.EventHandler(this.Police_Color2_Click);
            // 
            // Police_Color1
            // 
            this.Police_Color1.BackColor = System.Drawing.Color.Red;
            this.Police_Color1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Police_Color1.Location = new System.Drawing.Point(119, 118);
            this.Police_Color1.Name = "Police_Color1";
            this.Police_Color1.Size = new System.Drawing.Size(72, 26);
            this.Police_Color1.TabIndex = 11;
            this.Police_Color1.TabStop = false;
            this.Police_Color1.Click += new System.EventHandler(this.Police_Color1_Click);
            // 
            // Police_Speed_TB
            // 
            this.Police_Speed_TB.Location = new System.Drawing.Point(69, 47);
            this.Police_Speed_TB.Maximum = 100;
            this.Police_Speed_TB.Minimum = 1;
            this.Police_Speed_TB.Name = "Police_Speed_TB";
            this.Police_Speed_TB.Size = new System.Drawing.Size(457, 45);
            this.Police_Speed_TB.TabIndex = 10;
            this.Police_Speed_TB.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Police_Speed_TB.Value = 20;
            this.Police_Speed_TB.Scroll += new System.EventHandler(this.Police_Speed_TB_Scroll);
            // 
            // lbl_P_Val
            // 
            this.lbl_P_Val.BackColor = System.Drawing.Color.Transparent;
            this.lbl_P_Val.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P_Val.ForeColor = System.Drawing.Color.White;
            this.lbl_P_Val.Location = new System.Drawing.Point(530, 51);
            this.lbl_P_Val.Name = "lbl_P_Val";
            this.lbl_P_Val.Size = new System.Drawing.Size(87, 17);
            this.lbl_P_Val.TabIndex = 9;
            this.lbl_P_Val.Text = "20 (Default)";
            // 
            // PoliceBTN
            // 
            this.PoliceBTN.BackColor = System.Drawing.Color.White;
            this.PoliceBTN.FlatAppearance.BorderSize = 0;
            this.PoliceBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PoliceBTN.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoliceBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PoliceBTN.Location = new System.Drawing.Point(486, 111);
            this.PoliceBTN.Name = "PoliceBTN";
            this.PoliceBTN.Size = new System.Drawing.Size(116, 32);
            this.PoliceBTN.TabIndex = 7;
            this.PoliceBTN.Text = "Start";
            this.PoliceBTN.UseVisualStyleBackColor = false;
            this.PoliceBTN.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(238, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Second Color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "First Color:";
            // 
            // lbl_P_Speed
            // 
            this.lbl_P_Speed.AutoSize = true;
            this.lbl_P_Speed.BackColor = System.Drawing.Color.Transparent;
            this.lbl_P_Speed.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P_Speed.ForeColor = System.Drawing.Color.White;
            this.lbl_P_Speed.Location = new System.Drawing.Point(20, 51);
            this.lbl_P_Speed.Name = "lbl_P_Speed";
            this.lbl_P_Speed.Size = new System.Drawing.Size(46, 17);
            this.lbl_P_Speed.TabIndex = 9;
            this.lbl_P_Speed.Text = "Speed:";
            // 
            // Music_Controller_Panel
            // 
            this.Music_Controller_Panel.Controls.Add(this.lblSensitivity);
            this.Music_Controller_Panel.Controls.Add(this.Color_Mode_Panel);
            this.Music_Controller_Panel.Controls.Add(this.M_Sens);
            this.Music_Controller_Panel.Controls.Add(this.lblCM);
            this.Music_Controller_Panel.Controls.Add(this.lbl_S_Value);
            this.Music_Controller_Panel.Location = new System.Drawing.Point(4, 0);
            this.Music_Controller_Panel.Name = "Music_Controller_Panel";
            this.Music_Controller_Panel.Size = new System.Drawing.Size(641, 186);
            this.Music_Controller_Panel.TabIndex = 10;
            // 
            // lblSensitivity
            // 
            this.lblSensitivity.AutoSize = true;
            this.lblSensitivity.BackColor = System.Drawing.Color.Transparent;
            this.lblSensitivity.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensitivity.ForeColor = System.Drawing.Color.White;
            this.lblSensitivity.Location = new System.Drawing.Point(14, 21);
            this.lblSensitivity.Name = "lblSensitivity";
            this.lblSensitivity.Size = new System.Drawing.Size(66, 17);
            this.lblSensitivity.TabIndex = 8;
            this.lblSensitivity.Text = "Sensitivity:";
            // 
            // Color_Mode_Panel
            // 
            this.Color_Mode_Panel.Controls.Add(this.PickerVal);
            this.Color_Mode_Panel.Controls.Add(this.RD_OC);
            this.Color_Mode_Panel.Controls.Add(this.Music_Apply);
            this.Color_Mode_Panel.Controls.Add(this.RD_GR);
            this.Color_Mode_Panel.Controls.Add(this.RD_Rainbow);
            this.Color_Mode_Panel.Location = new System.Drawing.Point(96, 74);
            this.Color_Mode_Panel.Name = "Color_Mode_Panel";
            this.Color_Mode_Panel.Size = new System.Drawing.Size(531, 96);
            this.Color_Mode_Panel.TabIndex = 9;
            // 
            // PickerVal
            // 
            this.PickerVal.BackColor = System.Drawing.Color.Red;
            this.PickerVal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PickerVal.Location = new System.Drawing.Point(204, 54);
            this.PickerVal.Name = "PickerVal";
            this.PickerVal.Size = new System.Drawing.Size(72, 26);
            this.PickerVal.TabIndex = 1;
            this.PickerVal.TabStop = false;
            this.PickerVal.Click += new System.EventHandler(this.PickerVal_Click);
            // 
            // RD_OC
            // 
            this.RD_OC.AutoSize = true;
            this.RD_OC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RD_OC.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RD_OC.ForeColor = System.Drawing.Color.White;
            this.RD_OC.Location = new System.Drawing.Point(22, 58);
            this.RD_OC.Name = "RD_OC";
            this.RD_OC.Size = new System.Drawing.Size(144, 21);
            this.RD_OC.TabIndex = 0;
            this.RD_OC.Text = "From Black to 1 Color";
            this.RD_OC.UseVisualStyleBackColor = true;
            this.RD_OC.CheckedChanged += new System.EventHandler(this.RD_Rainbow_CheckedChanged);
            // 
            // Music_Apply
            // 
            this.Music_Apply.BackColor = System.Drawing.Color.White;
            this.Music_Apply.FlatAppearance.BorderSize = 0;
            this.Music_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Music_Apply.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Music_Apply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Music_Apply.Location = new System.Drawing.Point(391, 52);
            this.Music_Apply.Name = "Music_Apply";
            this.Music_Apply.Size = new System.Drawing.Size(116, 32);
            this.Music_Apply.TabIndex = 7;
            this.Music_Apply.Text = "Start";
            this.Music_Apply.UseVisualStyleBackColor = false;
            this.Music_Apply.Click += new System.EventHandler(this.Music_Apply_Click);
            // 
            // RD_GR
            // 
            this.RD_GR.AutoSize = true;
            this.RD_GR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RD_GR.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RD_GR.ForeColor = System.Drawing.Color.White;
            this.RD_GR.Location = new System.Drawing.Point(204, 12);
            this.RD_GR.Name = "RD_GR";
            this.RD_GR.Size = new System.Drawing.Size(306, 21);
            this.RD_GR.TabIndex = 0;
            this.RD_GR.Text = "From Green to Red (Better to set Sensativity to -5)";
            this.RD_GR.UseVisualStyleBackColor = true;
            this.RD_GR.CheckedChanged += new System.EventHandler(this.RD_Rainbow_CheckedChanged);
            // 
            // RD_Rainbow
            // 
            this.RD_Rainbow.AutoSize = true;
            this.RD_Rainbow.Checked = true;
            this.RD_Rainbow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RD_Rainbow.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RD_Rainbow.ForeColor = System.Drawing.Color.White;
            this.RD_Rainbow.Location = new System.Drawing.Point(22, 12);
            this.RD_Rainbow.Name = "RD_Rainbow";
            this.RD_Rainbow.Size = new System.Drawing.Size(141, 21);
            this.RD_Rainbow.TabIndex = 0;
            this.RD_Rainbow.TabStop = true;
            this.RD_Rainbow.Text = "Hue Color (Rainbow)";
            this.RD_Rainbow.UseVisualStyleBackColor = true;
            this.RD_Rainbow.CheckedChanged += new System.EventHandler(this.RD_Rainbow_CheckedChanged);
            // 
            // M_Sens
            // 
            this.M_Sens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.M_Sens.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.M_Sens.Location = new System.Drawing.Point(91, 11);
            this.M_Sens.Maximum = 5;
            this.M_Sens.Minimum = -5;
            this.M_Sens.Name = "M_Sens";
            this.M_Sens.Size = new System.Drawing.Size(288, 45);
            this.M_Sens.TabIndex = 6;
            this.M_Sens.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.M_Sens.Scroll += new System.EventHandler(this.M_Sens_Scroll);
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.BackColor = System.Drawing.Color.Transparent;
            this.lblCM.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCM.ForeColor = System.Drawing.Color.White;
            this.lblCM.Location = new System.Drawing.Point(14, 88);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(76, 17);
            this.lblCM.TabIndex = 8;
            this.lblCM.Text = "Color Mode:";
            // 
            // lbl_S_Value
            // 
            this.lbl_S_Value.BackColor = System.Drawing.Color.Transparent;
            this.lbl_S_Value.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_S_Value.ForeColor = System.Drawing.Color.White;
            this.lbl_S_Value.Location = new System.Drawing.Point(387, 23);
            this.lbl_S_Value.Name = "lbl_S_Value";
            this.lbl_S_Value.Size = new System.Drawing.Size(83, 17);
            this.lbl_S_Value.TabIndex = 8;
            this.lbl_S_Value.Text = "0 (default)";
            // 
            // APPcontrolbar
            // 
            this.APPcontrolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.APPcontrolbar.Controls.Add(this.APPnamelbl);
            this.APPcontrolbar.Controls.Add(this.APPicon);
            this.APPcontrolbar.Controls.Add(this.btnMinimize);
            this.APPcontrolbar.Controls.Add(this.btnExit);
            this.APPcontrolbar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.APPcontrolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.APPcontrolbar.Location = new System.Drawing.Point(0, 0);
            this.APPcontrolbar.Name = "APPcontrolbar";
            this.APPcontrolbar.Size = new System.Drawing.Size(878, 28);
            this.APPcontrolbar.TabIndex = 9;
            this.APPcontrolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APPcontrolbar_MouseDown);
            this.APPcontrolbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APPcontrolbar_MouseMove);
            this.APPcontrolbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.APPcontrolbar_MouseUp);
            // 
            // APPnamelbl
            // 
            this.APPnamelbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.APPnamelbl.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPnamelbl.ForeColor = System.Drawing.Color.White;
            this.APPnamelbl.Location = new System.Drawing.Point(39, 0);
            this.APPnamelbl.Name = "APPnamelbl";
            this.APPnamelbl.Size = new System.Drawing.Size(144, 28);
            this.APPnamelbl.TabIndex = 2;
            this.APPnamelbl.Text = "MSI Magic Light";
            this.APPnamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.APPnamelbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APPcontrolbar_MouseDown);
            this.APPnamelbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APPcontrolbar_MouseMove);
            this.APPnamelbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.APPcontrolbar_MouseUp);
            // 
            // APPicon
            // 
            this.APPicon.BackgroundImage = global::MSI_Magic_Light.Properties.Resources.icon;
            this.APPicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.APPicon.Dock = System.Windows.Forms.DockStyle.Left;
            this.APPicon.Location = new System.Drawing.Point(0, 0);
            this.APPicon.Name = "APPicon";
            this.APPicon.Size = new System.Drawing.Size(39, 28);
            this.APPicon.TabIndex = 1;
            this.APPicon.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(810, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 28);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(844, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Music_Panel);
            this.splitContainer1.Size = new System.Drawing.Size(878, 426);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Rainbow Mode";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Police Mode";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Music Visualizer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 74);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 74);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Your Mode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Police_Mode
            // 
            this.Police_Mode.WorkerReportsProgress = true;
            this.Police_Mode.WorkerSupportsCancellation = true;
            this.Police_Mode.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Police_Mode_DoWork);
            // 
            // MagicIcon
            // 
            this.MagicIcon.ContextMenuStrip = this.IconMenu;
            this.MagicIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MagicIcon.Icon")));
            this.MagicIcon.Text = "MSI Magic Light";
            this.MagicIcon.Visible = true;
            this.MagicIcon.DoubleClick += new System.EventHandler(this.MagicIcon_DoubleClick);
            // 
            // IconMenu
            // 
            this.IconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicVisualizerToolStripMenuItem,
            this.policeModeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.IconMenu.Name = "IconMenu";
            this.IconMenu.Size = new System.Drawing.Size(159, 70);
            // 
            // musicVisualizerToolStripMenuItem
            // 
            this.musicVisualizerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rainbowModeToolStripMenuItem,
            this.greenToRedToolStripMenuItem,
            this.fromBlackTo1ColorToolStripMenuItem});
            this.musicVisualizerToolStripMenuItem.Name = "musicVisualizerToolStripMenuItem";
            this.musicVisualizerToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.musicVisualizerToolStripMenuItem.Text = "Music Visualizer";
            // 
            // rainbowModeToolStripMenuItem
            // 
            this.rainbowModeToolStripMenuItem.Checked = true;
            this.rainbowModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rainbowModeToolStripMenuItem.Name = "rainbowModeToolStripMenuItem";
            this.rainbowModeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.rainbowModeToolStripMenuItem.Text = "Rainbow Mode";
            this.rainbowModeToolStripMenuItem.Click += new System.EventHandler(this.rainbowModeToolStripMenuItem_Click);
            // 
            // greenToRedToolStripMenuItem
            // 
            this.greenToRedToolStripMenuItem.Name = "greenToRedToolStripMenuItem";
            this.greenToRedToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.greenToRedToolStripMenuItem.Text = "Green to Red";
            this.greenToRedToolStripMenuItem.Click += new System.EventHandler(this.greenToRedToolStripMenuItem_Click);
            // 
            // fromBlackTo1ColorToolStripMenuItem
            // 
            this.fromBlackTo1ColorToolStripMenuItem.Name = "fromBlackTo1ColorToolStripMenuItem";
            this.fromBlackTo1ColorToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.fromBlackTo1ColorToolStripMenuItem.Text = "From Black to 1 Color";
            this.fromBlackTo1ColorToolStripMenuItem.Click += new System.EventHandler(this.fromBlackTo1ColorToolStripMenuItem_Click);
            // 
            // policeModeToolStripMenuItem
            // 
            this.policeModeToolStripMenuItem.Name = "policeModeToolStripMenuItem";
            this.policeModeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.policeModeToolStripMenuItem.Text = "Police Mode";
            this.policeModeToolStripMenuItem.Click += new System.EventHandler(this.policeModeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(878, 454);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.APPcontrolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Visualizer_Image)).EndInit();
            this.Music_Panel.ResumeLayout(false);
            this.Police_Control_Panel.ResumeLayout(false);
            this.Police_Control_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Police_Color2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Police_Color1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Police_Speed_TB)).EndInit();
            this.Music_Controller_Panel.ResumeLayout(false);
            this.Music_Controller_Panel.PerformLayout();
            this.Color_Mode_Panel.ResumeLayout(false);
            this.Color_Mode_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PickerVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_Sens)).EndInit();
            this.APPcontrolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.APPicon)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.IconMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker Audio_Visualizer;
        private System.Windows.Forms.PictureBox Visualizer_Image;
        private System.Windows.Forms.Panel Music_Panel;
        private System.Windows.Forms.Button Music_Apply;
        private System.Windows.Forms.TrackBar M_Sens;
        private System.Windows.Forms.Label lblSensitivity;
        internal System.Windows.Forms.Panel APPcontrolbar;
        internal System.Windows.Forms.Label APPnamelbl;
        internal System.Windows.Forms.PictureBox APPicon;
        internal System.Windows.Forms.Button btnMinimize;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel Color_Mode_Panel;
        private System.Windows.Forms.RadioButton RD_GR;
        private System.Windows.Forms.RadioButton RD_Rainbow;
        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.Label lbl_S_Value;
        private System.Windows.Forms.PictureBox PickerVal;
        private System.Windows.Forms.RadioButton RD_OC;
        private System.Windows.Forms.ColorDialog Picker;
        private System.Windows.Forms.Panel Music_Controller_Panel;
        private System.ComponentModel.BackgroundWorker Police_Mode;
        private System.Windows.Forms.Panel Police_Control_Panel;
        private System.Windows.Forms.TrackBar Police_Speed_TB;
        private System.Windows.Forms.Label lbl_P_Val;
        private System.Windows.Forms.Label lbl_P_Speed;
        private System.Windows.Forms.Button PoliceBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Police_Color2;
        private System.Windows.Forms.PictureBox Police_Color1;
        private System.Windows.Forms.NotifyIcon MagicIcon;
        private System.Windows.Forms.ContextMenuStrip IconMenu;
        private System.Windows.Forms.ToolStripMenuItem musicVisualizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rainbowModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToRedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromBlackTo1ColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policeModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

