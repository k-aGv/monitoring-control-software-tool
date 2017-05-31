namespace Elaiotriveio
{
    partial class realtimecharts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(realtimecharts));
            this.t4cb = new System.Windows.Forms.CheckBox();
            this.t2cb = new System.Windows.Forms.CheckBox();
            this.t1cb = new System.Windows.Forms.CheckBox();
            this.t3cb = new System.Windows.Forms.CheckBox();
            this.logger = new System.Windows.Forms.Timer(this.components);
            this.Sensors = new System.Windows.Forms.GroupBox();
            this.Thresholds = new System.Windows.Forms.GroupBox();
            this.s4temperature = new System.Windows.Forms.Label();
            this.s3temperature = new System.Windows.Forms.Label();
            this.s2temperature = new System.Windows.Forms.Label();
            this.s1temperature = new System.Windows.Forms.Label();
            this.sensor4 = new System.Windows.Forms.CheckBox();
            this.sensor2 = new System.Windows.Forms.CheckBox();
            this.sensor3 = new System.Windows.Forms.CheckBox();
            this.sensor4minthres = new System.Windows.Forms.NumericUpDown();
            this.sensor1 = new System.Windows.Forms.CheckBox();
            this.sensor4maxthres = new System.Windows.Forms.NumericUpDown();
            this.sensor3minthres = new System.Windows.Forms.NumericUpDown();
            this.sensor3maxthres = new System.Windows.Forms.NumericUpDown();
            this.sensor2minthres = new System.Windows.Forms.NumericUpDown();
            this.sensor2maxthres = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sensor1minthres = new System.Windows.Forms.NumericUpDown();
            this.sensor1maxthres = new System.Windows.Forms.NumericUpDown();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.scrollbar_tracker_CB = new System.Windows.Forms.CheckBox();
            this.Thresholds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensor4minthres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor4maxthres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor3minthres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor3maxthres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor2minthres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor2maxthres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor1minthres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor1maxthres)).BeginInit();
            this.SuspendLayout();
            // 
            // t4cb
            // 
            this.t4cb.AutoSize = true;
            this.t4cb.Checked = true;
            this.t4cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.t4cb.Location = new System.Drawing.Point(102, 455);
            this.t4cb.Name = "t4cb";
            this.t4cb.Size = new System.Drawing.Size(68, 17);
            this.t4cb.TabIndex = 12;
            this.t4cb.Text = "Sensor 4";
            this.t4cb.UseVisualStyleBackColor = true;
            this.t4cb.CheckedChanged += new System.EventHandler(this.t4cb_CheckedChanged);
            // 
            // t2cb
            // 
            this.t2cb.AutoSize = true;
            this.t2cb.Checked = true;
            this.t2cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.t2cb.Location = new System.Drawing.Point(102, 423);
            this.t2cb.Name = "t2cb";
            this.t2cb.Size = new System.Drawing.Size(68, 17);
            this.t2cb.TabIndex = 11;
            this.t2cb.Text = "Sensor 2";
            this.t2cb.UseVisualStyleBackColor = true;
            this.t2cb.CheckedChanged += new System.EventHandler(this.t2cb_CheckedChanged);
            // 
            // t1cb
            // 
            this.t1cb.AutoSize = true;
            this.t1cb.Checked = true;
            this.t1cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.t1cb.Location = new System.Drawing.Point(12, 423);
            this.t1cb.Name = "t1cb";
            this.t1cb.Size = new System.Drawing.Size(68, 17);
            this.t1cb.TabIndex = 9;
            this.t1cb.Text = "Sensor 1";
            this.t1cb.UseVisualStyleBackColor = true;
            this.t1cb.CheckedChanged += new System.EventHandler(this.t1cb_CheckedChanged);
            // 
            // t3cb
            // 
            this.t3cb.AutoSize = true;
            this.t3cb.Checked = true;
            this.t3cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.t3cb.Location = new System.Drawing.Point(12, 455);
            this.t3cb.Name = "t3cb";
            this.t3cb.Size = new System.Drawing.Size(68, 17);
            this.t3cb.TabIndex = 10;
            this.t3cb.Text = "Sensor 3";
            this.t3cb.UseVisualStyleBackColor = true;
            this.t3cb.CheckedChanged += new System.EventHandler(this.t3cb_CheckedChanged);
            // 
            // logger
            // 
            this.logger.Interval = 5000;
            this.logger.Tick += new System.EventHandler(this.logger_Tick);
            // 
            // Sensors
            // 
            this.Sensors.Location = new System.Drawing.Point(3, 400);
            this.Sensors.Name = "Sensors";
            this.Sensors.Size = new System.Drawing.Size(200, 79);
            this.Sensors.TabIndex = 15;
            this.Sensors.TabStop = false;
            this.Sensors.Text = "Sensors to display";
            // 
            // Thresholds
            // 
            this.Thresholds.Controls.Add(this.s4temperature);
            this.Thresholds.Controls.Add(this.s3temperature);
            this.Thresholds.Controls.Add(this.s2temperature);
            this.Thresholds.Controls.Add(this.s1temperature);
            this.Thresholds.Controls.Add(this.sensor4);
            this.Thresholds.Controls.Add(this.sensor2);
            this.Thresholds.Controls.Add(this.sensor3);
            this.Thresholds.Controls.Add(this.sensor4minthres);
            this.Thresholds.Controls.Add(this.sensor1);
            this.Thresholds.Controls.Add(this.sensor4maxthres);
            this.Thresholds.Controls.Add(this.sensor3minthres);
            this.Thresholds.Controls.Add(this.sensor3maxthres);
            this.Thresholds.Controls.Add(this.sensor2minthres);
            this.Thresholds.Controls.Add(this.sensor2maxthres);
            this.Thresholds.Controls.Add(this.label3);
            this.Thresholds.Controls.Add(this.label2);
            this.Thresholds.Controls.Add(this.sensor1minthres);
            this.Thresholds.Controls.Add(this.sensor1maxthres);
            this.Thresholds.Location = new System.Drawing.Point(235, 400);
            this.Thresholds.Name = "Thresholds";
            this.Thresholds.Size = new System.Drawing.Size(387, 114);
            this.Thresholds.TabIndex = 16;
            this.Thresholds.TabStop = false;
            this.Thresholds.Text = "Thresholds";
            // 
            // s4temperature
            // 
            this.s4temperature.AutoSize = true;
            this.s4temperature.Location = new System.Drawing.Point(306, 89);
            this.s4temperature.Name = "s4temperature";
            this.s4temperature.Size = new System.Drawing.Size(49, 13);
            this.s4temperature.TabIndex = 22;
            this.s4temperature.Text = "Sensor 4";
            // 
            // s3temperature
            // 
            this.s3temperature.AutoSize = true;
            this.s3temperature.Location = new System.Drawing.Point(222, 89);
            this.s3temperature.Name = "s3temperature";
            this.s3temperature.Size = new System.Drawing.Size(49, 13);
            this.s3temperature.TabIndex = 21;
            this.s3temperature.Text = "Sensor 3";
            // 
            // s2temperature
            // 
            this.s2temperature.AutoSize = true;
            this.s2temperature.Location = new System.Drawing.Point(139, 89);
            this.s2temperature.Name = "s2temperature";
            this.s2temperature.Size = new System.Drawing.Size(49, 13);
            this.s2temperature.TabIndex = 20;
            this.s2temperature.Text = "Sensor 2";
            // 
            // s1temperature
            // 
            this.s1temperature.AutoSize = true;
            this.s1temperature.Location = new System.Drawing.Point(55, 89);
            this.s1temperature.Name = "s1temperature";
            this.s1temperature.Size = new System.Drawing.Size(49, 13);
            this.s1temperature.TabIndex = 19;
            this.s1temperature.Text = "Sensor 1";
            // 
            // sensor4
            // 
            this.sensor4.AutoSize = true;
            this.sensor4.Location = new System.Drawing.Point(309, 14);
            this.sensor4.Name = "sensor4";
            this.sensor4.Size = new System.Drawing.Size(68, 17);
            this.sensor4.TabIndex = 18;
            this.sensor4.Text = "Sensor 4";
            this.sensor4.UseVisualStyleBackColor = true;
            // 
            // sensor2
            // 
            this.sensor2.AutoSize = true;
            this.sensor2.Location = new System.Drawing.Point(142, 14);
            this.sensor2.Name = "sensor2";
            this.sensor2.Size = new System.Drawing.Size(68, 17);
            this.sensor2.TabIndex = 18;
            this.sensor2.Text = "Sensor 2";
            this.sensor2.UseVisualStyleBackColor = true;
            // 
            // sensor3
            // 
            this.sensor3.AutoSize = true;
            this.sensor3.Location = new System.Drawing.Point(225, 14);
            this.sensor3.Name = "sensor3";
            this.sensor3.Size = new System.Drawing.Size(68, 17);
            this.sensor3.TabIndex = 17;
            this.sensor3.Text = "Sensor 3";
            this.sensor3.UseVisualStyleBackColor = true;
            // 
            // sensor4minthres
            // 
            this.sensor4minthres.Location = new System.Drawing.Point(309, 63);
            this.sensor4minthres.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.sensor4minthres.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.sensor4minthres.Name = "sensor4minthres";
            this.sensor4minthres.Size = new System.Drawing.Size(63, 20);
            this.sensor4minthres.TabIndex = 12;
            // 
            // sensor1
            // 
            this.sensor1.AutoSize = true;
            this.sensor1.Location = new System.Drawing.Point(58, 14);
            this.sensor1.Name = "sensor1";
            this.sensor1.Size = new System.Drawing.Size(68, 17);
            this.sensor1.TabIndex = 17;
            this.sensor1.Text = "Sensor 1";
            this.sensor1.UseVisualStyleBackColor = true;
            // 
            // sensor4maxthres
            // 
            this.sensor4maxthres.Location = new System.Drawing.Point(309, 37);
            this.sensor4maxthres.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.sensor4maxthres.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.sensor4maxthres.Name = "sensor4maxthres";
            this.sensor4maxthres.Size = new System.Drawing.Size(63, 20);
            this.sensor4maxthres.TabIndex = 11;
            // 
            // sensor3minthres
            // 
            this.sensor3minthres.Location = new System.Drawing.Point(225, 63);
            this.sensor3minthres.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.sensor3minthres.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.sensor3minthres.Name = "sensor3minthres";
            this.sensor3minthres.Size = new System.Drawing.Size(62, 20);
            this.sensor3minthres.TabIndex = 9;
            // 
            // sensor3maxthres
            // 
            this.sensor3maxthres.Location = new System.Drawing.Point(225, 37);
            this.sensor3maxthres.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.sensor3maxthres.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.sensor3maxthres.Name = "sensor3maxthres";
            this.sensor3maxthres.Size = new System.Drawing.Size(62, 20);
            this.sensor3maxthres.TabIndex = 8;
            // 
            // sensor2minthres
            // 
            this.sensor2minthres.Location = new System.Drawing.Point(142, 63);
            this.sensor2minthres.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.sensor2minthres.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.sensor2minthres.Name = "sensor2minthres";
            this.sensor2minthres.Size = new System.Drawing.Size(58, 20);
            this.sensor2minthres.TabIndex = 6;
            // 
            // sensor2maxthres
            // 
            this.sensor2maxthres.Location = new System.Drawing.Point(142, 37);
            this.sensor2maxthres.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.sensor2maxthres.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.sensor2maxthres.Name = "sensor2maxthres";
            this.sensor2maxthres.Size = new System.Drawing.Size(58, 20);
            this.sensor2maxthres.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max limit";
            // 
            // sensor1minthres
            // 
            this.sensor1minthres.Location = new System.Drawing.Point(58, 63);
            this.sensor1minthres.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.sensor1minthres.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.sensor1minthres.Name = "sensor1minthres";
            this.sensor1minthres.Size = new System.Drawing.Size(60, 20);
            this.sensor1minthres.TabIndex = 1;
            // 
            // sensor1maxthres
            // 
            this.sensor1maxthres.Location = new System.Drawing.Point(58, 37);
            this.sensor1maxthres.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.sensor1maxthres.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.sensor1maxthres.Name = "sensor1maxthres";
            this.sensor1maxthres.Size = new System.Drawing.Size(60, 20);
            this.sensor1maxthres.TabIndex = 0;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(13, 13);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 10D;
            this.zedGraphControl1.ScrollMaxX = 5000D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(620, 372);
            this.zedGraphControl1.TabIndex = 17;
            // 
            // scrollbar_tracker_CB
            // 
            this.scrollbar_tracker_CB.AutoSize = true;
            this.scrollbar_tracker_CB.Checked = true;
            this.scrollbar_tracker_CB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scrollbar_tracker_CB.Location = new System.Drawing.Point(13, 485);
            this.scrollbar_tracker_CB.Name = "scrollbar_tracker_CB";
            this.scrollbar_tracker_CB.Size = new System.Drawing.Size(160, 17);
            this.scrollbar_tracker_CB.TabIndex = 18;
            this.scrollbar_tracker_CB.Text = "Keep track of current values";
            this.scrollbar_tracker_CB.UseVisualStyleBackColor = true;
            this.scrollbar_tracker_CB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // realtimecharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 526);
            this.Controls.Add(this.scrollbar_tracker_CB);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.Thresholds);
            this.Controls.Add(this.t4cb);
            this.Controls.Add(this.t2cb);
            this.Controls.Add(this.t1cb);
            this.Controls.Add(this.t3cb);
            this.Controls.Add(this.Sensors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "realtimecharts";
            this.Text = "Realtime visualisation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.realtimecharts_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.realtimecharts_FormClosed);
            this.Load += new System.EventHandler(this.realtimecharts_Load);
            this.Thresholds.ResumeLayout(false);
            this.Thresholds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensor4minthres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor4maxthres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor3minthres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor3maxthres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor2minthres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor2maxthres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor1minthres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor1maxthres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox t4cb;
        private System.Windows.Forms.CheckBox t2cb;
        private System.Windows.Forms.CheckBox t1cb;
        private System.Windows.Forms.CheckBox t3cb;
        private System.Windows.Forms.GroupBox Sensors;
        private System.Windows.Forms.GroupBox Thresholds;
        private System.Windows.Forms.CheckBox sensor4;
        private System.Windows.Forms.CheckBox sensor2;
        private System.Windows.Forms.CheckBox sensor3;
        private System.Windows.Forms.NumericUpDown sensor4minthres;
        private System.Windows.Forms.CheckBox sensor1;
        private System.Windows.Forms.NumericUpDown sensor4maxthres;
        private System.Windows.Forms.NumericUpDown sensor3minthres;
        private System.Windows.Forms.NumericUpDown sensor3maxthres;
        private System.Windows.Forms.NumericUpDown sensor2minthres;
        private System.Windows.Forms.NumericUpDown sensor2maxthres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sensor1minthres;
        private System.Windows.Forms.NumericUpDown sensor1maxthres;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.CheckBox scrollbar_tracker_CB;
        private System.Windows.Forms.Label s1temperature;
        private System.Windows.Forms.Label s4temperature;
        private System.Windows.Forms.Label s3temperature;
        private System.Windows.Forms.Label s2temperature;
        public System.Windows.Forms.Timer logger;
    }
}