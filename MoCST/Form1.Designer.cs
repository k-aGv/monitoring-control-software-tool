
namespace Elaiotriveio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realtimevaluesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realTimeGraphMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogsFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelCompatibilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertXmlFileToTxtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.convertXmlFileToXlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.logger = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.sensor3CB = new System.Windows.Forms.CheckBox();
            this.sensor4CB = new System.Windows.Forms.CheckBox();
            this.sensor2CB = new System.Windows.Forms.CheckBox();
            this.start = new System.Windows.Forms.Button();
            this.sensor1CB = new System.Windows.Forms.CheckBox();
            this.sensor4label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.minutelabel = new System.Windows.Forms.Label();
            this.scheduledstart = new System.Windows.Forms.Label();
            this.hourlabel = new System.Windows.Forms.Label();
            this.startminute = new System.Windows.Forms.NumericUpDown();
            this.scheduledstop = new System.Windows.Forms.Label();
            this.starthour = new System.Windows.Forms.NumericUpDown();
            this.endminute = new System.Windows.Forms.NumericUpDown();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.datelabel = new System.Windows.Forms.Label();
            this.endhour = new System.Windows.Forms.NumericUpDown();
            this.sensor3label = new System.Windows.Forms.Label();
            this.ScheduledMonitorCB = new System.Windows.Forms.CheckBox();
            this.sensor2label = new System.Windows.Forms.Label();
            this.ScheduledMonitorLabel = new System.Windows.Forms.Label();
            this.sensor1label = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.is_busy_check_timer = new System.Windows.Forms.Timer(this.components);
            this.selectedportlabel = new System.Windows.Forms.Label();
            this.arduino_sampler = new System.Windows.Forms.Timer(this.components);
            this.selectedCOM = new System.Windows.Forms.Label();
            this.gpControls = new System.Windows.Forms.GroupBox();
            this.dtrLed = new System.Windows.Forms.TextBox();
            this.rtsLed = new System.Windows.Forms.TextBox();
            this.lbRTS = new System.Windows.Forms.Label();
            this.lbDTR = new System.Windows.Forms.Label();
            this.lbSamplingTime = new System.Windows.Forms.Label();
            this.lbSampling = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cb_demo = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startminute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starthour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endminute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endhour)).BeginInit();
            this.gpControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.PreviewToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.ApplicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(411, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portToolStripMenuItem,
            this.aToolStripMenuItem,
            this.bToolStripMenuItem});
            this.settingsToolStripMenuItem.Enabled = false;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.portToolStripMenuItem.Text = "Port";
            this.portToolStripMenuItem.Click += new System.EventHandler(this.portToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aToolStripMenuItem.Text = "DTR";
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem1,
            this.disableToolStripMenuItem1});
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bToolStripMenuItem.Text = "RTS";
            // 
            // enableToolStripMenuItem1
            // 
            this.enableToolStripMenuItem1.Name = "enableToolStripMenuItem1";
            this.enableToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.enableToolStripMenuItem1.Text = "Enable";
            this.enableToolStripMenuItem1.Click += new System.EventHandler(this.enableToolStripMenuItem1_Click);
            // 
            // disableToolStripMenuItem1
            // 
            this.disableToolStripMenuItem1.Name = "disableToolStripMenuItem1";
            this.disableToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.disableToolStripMenuItem1.Text = "Disable";
            this.disableToolStripMenuItem1.Click += new System.EventHandler(this.disableToolStripMenuItem1_Click);
            // 
            // PreviewToolStripMenuItem
            // 
            this.PreviewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realtimevaluesToolStripMenuItem,
            this.realTimeGraphMonitoringToolStripMenuItem});
            this.PreviewToolStripMenuItem.Name = "PreviewToolStripMenuItem";
            this.PreviewToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.PreviewToolStripMenuItem.Text = "Activity Monitor";
            // 
            // realtimevaluesToolStripMenuItem
            // 
            this.realtimevaluesToolStripMenuItem.Enabled = false;
            this.realtimevaluesToolStripMenuItem.Name = "realtimevaluesToolStripMenuItem";
            this.realtimevaluesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.realtimevaluesToolStripMenuItem.Text = "Real time values";
            this.realtimevaluesToolStripMenuItem.Click += new System.EventHandler(this.realtimevaluesToolStripMenuItem_Click);
            // 
            // realTimeGraphMonitoringToolStripMenuItem
            // 
            this.realTimeGraphMonitoringToolStripMenuItem.Enabled = false;
            this.realTimeGraphMonitoringToolStripMenuItem.Name = "realTimeGraphMonitoringToolStripMenuItem";
            this.realTimeGraphMonitoringToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.realTimeGraphMonitoringToolStripMenuItem.Text = "Real time graphs";
            this.realTimeGraphMonitoringToolStripMenuItem.Click += new System.EventHandler(this.realTimeGraphMonitoringToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLogsFormToolStripMenuItem,
            this.excelCompatibilityToolStripMenuItem});
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.openFileToolStripMenuItem.Text = "Recordings";
            // 
            // openLogsFormToolStripMenuItem
            // 
            this.openLogsFormToolStripMenuItem.Name = "openLogsFormToolStripMenuItem";
            this.openLogsFormToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.openLogsFormToolStripMenuItem.Text = "Compare Recordings";
            this.openLogsFormToolStripMenuItem.Click += new System.EventHandler(this.openLogsFormToolStripMenuItem_Click);
            // 
            // excelCompatibilityToolStripMenuItem
            // 
            this.excelCompatibilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertXmlFileToTxtToolStripMenuItem1,
            this.convertXmlFileToXlsToolStripMenuItem});
            this.excelCompatibilityToolStripMenuItem.Name = "excelCompatibilityToolStripMenuItem";
            this.excelCompatibilityToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.excelCompatibilityToolStripMenuItem.Text = "Excel compatibility";
            this.excelCompatibilityToolStripMenuItem.ToolTipText = "Chose an xml output file to convert\r\ninto an Excel-friendly format.";
            // 
            // convertXmlFileToTxtToolStripMenuItem1
            // 
            this.convertXmlFileToTxtToolStripMenuItem1.Name = "convertXmlFileToTxtToolStripMenuItem1";
            this.convertXmlFileToTxtToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.convertXmlFileToTxtToolStripMenuItem1.Text = "Convert xml file to txt";
            this.convertXmlFileToTxtToolStripMenuItem1.ToolTipText = "Creates a Comma Seperated Values (CSV) file\r\nfor Excel to import.";
            this.convertXmlFileToTxtToolStripMenuItem1.Click += new System.EventHandler(this.convertXmlFileToTxtToolStripMenuItem1_Click);
            // 
            // convertXmlFileToXlsToolStripMenuItem
            // 
            this.convertXmlFileToXlsToolStripMenuItem.Name = "convertXmlFileToXlsToolStripMenuItem";
            this.convertXmlFileToXlsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.convertXmlFileToXlsToolStripMenuItem.Text = "Convert xml file to xlsx";
            this.convertXmlFileToXlsToolStripMenuItem.ToolTipText = "Creates a new .xlsx file ready to open with\r\nExcel. Takes more time than \"xml to " +
    "txt\" conversion";
            this.convertXmlFileToXlsToolStripMenuItem.Click += new System.EventHandler(this.convertXmlFileToXlsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.howToUseToolStripMenuItem.Text = "Manual";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ApplicationToolStripMenuItem
            // 
            this.ApplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.ApplicationToolStripMenuItem.Name = "ApplicationToolStripMenuItem";
            this.ApplicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.ApplicationToolStripMenuItem.Text = "Application";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // logger
            // 
            this.logger.Interval = 1000;
            this.logger.Tick += new System.EventHandler(this.logger_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // sensor3CB
            // 
            this.sensor3CB.AutoSize = true;
            this.sensor3CB.Checked = true;
            this.sensor3CB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sensor3CB.Location = new System.Drawing.Point(67, 115);
            this.sensor3CB.Name = "sensor3CB";
            this.sensor3CB.Size = new System.Drawing.Size(15, 14);
            this.sensor3CB.TabIndex = 7;
            this.sensor3CB.UseVisualStyleBackColor = true;
            // 
            // sensor4CB
            // 
            this.sensor4CB.AutoSize = true;
            this.sensor4CB.Checked = true;
            this.sensor4CB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sensor4CB.Location = new System.Drawing.Point(66, 147);
            this.sensor4CB.Name = "sensor4CB";
            this.sensor4CB.Size = new System.Drawing.Size(15, 14);
            this.sensor4CB.TabIndex = 8;
            this.sensor4CB.UseVisualStyleBackColor = true;
            // 
            // sensor2CB
            // 
            this.sensor2CB.AutoSize = true;
            this.sensor2CB.Checked = true;
            this.sensor2CB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sensor2CB.Location = new System.Drawing.Point(67, 81);
            this.sensor2CB.Name = "sensor2CB";
            this.sensor2CB.Size = new System.Drawing.Size(15, 14);
            this.sensor2CB.TabIndex = 6;
            this.sensor2CB.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(146, 51);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(64, 23);
            this.start.TabIndex = 9;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // sensor1CB
            // 
            this.sensor1CB.AutoSize = true;
            this.sensor1CB.Checked = true;
            this.sensor1CB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sensor1CB.Location = new System.Drawing.Point(67, 50);
            this.sensor1CB.Name = "sensor1CB";
            this.sensor1CB.Size = new System.Drawing.Size(15, 14);
            this.sensor1CB.TabIndex = 5;
            this.sensor1CB.UseVisualStyleBackColor = true;
            // 
            // sensor4label
            // 
            this.sensor4label.AutoSize = true;
            this.sensor4label.Location = new System.Drawing.Point(12, 147);
            this.sensor4label.Name = "sensor4label";
            this.sensor4label.Size = new System.Drawing.Size(49, 13);
            this.sensor4label.TabIndex = 3;
            this.sensor4label.Text = "Sensor 4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startdate);
            this.groupBox1.Controls.Add(this.minutelabel);
            this.groupBox1.Controls.Add(this.scheduledstart);
            this.groupBox1.Controls.Add(this.hourlabel);
            this.groupBox1.Controls.Add(this.startminute);
            this.groupBox1.Controls.Add(this.scheduledstop);
            this.groupBox1.Controls.Add(this.starthour);
            this.groupBox1.Controls.Add(this.endminute);
            this.groupBox1.Controls.Add(this.enddate);
            this.groupBox1.Controls.Add(this.datelabel);
            this.groupBox1.Controls.Add(this.endhour);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 90);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scheduled monitor";
            this.groupBox1.Visible = false;
            // 
            // startdate
            // 
            this.startdate.CustomFormat = "dd / MM / yyyy";
            this.startdate.Location = new System.Drawing.Point(90, 32);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(183, 20);
            this.startdate.TabIndex = 19;
            this.startdate.Visible = false;
            // 
            // minutelabel
            // 
            this.minutelabel.AutoSize = true;
            this.minutelabel.Location = new System.Drawing.Point(340, 16);
            this.minutelabel.Name = "minutelabel";
            this.minutelabel.Size = new System.Drawing.Size(39, 13);
            this.minutelabel.TabIndex = 28;
            this.minutelabel.Text = "Minute";
            // 
            // scheduledstart
            // 
            this.scheduledstart.AutoSize = true;
            this.scheduledstart.Location = new System.Drawing.Point(6, 38);
            this.scheduledstart.Name = "scheduledstart";
            this.scheduledstart.Size = new System.Drawing.Size(84, 13);
            this.scheduledstart.TabIndex = 25;
            this.scheduledstart.Text = "Start monitor at: ";
            this.scheduledstart.Visible = false;
            // 
            // hourlabel
            // 
            this.hourlabel.AutoSize = true;
            this.hourlabel.Location = new System.Drawing.Point(286, 16);
            this.hourlabel.Name = "hourlabel";
            this.hourlabel.Size = new System.Drawing.Size(30, 13);
            this.hourlabel.TabIndex = 27;
            this.hourlabel.Text = "Hour";
            // 
            // startminute
            // 
            this.startminute.Location = new System.Drawing.Point(337, 32);
            this.startminute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.startminute.Name = "startminute";
            this.startminute.Size = new System.Drawing.Size(42, 20);
            this.startminute.TabIndex = 21;
            this.startminute.Visible = false;
            // 
            // scheduledstop
            // 
            this.scheduledstop.AutoSize = true;
            this.scheduledstop.Location = new System.Drawing.Point(6, 57);
            this.scheduledstop.Name = "scheduledstop";
            this.scheduledstop.Size = new System.Drawing.Size(84, 13);
            this.scheduledstop.TabIndex = 34;
            this.scheduledstop.Text = "Stop monitor at: ";
            this.scheduledstop.Visible = false;
            // 
            // starthour
            // 
            this.starthour.Location = new System.Drawing.Point(280, 32);
            this.starthour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.starthour.Name = "starthour";
            this.starthour.Size = new System.Drawing.Size(42, 20);
            this.starthour.TabIndex = 20;
            this.starthour.Visible = false;
            // 
            // endminute
            // 
            this.endminute.Location = new System.Drawing.Point(337, 57);
            this.endminute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.endminute.Name = "endminute";
            this.endminute.Size = new System.Drawing.Size(42, 20);
            this.endminute.TabIndex = 33;
            this.endminute.Visible = false;
            // 
            // enddate
            // 
            this.enddate.CustomFormat = "Day, Month, dd-MM-yyyy";
            this.enddate.Location = new System.Drawing.Point(90, 57);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(183, 20);
            this.enddate.TabIndex = 31;
            this.enddate.Visible = false;
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Location = new System.Drawing.Point(164, 16);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(30, 13);
            this.datelabel.TabIndex = 26;
            this.datelabel.Text = "Date";
            // 
            // endhour
            // 
            this.endhour.Location = new System.Drawing.Point(280, 57);
            this.endhour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.endhour.Name = "endhour";
            this.endhour.Size = new System.Drawing.Size(42, 20);
            this.endhour.TabIndex = 32;
            this.endhour.Visible = false;
            // 
            // sensor3label
            // 
            this.sensor3label.AutoSize = true;
            this.sensor3label.Location = new System.Drawing.Point(12, 115);
            this.sensor3label.Name = "sensor3label";
            this.sensor3label.Size = new System.Drawing.Size(49, 13);
            this.sensor3label.TabIndex = 2;
            this.sensor3label.Text = "Sensor 3";
            // 
            // ScheduledMonitorCB
            // 
            this.ScheduledMonitorCB.AutoSize = true;
            this.ScheduledMonitorCB.Location = new System.Drawing.Point(146, 172);
            this.ScheduledMonitorCB.Name = "ScheduledMonitorCB";
            this.ScheduledMonitorCB.Size = new System.Drawing.Size(15, 14);
            this.ScheduledMonitorCB.TabIndex = 35;
            this.ScheduledMonitorCB.UseVisualStyleBackColor = true;
            this.ScheduledMonitorCB.CheckedChanged += new System.EventHandler(this.ScheduledMonitorCB_CheckedChanged);
            // 
            // sensor2label
            // 
            this.sensor2label.AutoSize = true;
            this.sensor2label.Location = new System.Drawing.Point(12, 81);
            this.sensor2label.Name = "sensor2label";
            this.sensor2label.Size = new System.Drawing.Size(49, 13);
            this.sensor2label.TabIndex = 1;
            this.sensor2label.Text = "Sensor 2";
            // 
            // ScheduledMonitorLabel
            // 
            this.ScheduledMonitorLabel.AutoSize = true;
            this.ScheduledMonitorLabel.Location = new System.Drawing.Point(12, 170);
            this.ScheduledMonitorLabel.Name = "ScheduledMonitorLabel";
            this.ScheduledMonitorLabel.Size = new System.Drawing.Size(128, 13);
            this.ScheduledMonitorLabel.TabIndex = 36;
            this.ScheduledMonitorLabel.Text = "Auto start/stop monitoring";
            // 
            // sensor1label
            // 
            this.sensor1label.AutoSize = true;
            this.sensor1label.Location = new System.Drawing.Point(12, 50);
            this.sensor1label.Name = "sensor1label";
            this.sensor1label.Size = new System.Drawing.Size(49, 13);
            this.sensor1label.TabIndex = 0;
            this.sensor1label.Text = "Sensor 1";
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(146, 81);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(64, 23);
            this.Stop.TabIndex = 37;
            this.Stop.Text = "Reset";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sensors to monitor:";
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(147, 110);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(63, 53);
            this.save.TabIndex = 39;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // is_busy_check_timer
            // 
            this.is_busy_check_timer.Interval = 10;
            this.is_busy_check_timer.Tick += new System.EventHandler(this.is_busy_check_timer_Tick);
            // 
            // selectedportlabel
            // 
            this.selectedportlabel.AutoSize = true;
            this.selectedportlabel.Location = new System.Drawing.Point(86, 17);
            this.selectedportlabel.Name = "selectedportlabel";
            this.selectedportlabel.Size = new System.Drawing.Size(35, 13);
            this.selectedportlabel.TabIndex = 40;
            this.selectedportlabel.Text = "label1";
            // 
            // arduino_sampler
            // 
            this.arduino_sampler.Interval = 1500;
            this.arduino_sampler.Tick += new System.EventHandler(this.arduino_sampler_Tick);
            // 
            // selectedCOM
            // 
            this.selectedCOM.AutoSize = true;
            this.selectedCOM.Location = new System.Drawing.Point(9, 17);
            this.selectedCOM.Name = "selectedCOM";
            this.selectedCOM.Size = new System.Drawing.Size(73, 13);
            this.selectedCOM.TabIndex = 41;
            this.selectedCOM.Text = "Selected port:";
            // 
            // gpControls
            // 
            this.gpControls.Controls.Add(this.dtrLed);
            this.gpControls.Controls.Add(this.rtsLed);
            this.gpControls.Controls.Add(this.lbRTS);
            this.gpControls.Controls.Add(this.lbDTR);
            this.gpControls.Controls.Add(this.lbSamplingTime);
            this.gpControls.Controls.Add(this.lbSampling);
            this.gpControls.Controls.Add(this.trackBar1);
            this.gpControls.Controls.Add(this.selectedCOM);
            this.gpControls.Controls.Add(this.selectedportlabel);
            this.gpControls.Location = new System.Drawing.Point(223, 28);
            this.gpControls.Name = "gpControls";
            this.gpControls.Size = new System.Drawing.Size(177, 158);
            this.gpControls.TabIndex = 42;
            this.gpControls.TabStop = false;
            this.gpControls.Text = "Sampling Control and info";
            // 
            // dtrLed
            // 
            this.dtrLed.BackColor = System.Drawing.SystemColors.Control;
            this.dtrLed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtrLed.Enabled = false;
            this.dtrLed.Location = new System.Drawing.Point(83, 99);
            this.dtrLed.Name = "dtrLed";
            this.dtrLed.ReadOnly = true;
            this.dtrLed.Size = new System.Drawing.Size(20, 20);
            this.dtrLed.TabIndex = 47;
            this.dtrLed.TabStop = false;
            // 
            // rtsLed
            // 
            this.rtsLed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtsLed.Enabled = false;
            this.rtsLed.Location = new System.Drawing.Point(83, 126);
            this.rtsLed.Name = "rtsLed";
            this.rtsLed.ReadOnly = true;
            this.rtsLed.Size = new System.Drawing.Size(20, 20);
            this.rtsLed.TabIndex = 47;
            this.rtsLed.TabStop = false;
            // 
            // lbRTS
            // 
            this.lbRTS.AutoSize = true;
            this.lbRTS.Location = new System.Drawing.Point(12, 131);
            this.lbRTS.Name = "lbRTS";
            this.lbRTS.Size = new System.Drawing.Size(55, 13);
            this.lbRTS.TabIndex = 46;
            this.lbRTS.Text = "RTS state";
            // 
            // lbDTR
            // 
            this.lbDTR.AutoSize = true;
            this.lbDTR.Location = new System.Drawing.Point(12, 104);
            this.lbDTR.Name = "lbDTR";
            this.lbDTR.Size = new System.Drawing.Size(56, 13);
            this.lbDTR.TabIndex = 45;
            this.lbDTR.Text = "DTR state";
            // 
            // lbSamplingTime
            // 
            this.lbSamplingTime.AutoSize = true;
            this.lbSamplingTime.Location = new System.Drawing.Point(86, 40);
            this.lbSamplingTime.Name = "lbSamplingTime";
            this.lbSamplingTime.Size = new System.Drawing.Size(13, 13);
            this.lbSamplingTime.TabIndex = 44;
            this.lbSamplingTime.Text = "0";
            // 
            // lbSampling
            // 
            this.lbSampling.AutoSize = true;
            this.lbSampling.Location = new System.Drawing.Point(9, 40);
            this.lbSampling.Name = "lbSampling";
            this.lbSampling.Size = new System.Drawing.Size(75, 13);
            this.lbSampling.TabIndex = 43;
            this.lbSampling.Text = "Sampling time:";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(6, 56);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(162, 45);
            this.trackBar1.TabIndex = 42;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 1;
            this.trackBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseMove);
            // 
            // cb_demo
            // 
            this.cb_demo.AutoSize = true;
            this.cb_demo.Checked = true;
            this.cb_demo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_demo.Location = new System.Drawing.Point(146, 28);
            this.cb_demo.Name = "cb_demo";
            this.cb_demo.Size = new System.Drawing.Size(54, 17);
            this.cb_demo.TabIndex = 43;
            this.cb_demo.Text = "Demo";
            this.cb_demo.UseVisualStyleBackColor = true;
            this.cb_demo.CheckedChanged += new System.EventHandler(this.cb_demo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 301);
            this.Controls.Add(this.cb_demo);
            this.Controls.Add(this.gpControls);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.ScheduledMonitorLabel);
            this.Controls.Add(this.ScheduledMonitorCB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.start);
            this.Controls.Add(this.sensor4CB);
            this.Controls.Add(this.sensor3CB);
            this.Controls.Add(this.sensor2CB);
            this.Controls.Add(this.sensor1CB);
            this.Controls.Add(this.sensor4label);
            this.Controls.Add(this.sensor3label);
            this.Controls.Add(this.sensor2label);
            this.Controls.Add(this.sensor1label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startminute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starthour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endminute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endhour)).EndInit();
            this.gpControls.ResumeLayout(false);
            this.gpControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realtimevaluesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realTimeGraphMonitoringToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer logger;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.CheckBox sensor3CB;
        private System.Windows.Forms.CheckBox sensor4CB;
        private System.Windows.Forms.CheckBox sensor2CB;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.CheckBox sensor1CB;
        private System.Windows.Forms.Label sensor4label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Label minutelabel;
        private System.Windows.Forms.Label scheduledstart;
        private System.Windows.Forms.Label hourlabel;
        private System.Windows.Forms.NumericUpDown startminute;
        private System.Windows.Forms.Label scheduledstop;
        private System.Windows.Forms.NumericUpDown starthour;
        private System.Windows.Forms.NumericUpDown endminute;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.NumericUpDown endhour;
        private System.Windows.Forms.Label sensor3label;
        private System.Windows.Forms.CheckBox ScheduledMonitorCB;
        private System.Windows.Forms.Label sensor2label;
        private System.Windows.Forms.Label ScheduledMonitorLabel;
        private System.Windows.Forms.Label sensor1label;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openLogsFormToolStripMenuItem;
        private System.Windows.Forms.Timer is_busy_check_timer;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.Label selectedportlabel;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem1;
        private System.Windows.Forms.Timer arduino_sampler;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label selectedCOM;
        private System.Windows.Forms.GroupBox gpControls;
        private System.Windows.Forms.Label lbSamplingTime;
        private System.Windows.Forms.Label lbSampling;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox dtrLed;
        private System.Windows.Forms.TextBox rtsLed;
        private System.Windows.Forms.Label lbRTS;
        private System.Windows.Forms.Label lbDTR;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem ApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelCompatibilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertXmlFileToTxtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem convertXmlFileToXlsToolStripMenuItem;
        private System.Windows.Forms.CheckBox cb_demo;
    }
}

