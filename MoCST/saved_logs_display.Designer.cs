namespace Elaiotriveio
{
    partial class saved_logs_display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saved_logs_display));
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.logs_LB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 10D;
            this.zedGraphControl1.ScrollMaxX = 86000D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(792, 488);
            this.zedGraphControl1.TabIndex = 18;
            this.zedGraphControl1.PointValueEvent += new ZedGraph.ZedGraphControl.PointValueHandler(this.zedGraphControl1_PointValueEvent);
            // 
            // logs_LB
            // 
            this.logs_LB.FormattingEnabled = true;
            this.logs_LB.HorizontalScrollbar = true;
            this.logs_LB.Location = new System.Drawing.Point(811, 26);
            this.logs_LB.Name = "logs_LB";
            this.logs_LB.Size = new System.Drawing.Size(355, 472);
            this.logs_LB.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(965, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Logs";
            // 
            // search_timer
            // 
            this.search_timer.Interval = 50;
            // 
            // saved_logs_display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logs_LB);
            this.Controls.Add(this.zedGraphControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "saved_logs_display";
            this.Text = "Values history graph";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.saved_logs_display_FormClosing);
            this.Load += new System.EventHandler(this.saved_logs_display_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer search_timer;
        public System.Windows.Forms.ListBox logs_LB;


    }
}