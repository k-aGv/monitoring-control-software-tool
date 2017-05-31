namespace Elaiotriveio
{
    partial class realtime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(realtime));
            this.realtime_timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.sensor3minlabel = new System.Windows.Forms.Label();
            this.sensor3maxlabel = new System.Windows.Forms.Label();
            this.sensor3minthres = new System.Windows.Forms.NumericUpDown();
            this.sensor3maxthres = new System.Windows.Forms.NumericUpDown();
            this.sensor4minlabel = new System.Windows.Forms.Label();
            this.sensor4maxlabel = new System.Windows.Forms.Label();
            this.sensor4minthres = new System.Windows.Forms.NumericUpDown();
            this.sensor4maxthres = new System.Windows.Forms.NumericUpDown();
            this.sensor3thresholds = new System.Windows.Forms.GroupBox();
            this.s3temperature = new System.Windows.Forms.Label();
            this.sensor3CB = new System.Windows.Forms.CheckBox();
            this.sensor4thresholds = new System.Windows.Forms.GroupBox();
            this.s4temperature = new System.Windows.Forms.Label();
            this.sensor4CB = new System.Windows.Forms.CheckBox();
            this.sensor1thresholds = new System.Windows.Forms.GroupBox();
            this.sensor1CB = new System.Windows.Forms.CheckBox();
            this.sensor1maxlabel = new System.Windows.Forms.Label();
            this.sensor1maxthres = new System.Windows.Forms.NumericUpDown();
            this.s1temperature = new System.Windows.Forms.Label();
            this.sensor1minlabel = new System.Windows.Forms.Label();
            this.sensor1minthres = new System.Windows.Forms.NumericUpDown();
            this.sensor2thresholds = new System.Windows.Forms.GroupBox();
            this.s2temperature = new System.Windows.Forms.Label();
            this.sensor2CB = new System.Windows.Forms.CheckBox();
            this.sensor2maxlabel = new System.Windows.Forms.Label();
            this.sensor2maxthres = new System.Windows.Forms.NumericUpDown();
            this.sensor2minlabel = new System.Windows.Forms.Label();
            this.sensor2minthres = new System.Windows.Forms.NumericUpDown();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.sensor3minthres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor3maxthres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor4minthres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor4maxthres)).BeginInit();
            this.sensor3thresholds.SuspendLayout();
            this.sensor4thresholds.SuspendLayout();
            this.sensor1thresholds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensor1maxthres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor1minthres)).BeginInit();
            this.sensor2thresholds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensor2maxthres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor2minthres)).BeginInit();
            this.SuspendLayout();
            // 
            // realtime_timer
            // 
            this.realtime_timer.Tick += new System.EventHandler(this.realtime_timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // sensor3minlabel
            // 
            this.sensor3minlabel.AutoSize = true;
            this.sensor3minlabel.BackColor = System.Drawing.SystemColors.Control;
            this.sensor3minlabel.Location = new System.Drawing.Point(6, 85);
            this.sensor3minlabel.Name = "sensor3minlabel";
            this.sensor3minlabel.Size = new System.Drawing.Size(44, 13);
            this.sensor3minlabel.TabIndex = 20;
            this.sensor3minlabel.Text = "Min limit";
            // 
            // sensor3maxlabel
            // 
            this.sensor3maxlabel.AutoSize = true;
            this.sensor3maxlabel.BackColor = System.Drawing.SystemColors.Control;
            this.sensor3maxlabel.Location = new System.Drawing.Point(6, 59);
            this.sensor3maxlabel.Name = "sensor3maxlabel";
            this.sensor3maxlabel.Size = new System.Drawing.Size(47, 13);
            this.sensor3maxlabel.TabIndex = 19;
            this.sensor3maxlabel.Text = "Max limit";
            // 
            // sensor3minthres
            // 
            this.sensor3minthres.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sensor3minthres.Location = new System.Drawing.Point(54, 83);
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
            this.sensor3minthres.Size = new System.Drawing.Size(39, 20);
            this.sensor3minthres.TabIndex = 18;
            // 
            // sensor3maxthres
            // 
            this.sensor3maxthres.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sensor3maxthres.Location = new System.Drawing.Point(54, 57);
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
            this.sensor3maxthres.Size = new System.Drawing.Size(39, 20);
            this.sensor3maxthres.TabIndex = 17;
            // 
            // sensor4minlabel
            // 
            this.sensor4minlabel.AutoSize = true;
            this.sensor4minlabel.BackColor = System.Drawing.SystemColors.Control;
            this.sensor4minlabel.Location = new System.Drawing.Point(6, 85);
            this.sensor4minlabel.Name = "sensor4minlabel";
            this.sensor4minlabel.Size = new System.Drawing.Size(44, 13);
            this.sensor4minlabel.TabIndex = 24;
            this.sensor4minlabel.Text = "Min limit";
            // 
            // sensor4maxlabel
            // 
            this.sensor4maxlabel.AutoSize = true;
            this.sensor4maxlabel.BackColor = System.Drawing.SystemColors.Control;
            this.sensor4maxlabel.Location = new System.Drawing.Point(6, 59);
            this.sensor4maxlabel.Name = "sensor4maxlabel";
            this.sensor4maxlabel.Size = new System.Drawing.Size(47, 13);
            this.sensor4maxlabel.TabIndex = 23;
            this.sensor4maxlabel.Text = "Max limit";
            // 
            // sensor4minthres
            // 
            this.sensor4minthres.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sensor4minthres.Location = new System.Drawing.Point(54, 83);
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
            this.sensor4minthres.Size = new System.Drawing.Size(39, 20);
            this.sensor4minthres.TabIndex = 22;
            // 
            // sensor4maxthres
            // 
            this.sensor4maxthres.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sensor4maxthres.Location = new System.Drawing.Point(54, 57);
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
            this.sensor4maxthres.Size = new System.Drawing.Size(39, 20);
            this.sensor4maxthres.TabIndex = 21;
            // 
            // sensor3thresholds
            // 
            this.sensor3thresholds.BackColor = System.Drawing.SystemColors.Control;
            this.sensor3thresholds.Controls.Add(this.s3temperature);
            this.sensor3thresholds.Controls.Add(this.sensor3CB);
            this.sensor3thresholds.Controls.Add(this.sensor3maxlabel);
            this.sensor3thresholds.Controls.Add(this.sensor3maxthres);
            this.sensor3thresholds.Controls.Add(this.sensor3minthres);
            this.sensor3thresholds.Controls.Add(this.sensor3minlabel);
            this.sensor3thresholds.Enabled = false;
            this.sensor3thresholds.Location = new System.Drawing.Point(368, 346);
            this.sensor3thresholds.Name = "sensor3thresholds";
            this.sensor3thresholds.Size = new System.Drawing.Size(99, 135);
            this.sensor3thresholds.TabIndex = 25;
            this.sensor3thresholds.TabStop = false;
            this.sensor3thresholds.Text = "Sensor 3 Thresholds";
            // 
            // s3temperature
            // 
            this.s3temperature.AutoSize = true;
            this.s3temperature.Location = new System.Drawing.Point(2, 111);
            this.s3temperature.Name = "s3temperature";
            this.s3temperature.Size = new System.Drawing.Size(49, 13);
            this.s3temperature.TabIndex = 32;
            this.s3temperature.Text = "Sensor 3";
            // 
            // sensor3CB
            // 
            this.sensor3CB.AutoSize = true;
            this.sensor3CB.Location = new System.Drawing.Point(9, 34);
            this.sensor3CB.Name = "sensor3CB";
            this.sensor3CB.Size = new System.Drawing.Size(59, 17);
            this.sensor3CB.TabIndex = 26;
            this.sensor3CB.Text = "Enable";
            this.sensor3CB.UseVisualStyleBackColor = true;
            this.sensor3CB.CheckedChanged += new System.EventHandler(this.sensor3CB_CheckedChanged);
            // 
            // sensor4thresholds
            // 
            this.sensor4thresholds.BackColor = System.Drawing.SystemColors.Control;
            this.sensor4thresholds.Controls.Add(this.s4temperature);
            this.sensor4thresholds.Controls.Add(this.sensor4CB);
            this.sensor4thresholds.Controls.Add(this.sensor4maxlabel);
            this.sensor4thresholds.Controls.Add(this.sensor4maxthres);
            this.sensor4thresholds.Controls.Add(this.sensor4minlabel);
            this.sensor4thresholds.Controls.Add(this.sensor4minthres);
            this.sensor4thresholds.Enabled = false;
            this.sensor4thresholds.Location = new System.Drawing.Point(502, 347);
            this.sensor4thresholds.Name = "sensor4thresholds";
            this.sensor4thresholds.Size = new System.Drawing.Size(99, 135);
            this.sensor4thresholds.TabIndex = 26;
            this.sensor4thresholds.TabStop = false;
            this.sensor4thresholds.Text = "Sensor 4 Thresholds";
            // 
            // s4temperature
            // 
            this.s4temperature.AutoSize = true;
            this.s4temperature.Location = new System.Drawing.Point(2, 111);
            this.s4temperature.Name = "s4temperature";
            this.s4temperature.Size = new System.Drawing.Size(49, 13);
            this.s4temperature.TabIndex = 33;
            this.s4temperature.Text = "Sensor 4";
            // 
            // sensor4CB
            // 
            this.sensor4CB.AutoSize = true;
            this.sensor4CB.Location = new System.Drawing.Point(9, 34);
            this.sensor4CB.Name = "sensor4CB";
            this.sensor4CB.Size = new System.Drawing.Size(59, 17);
            this.sensor4CB.TabIndex = 27;
            this.sensor4CB.Text = "Enable";
            this.sensor4CB.UseVisualStyleBackColor = true;
            this.sensor4CB.CheckedChanged += new System.EventHandler(this.sensor4CB_CheckedChanged);
            // 
            // sensor1thresholds
            // 
            this.sensor1thresholds.BackColor = System.Drawing.SystemColors.Control;
            this.sensor1thresholds.Controls.Add(this.sensor1CB);
            this.sensor1thresholds.Controls.Add(this.sensor1maxlabel);
            this.sensor1thresholds.Controls.Add(this.sensor1maxthres);
            this.sensor1thresholds.Controls.Add(this.s1temperature);
            this.sensor1thresholds.Controls.Add(this.sensor1minlabel);
            this.sensor1thresholds.Controls.Add(this.sensor1minthres);
            this.sensor1thresholds.Enabled = false;
            this.sensor1thresholds.Location = new System.Drawing.Point(96, 346);
            this.sensor1thresholds.Name = "sensor1thresholds";
            this.sensor1thresholds.Size = new System.Drawing.Size(99, 135);
            this.sensor1thresholds.TabIndex = 27;
            this.sensor1thresholds.TabStop = false;
            this.sensor1thresholds.Text = "Sensor 1 Thresholds";
            // 
            // sensor1CB
            // 
            this.sensor1CB.AutoSize = true;
            this.sensor1CB.Location = new System.Drawing.Point(9, 34);
            this.sensor1CB.Name = "sensor1CB";
            this.sensor1CB.Size = new System.Drawing.Size(59, 17);
            this.sensor1CB.TabIndex = 25;
            this.sensor1CB.Text = "Enable";
            this.sensor1CB.UseVisualStyleBackColor = true;
            this.sensor1CB.CheckedChanged += new System.EventHandler(this.sensor1CB_CheckedChanged);
            // 
            // sensor1maxlabel
            // 
            this.sensor1maxlabel.AutoSize = true;
            this.sensor1maxlabel.BackColor = System.Drawing.SystemColors.Control;
            this.sensor1maxlabel.Location = new System.Drawing.Point(6, 59);
            this.sensor1maxlabel.Name = "sensor1maxlabel";
            this.sensor1maxlabel.Size = new System.Drawing.Size(47, 13);
            this.sensor1maxlabel.TabIndex = 23;
            this.sensor1maxlabel.Text = "Max limit";
            // 
            // sensor1maxthres
            // 
            this.sensor1maxthres.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sensor1maxthres.Location = new System.Drawing.Point(54, 57);
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
            this.sensor1maxthres.Size = new System.Drawing.Size(39, 20);
            this.sensor1maxthres.TabIndex = 21;
            // 
            // s1temperature
            // 
            this.s1temperature.AutoSize = true;
            this.s1temperature.Location = new System.Drawing.Point(2, 111);
            this.s1temperature.Name = "s1temperature";
            this.s1temperature.Size = new System.Drawing.Size(49, 13);
            this.s1temperature.TabIndex = 30;
            this.s1temperature.Text = "Sensor 1";
            // 
            // sensor1minlabel
            // 
            this.sensor1minlabel.AutoSize = true;
            this.sensor1minlabel.BackColor = System.Drawing.SystemColors.Control;
            this.sensor1minlabel.Location = new System.Drawing.Point(6, 85);
            this.sensor1minlabel.Name = "sensor1minlabel";
            this.sensor1minlabel.Size = new System.Drawing.Size(44, 13);
            this.sensor1minlabel.TabIndex = 24;
            this.sensor1minlabel.Text = "Min limit";
            // 
            // sensor1minthres
            // 
            this.sensor1minthres.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sensor1minthres.Location = new System.Drawing.Point(54, 83);
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
            this.sensor1minthres.Size = new System.Drawing.Size(39, 20);
            this.sensor1minthres.TabIndex = 22;
            // 
            // sensor2thresholds
            // 
            this.sensor2thresholds.BackColor = System.Drawing.SystemColors.Control;
            this.sensor2thresholds.Controls.Add(this.s2temperature);
            this.sensor2thresholds.Controls.Add(this.sensor2CB);
            this.sensor2thresholds.Controls.Add(this.sensor2maxlabel);
            this.sensor2thresholds.Controls.Add(this.sensor2maxthres);
            this.sensor2thresholds.Controls.Add(this.sensor2minlabel);
            this.sensor2thresholds.Controls.Add(this.sensor2minthres);
            this.sensor2thresholds.Enabled = false;
            this.sensor2thresholds.Location = new System.Drawing.Point(232, 346);
            this.sensor2thresholds.Name = "sensor2thresholds";
            this.sensor2thresholds.Size = new System.Drawing.Size(99, 135);
            this.sensor2thresholds.TabIndex = 28;
            this.sensor2thresholds.TabStop = false;
            this.sensor2thresholds.Text = "Sensor 2 Thresholds";
            // 
            // s2temperature
            // 
            this.s2temperature.AutoSize = true;
            this.s2temperature.Location = new System.Drawing.Point(2, 111);
            this.s2temperature.Name = "s2temperature";
            this.s2temperature.Size = new System.Drawing.Size(49, 13);
            this.s2temperature.TabIndex = 31;
            this.s2temperature.Text = "Sensor 2";
            // 
            // sensor2CB
            // 
            this.sensor2CB.AutoSize = true;
            this.sensor2CB.Location = new System.Drawing.Point(9, 34);
            this.sensor2CB.Name = "sensor2CB";
            this.sensor2CB.Size = new System.Drawing.Size(59, 17);
            this.sensor2CB.TabIndex = 26;
            this.sensor2CB.Text = "Enable";
            this.sensor2CB.UseVisualStyleBackColor = true;
            this.sensor2CB.CheckedChanged += new System.EventHandler(this.sensor2CB_CheckedChanged);
            // 
            // sensor2maxlabel
            // 
            this.sensor2maxlabel.AutoSize = true;
            this.sensor2maxlabel.BackColor = System.Drawing.SystemColors.Control;
            this.sensor2maxlabel.Location = new System.Drawing.Point(6, 59);
            this.sensor2maxlabel.Name = "sensor2maxlabel";
            this.sensor2maxlabel.Size = new System.Drawing.Size(47, 13);
            this.sensor2maxlabel.TabIndex = 23;
            this.sensor2maxlabel.Text = "Max limit";
            // 
            // sensor2maxthres
            // 
            this.sensor2maxthres.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sensor2maxthres.Location = new System.Drawing.Point(54, 57);
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
            this.sensor2maxthres.Size = new System.Drawing.Size(39, 20);
            this.sensor2maxthres.TabIndex = 21;
            // 
            // sensor2minlabel
            // 
            this.sensor2minlabel.AutoSize = true;
            this.sensor2minlabel.BackColor = System.Drawing.SystemColors.Control;
            this.sensor2minlabel.Location = new System.Drawing.Point(6, 85);
            this.sensor2minlabel.Name = "sensor2minlabel";
            this.sensor2minlabel.Size = new System.Drawing.Size(44, 13);
            this.sensor2minlabel.TabIndex = 24;
            this.sensor2minlabel.Text = "Min limit";
            // 
            // sensor2minthres
            // 
            this.sensor2minthres.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sensor2minthres.Location = new System.Drawing.Point(54, 83);
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
            this.sensor2minthres.Size = new System.Drawing.Size(39, 20);
            this.sensor2minthres.TabIndex = 22;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 10D;
            this.zedGraphControl1.ScrollMaxX = 5000D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(619, 328);
            this.zedGraphControl1.TabIndex = 29;
            // 
            // realtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 488);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.sensor2thresholds);
            this.Controls.Add(this.sensor1thresholds);
            this.Controls.Add(this.sensor4thresholds);
            this.Controls.Add(this.sensor3thresholds);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "realtime";
            this.Text = "Realtime monitoring";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.realtime_FormClosing);
            this.Load += new System.EventHandler(this.realtime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sensor3minthres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor3maxthres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor4minthres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor4maxthres)).EndInit();
            this.sensor3thresholds.ResumeLayout(false);
            this.sensor3thresholds.PerformLayout();
            this.sensor4thresholds.ResumeLayout(false);
            this.sensor4thresholds.PerformLayout();
            this.sensor1thresholds.ResumeLayout(false);
            this.sensor1thresholds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensor1maxthres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor1minthres)).EndInit();
            this.sensor2thresholds.ResumeLayout(false);
            this.sensor2thresholds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensor2maxthres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor2minthres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sensor3minlabel;
        private System.Windows.Forms.Label sensor3maxlabel;
        private System.Windows.Forms.NumericUpDown sensor3minthres;
        private System.Windows.Forms.NumericUpDown sensor3maxthres;
        private System.Windows.Forms.Label sensor4minlabel;
        private System.Windows.Forms.Label sensor4maxlabel;
        private System.Windows.Forms.NumericUpDown sensor4minthres;
        private System.Windows.Forms.NumericUpDown sensor4maxthres;
        private System.Windows.Forms.GroupBox sensor3thresholds;
        private System.Windows.Forms.GroupBox sensor4thresholds;
        private System.Windows.Forms.GroupBox sensor1thresholds;
        private System.Windows.Forms.Label sensor1maxlabel;
        private System.Windows.Forms.NumericUpDown sensor1maxthres;
        private System.Windows.Forms.Label sensor1minlabel;
        private System.Windows.Forms.NumericUpDown sensor1minthres;
        private System.Windows.Forms.GroupBox sensor2thresholds;
        private System.Windows.Forms.Label sensor2maxlabel;
        private System.Windows.Forms.NumericUpDown sensor2maxthres;
        private System.Windows.Forms.Label sensor2minlabel;
        private System.Windows.Forms.NumericUpDown sensor2minthres;
        private System.Windows.Forms.CheckBox sensor3CB;
        private System.Windows.Forms.CheckBox sensor4CB;
        private System.Windows.Forms.CheckBox sensor1CB;
        private System.Windows.Forms.CheckBox sensor2CB;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label s4temperature;
        private System.Windows.Forms.Label s3temperature;
        private System.Windows.Forms.Label s2temperature;
        private System.Windows.Forms.Label s1temperature;
        public System.Windows.Forms.Timer realtime_timer;


    }
}