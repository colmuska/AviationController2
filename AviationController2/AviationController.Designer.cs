using System.Windows.Forms;

namespace AviationController2
{
    partial class AviationController
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxJoypadEnable = new System.Windows.Forms.CheckBox();
            this.trackBarJoyFlaps = new System.Windows.Forms.TrackBar();
            this.trackBarJoyThrottle = new System.Windows.Forms.TrackBar();
            this.trackBarJoyYaw = new System.Windows.Forms.TrackBar();
            this.trackBarJoyRole = new System.Windows.Forms.TrackBar();
            this.trackBarJoyPitch = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxJoypad = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonFileQue = new System.Windows.Forms.Button();
            this.buttonFileStart = new System.Windows.Forms.Button();
            this.buttonFileStop = new System.Windows.Forms.Button();
            this.buttonFileRewind = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.radioButtonSerial = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.page2Panel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBoxDrawAtCenter = new System.Windows.Forms.CheckBox();
            this.labelAoa = new System.Windows.Forms.Label();
            this.comboBoxDecimation = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSpeedKmph = new System.Windows.Forms.Label();
            this.labelSpeedMps = new System.Windows.Forms.Label();
            this.pictureBoxYZSpeed = new System.Windows.Forms.PictureBox();
            this.pictureBoxXYSpeed = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.buttonShowSpeed = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBoxPositionLogXZ = new System.Windows.Forms.PictureBox();
            this.comboBoxScaleZ = new System.Windows.Forms.ComboBox();
            this.comboBoxScaleXY = new System.Windows.Forms.ComboBox();
            this.pictureBoxPositionLogXY = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timerFilePlay = new System.Windows.Forms.Timer(this.components);
            this.cameraTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoyFlaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoyThrottle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoyYaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoyRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoyPitch)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.page2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYZSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXYSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPositionLogXZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPositionLogXY)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxJoypadEnable);
            this.panel1.Controls.Add(this.trackBarJoyFlaps);
            this.panel1.Controls.Add(this.trackBarJoyThrottle);
            this.panel1.Controls.Add(this.trackBarJoyYaw);
            this.panel1.Controls.Add(this.trackBarJoyRole);
            this.panel1.Controls.Add(this.trackBarJoyPitch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxJoypad);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 297);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxJoypadEnable
            // 
            this.checkBoxJoypadEnable.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxJoypadEnable.AutoSize = true;
            this.checkBoxJoypadEnable.Location = new System.Drawing.Point(219, 10);
            this.checkBoxJoypadEnable.Name = "checkBoxJoypadEnable";
            this.checkBoxJoypadEnable.Size = new System.Drawing.Size(48, 22);
            this.checkBoxJoypadEnable.TabIndex = 5;
            this.checkBoxJoypadEnable.Text = "enable";
            this.checkBoxJoypadEnable.UseVisualStyleBackColor = true;
            this.checkBoxJoypadEnable.CheckedChanged += new System.EventHandler(this.checkBoxJoypadEnable_CheckedChanged);
            // 
            // trackBarJoyFlaps
            // 
            this.trackBarJoyFlaps.Location = new System.Drawing.Point(55, 245);
            this.trackBarJoyFlaps.Maximum = 255;
            this.trackBarJoyFlaps.Name = "trackBarJoyFlaps";
            this.trackBarJoyFlaps.Size = new System.Drawing.Size(212, 45);
            this.trackBarJoyFlaps.TabIndex = 4;
            // 
            // trackBarJoyThrottle
            // 
            this.trackBarJoyThrottle.Location = new System.Drawing.Point(55, 194);
            this.trackBarJoyThrottle.Maximum = 255;
            this.trackBarJoyThrottle.Name = "trackBarJoyThrottle";
            this.trackBarJoyThrottle.Size = new System.Drawing.Size(212, 45);
            this.trackBarJoyThrottle.TabIndex = 4;
            // 
            // trackBarJoyYaw
            // 
            this.trackBarJoyYaw.Location = new System.Drawing.Point(55, 143);
            this.trackBarJoyYaw.Maximum = 255;
            this.trackBarJoyYaw.Name = "trackBarJoyYaw";
            this.trackBarJoyYaw.Size = new System.Drawing.Size(212, 45);
            this.trackBarJoyYaw.TabIndex = 4;
            // 
            // trackBarJoyRole
            // 
            this.trackBarJoyRole.Location = new System.Drawing.Point(55, 92);
            this.trackBarJoyRole.Maximum = 255;
            this.trackBarJoyRole.Name = "trackBarJoyRole";
            this.trackBarJoyRole.Size = new System.Drawing.Size(212, 45);
            this.trackBarJoyRole.TabIndex = 3;
            // 
            // trackBarJoyPitch
            // 
            this.trackBarJoyPitch.Location = new System.Drawing.Point(55, 41);
            this.trackBarJoyPitch.Maximum = 255;
            this.trackBarJoyPitch.Name = "trackBarJoyPitch";
            this.trackBarJoyPitch.Size = new System.Drawing.Size(212, 45);
            this.trackBarJoyPitch.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "flaps:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "throttle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "yaw:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "pitch:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "device:";
            // 
            // comboBoxJoypad
            // 
            this.comboBoxJoypad.FormattingEnabled = true;
            this.comboBoxJoypad.Location = new System.Drawing.Point(49, 12);
            this.comboBoxJoypad.Name = "comboBoxJoypad";
            this.comboBoxJoypad.Size = new System.Drawing.Size(164, 20);
            this.comboBoxJoypad.TabIndex = 0;
            this.comboBoxJoypad.SelectedIndexChanged += new System.EventHandler(this.comboBoxJoypad_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 218);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.filenameLabel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.buttonFileQue);
            this.groupBox3.Controls.Add(this.buttonFileStart);
            this.groupBox3.Controls.Add(this.buttonFileStop);
            this.groupBox3.Controls.Add(this.buttonFileRewind);
            this.groupBox3.Location = new System.Drawing.Point(5, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File";
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Location = new System.Drawing.Point(46, 18);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(58, 12);
            this.filenameLabel.TabIndex = 5;
            this.filenameLabel.Text = "not loaded";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "File:";
            // 
            // buttonFileQue
            // 
            this.buttonFileQue.Image = global::AviationController2.Properties.Resources.playback_next_icon_24;
            this.buttonFileQue.Location = new System.Drawing.Point(116, 37);
            this.buttonFileQue.Name = "buttonFileQue";
            this.buttonFileQue.Size = new System.Drawing.Size(30, 30);
            this.buttonFileQue.TabIndex = 3;
            this.buttonFileQue.UseVisualStyleBackColor = true;
            this.buttonFileQue.Click += new System.EventHandler(this.buttonFileQue_Click);
            // 
            // buttonFileStart
            // 
            this.buttonFileStart.Image = global::AviationController2.Properties.Resources.playback_play_icon_24;
            this.buttonFileStart.Location = new System.Drawing.Point(78, 36);
            this.buttonFileStart.Name = "buttonFileStart";
            this.buttonFileStart.Size = new System.Drawing.Size(32, 31);
            this.buttonFileStart.TabIndex = 0;
            this.buttonFileStart.UseVisualStyleBackColor = true;
            this.buttonFileStart.Click += new System.EventHandler(this.buttonFileStart_Click);
            // 
            // buttonFileStop
            // 
            this.buttonFileStop.Image = global::AviationController2.Properties.Resources.playback_stop_icon_24;
            this.buttonFileStop.Location = new System.Drawing.Point(42, 36);
            this.buttonFileStop.Name = "buttonFileStop";
            this.buttonFileStop.Size = new System.Drawing.Size(30, 30);
            this.buttonFileStop.TabIndex = 2;
            this.buttonFileStop.UseVisualStyleBackColor = true;
            this.buttonFileStop.Click += new System.EventHandler(this.buttonFileStop_Click);
            // 
            // buttonFileRewind
            // 
            this.buttonFileRewind.Image = global::AviationController2.Properties.Resources.playback_prev_icon_24;
            this.buttonFileRewind.Location = new System.Drawing.Point(6, 36);
            this.buttonFileRewind.Name = "buttonFileRewind";
            this.buttonFileRewind.Size = new System.Drawing.Size(30, 30);
            this.buttonFileRewind.TabIndex = 1;
            this.buttonFileRewind.UseVisualStyleBackColor = true;
            this.buttonFileRewind.Click += new System.EventHandler(this.buttonFileRewind_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonFile);
            this.groupBox2.Controls.Add(this.radioButtonSerial);
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Source";
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.Checked = true;
            this.radioButtonFile.Location = new System.Drawing.Point(6, 40);
            this.radioButtonFile.Name = "radioButtonFile";
            this.radioButtonFile.Size = new System.Drawing.Size(39, 16);
            this.radioButtonFile.TabIndex = 1;
            this.radioButtonFile.TabStop = true;
            this.radioButtonFile.Text = "file";
            this.radioButtonFile.UseVisualStyleBackColor = true;
            // 
            // radioButtonSerial
            // 
            this.radioButtonSerial.AutoSize = true;
            this.radioButtonSerial.Location = new System.Drawing.Point(6, 18);
            this.radioButtonSerial.Name = "radioButtonSerial";
            this.radioButtonSerial.Size = new System.Drawing.Size(51, 16);
            this.radioButtonSerial.TabIndex = 0;
            this.radioButtonSerial.Text = "serial";
            this.radioButtonSerial.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxSerialPort);
            this.groupBox1.Location = new System.Drawing.Point(3, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Port:";
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(68, 18);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSerialPort.TabIndex = 0;
            this.comboBoxSerialPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPort_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(12, 555);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 238);
            this.panel3.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "print attitude earthframe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "print attitude";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "reset inu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // commandTextBox
            // 
            this.commandTextBox.CausesValidation = false;
            this.commandTextBox.Location = new System.Drawing.Point(290, 774);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(1040, 19);
            this.commandTextBox.TabIndex = 3;
            this.commandTextBox.WordWrap = false;
            this.commandTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandTextBox_KeyDown);
            this.commandTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commandTextBox_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(290, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1100, 740);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.logTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1092, 714);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(0, 3);
            this.logTextBox.MaxLength = 1000;
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(1089, 715);
            this.logTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.page2Panel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1092, 714);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // page2Panel
            // 
            this.page2Panel.Controls.Add(this.panel6);
            this.page2Panel.Controls.Add(this.panel5);
            this.page2Panel.Controls.Add(this.panel4);
            this.page2Panel.Controls.Add(this.checkBoxDrawAtCenter);
            this.page2Panel.Controls.Add(this.labelAoa);
            this.page2Panel.Controls.Add(this.comboBoxDecimation);
            this.page2Panel.Controls.Add(this.label11);
            this.page2Panel.Controls.Add(this.labelSpeedKmph);
            this.page2Panel.Controls.Add(this.labelSpeedMps);
            this.page2Panel.Controls.Add(this.pictureBoxYZSpeed);
            this.page2Panel.Controls.Add(this.pictureBoxXYSpeed);
            this.page2Panel.Controls.Add(this.label13);
            this.page2Panel.Controls.Add(this.label10);
            this.page2Panel.Controls.Add(this.labelPosition);
            this.page2Panel.Controls.Add(this.buttonShowSpeed);
            this.page2Panel.Controls.Add(this.label12);
            this.page2Panel.Controls.Add(this.label9);
            this.page2Panel.Controls.Add(this.pictureBoxPositionLogXZ);
            this.page2Panel.Controls.Add(this.comboBoxScaleZ);
            this.page2Panel.Controls.Add(this.comboBoxScaleXY);
            this.page2Panel.Controls.Add(this.pictureBoxPositionLogXY);
            this.page2Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page2Panel.Location = new System.Drawing.Point(3, 3);
            this.page2Panel.Name = "page2Panel";
            this.page2Panel.Size = new System.Drawing.Size(1086, 708);
            this.page2Panel.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(859, 337);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(161, 161);
            this.panel6.TabIndex = 15;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(859, 170);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(161, 161);
            this.panel5.TabIndex = 15;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(859, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(161, 161);
            this.panel4.TabIndex = 14;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4Paint);
            // 
            // checkBoxDrawAtCenter
            // 
            this.checkBoxDrawAtCenter.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDrawAtCenter.AutoSize = true;
            this.checkBoxDrawAtCenter.Location = new System.Drawing.Point(12, 173);
            this.checkBoxDrawAtCenter.Name = "checkBoxDrawAtCenter";
            this.checkBoxDrawAtCenter.Size = new System.Drawing.Size(83, 22);
            this.checkBoxDrawAtCenter.TabIndex = 13;
            this.checkBoxDrawAtCenter.Text = "Fixed/Center";
            this.checkBoxDrawAtCenter.UseVisualStyleBackColor = true;
            // 
            // labelAoa
            // 
            this.labelAoa.AutoSize = true;
            this.labelAoa.Location = new System.Drawing.Point(691, 400);
            this.labelAoa.Name = "labelAoa";
            this.labelAoa.Size = new System.Drawing.Size(63, 12);
            this.labelAoa.TabIndex = 12;
            this.labelAoa.Text = "AOA: 0 deg";
            // 
            // comboBoxDecimation
            // 
            this.comboBoxDecimation.FormattingEnabled = true;
            this.comboBoxDecimation.Items.AddRange(new object[] {
            "1",
            "10",
            "100"});
            this.comboBoxDecimation.Location = new System.Drawing.Point(76, 100);
            this.comboBoxDecimation.Name = "comboBoxDecimation";
            this.comboBoxDecimation.Size = new System.Drawing.Size(83, 20);
            this.comboBoxDecimation.TabIndex = 11;
            this.comboBoxDecimation.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "decimation";
            // 
            // labelSpeedKmph
            // 
            this.labelSpeedKmph.AutoSize = true;
            this.labelSpeedKmph.Location = new System.Drawing.Point(691, 371);
            this.labelSpeedKmph.Name = "labelSpeedKmph";
            this.labelSpeedKmph.Size = new System.Drawing.Size(38, 12);
            this.labelSpeedKmph.TabIndex = 8;
            this.labelSpeedKmph.Text = "0km/h";
            // 
            // labelSpeedMps
            // 
            this.labelSpeedMps.AutoSize = true;
            this.labelSpeedMps.Location = new System.Drawing.Point(691, 353);
            this.labelSpeedMps.Name = "labelSpeedMps";
            this.labelSpeedMps.Size = new System.Drawing.Size(32, 12);
            this.labelSpeedMps.TabIndex = 7;
            this.labelSpeedMps.Text = "0m/s";
            // 
            // pictureBoxYZSpeed
            // 
            this.pictureBoxYZSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxYZSpeed.Location = new System.Drawing.Point(693, 169);
            this.pictureBoxYZSpeed.Name = "pictureBoxYZSpeed";
            this.pictureBoxYZSpeed.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxYZSpeed.TabIndex = 6;
            this.pictureBoxYZSpeed.TabStop = false;
            this.pictureBoxYZSpeed.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxYZSpeed_Paint);
            // 
            // pictureBoxXYSpeed
            // 
            this.pictureBoxXYSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxXYSpeed.Location = new System.Drawing.Point(693, 3);
            this.pictureBoxXYSpeed.Name = "pictureBoxXYSpeed";
            this.pictureBoxXYSpeed.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxXYSpeed.TabIndex = 6;
            this.pictureBoxXYSpeed.TabStop = false;
            this.pictureBoxXYSpeed.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxXYSpeed_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(634, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 12);
            this.label13.TabIndex = 5;
            this.label13.Text = "SpeedYZ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(634, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "SpeedXY";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(10, 17);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(46, 12);
            this.labelPosition.TabIndex = 4;
            this.labelPosition.Text = "Position";
            // 
            // buttonShowSpeed
            // 
            this.buttonShowSpeed.Appearance = System.Windows.Forms.Appearance.Button;
            this.buttonShowSpeed.AutoSize = true;
            this.buttonShowSpeed.Location = new System.Drawing.Point(12, 141);
            this.buttonShowSpeed.Name = "buttonShowSpeed";
            this.buttonShowSpeed.Size = new System.Drawing.Size(76, 22);
            this.buttonShowSpeed.TabIndex = 3;
            this.buttonShowSpeed.Text = "Draw Speed";
            this.buttonShowSpeed.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "scale(Z)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "scale(X,Y)";
            // 
            // pictureBoxPositionLogXZ
            // 
            this.pictureBoxPositionLogXZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPositionLogXZ.Location = new System.Drawing.Point(165, 458);
            this.pictureBoxPositionLogXZ.Name = "pictureBoxPositionLogXZ";
            this.pictureBoxPositionLogXZ.Size = new System.Drawing.Size(450, 250);
            this.pictureBoxPositionLogXZ.TabIndex = 0;
            this.pictureBoxPositionLogXZ.TabStop = false;
            this.pictureBoxPositionLogXZ.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPositionLogYZ_Paint);
            // 
            // comboBoxScaleZ
            // 
            this.comboBoxScaleZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScaleZ.FormattingEnabled = true;
            this.comboBoxScaleZ.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBoxScaleZ.Items.AddRange(new object[] {
            "10m",
            "20m",
            "50m",
            "100m",
            "200m",
            "500m",
            "1km",
            "2km",
            "5km",
            "10km"});
            this.comboBoxScaleZ.Location = new System.Drawing.Point(72, 73);
            this.comboBoxScaleZ.Name = "comboBoxScaleZ";
            this.comboBoxScaleZ.Size = new System.Drawing.Size(87, 20);
            this.comboBoxScaleZ.TabIndex = 2;
            this.comboBoxScaleZ.Tag = "";
            this.comboBoxScaleZ.SelectedIndexChanged += new System.EventHandler(this.comboBoxScale_SelectedIndexChanged);
            // 
            // comboBoxScaleXY
            // 
            this.comboBoxScaleXY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScaleXY.FormattingEnabled = true;
            this.comboBoxScaleXY.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBoxScaleXY.Items.AddRange(new object[] {
            "10m",
            "20m",
            "50m",
            "100m",
            "200m",
            "500m",
            "1km",
            "2km",
            "5km",
            "10km"});
            this.comboBoxScaleXY.Location = new System.Drawing.Point(72, 47);
            this.comboBoxScaleXY.Name = "comboBoxScaleXY";
            this.comboBoxScaleXY.Size = new System.Drawing.Size(87, 20);
            this.comboBoxScaleXY.TabIndex = 1;
            this.comboBoxScaleXY.SelectedIndexChanged += new System.EventHandler(this.comboBoxScale_SelectedIndexChanged);
            // 
            // pictureBoxPositionLogXY
            // 
            this.pictureBoxPositionLogXY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPositionLogXY.Location = new System.Drawing.Point(165, 0);
            this.pictureBoxPositionLogXY.Name = "pictureBoxPositionLogXY";
            this.pictureBoxPositionLogXY.Size = new System.Drawing.Size(450, 450);
            this.pictureBoxPositionLogXY.TabIndex = 0;
            this.pictureBoxPositionLogXY.TabStop = false;
            this.pictureBoxPositionLogXY.Click += new System.EventHandler(this.pictureBoxPositionLogXY_Click);
            this.pictureBoxPositionLogXY.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPositionLogXY_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1402, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::AviationController2.Properties.Resources.doc_empty_icon_24;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::AviationController2.Properties.Resources.folder_open_icon_24;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::AviationController2.Properties.Resources.save_icon_24;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.ReadTimeout = 1000;
            this.serialPort1.WriteTimeout = 1000;
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "text files(*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "text files(*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // timerFilePlay
            // 
            this.timerFilePlay.Interval = 10;
            this.timerFilePlay.Tick += new System.EventHandler(this.timerFilePlay_Tick);
            // 
            // cameraTimer
            // 
            this.cameraTimer.Tick += new System.EventHandler(this.cameraTimer_Tick);
            // 
            // AviationController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1402, 802);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AviationController";
            this.Text = "AviationController";
            this.Load += new System.EventHandler(this.AviationController_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoyFlaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoyThrottle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoyYaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoyRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoyPitch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.page2Panel.ResumeLayout(false);
            this.page2Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYZSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXYSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPositionLogXZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPositionLogXY)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxJoypad;
        private System.Windows.Forms.TrackBar trackBarJoyFlaps;
        private System.Windows.Forms.TrackBar trackBarJoyThrottle;
        private System.Windows.Forms.TrackBar trackBarJoyYaw;
        private System.Windows.Forms.TrackBar trackBarJoyRole;
        private System.Windows.Forms.TrackBar trackBarJoyPitch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSerialPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxJoypadEnable;
        private System.IO.Ports.SerialPort serialPort1;
        private PictureBox pictureBoxPositionLogXY;
        private Button buttonFileStart;
        private Button buttonFileRewind;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private RadioButton radioButtonFile;
        private RadioButton radioButtonSerial;
        private GroupBox groupBox1;
        private Button buttonFileStop;
        private Button buttonFileQue;
        private Label filenameLabel;
        private Label label8;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Timer timerFilePlay;
        private Label label9;
        private ComboBox comboBoxScaleXY;
        private PictureBox pictureBoxPositionLogXZ;
        private Panel page2Panel;
        private CheckBox buttonShowSpeed;
        private PictureBox pictureBoxYZSpeed;
        private PictureBox pictureBoxXYSpeed;
        private Label label10;
        private Label labelPosition;
        private Label labelSpeedKmph;
        private Label labelSpeedMps;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox comboBoxDecimation;
        private Label label11;
        private Label label12;
        private ComboBox comboBoxScaleZ;
        private Label labelAoa;
        private Label label13;
        private CheckBox checkBoxDrawAtCenter;
        private Timer cameraTimer;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
    }
}

