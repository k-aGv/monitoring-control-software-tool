namespace Elaiotriveio
{
    partial class port
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(port));
            this.label1 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.refreshcom = new System.Windows.Forms.Button();
            this.lbconfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnok
            // 
            this.btnok.Enabled = false;
            this.btnok.Location = new System.Drawing.Point(12, 13);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "button1";
            this.btnok.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(12, 42);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "button1";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(158, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(57, 13);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // refreshcom
            // 
            this.refreshcom.Location = new System.Drawing.Point(12, 71);
            this.refreshcom.Name = "refreshcom";
            this.refreshcom.Size = new System.Drawing.Size(75, 42);
            this.refreshcom.TabIndex = 4;
            this.refreshcom.Text = "button1";
            this.refreshcom.UseVisualStyleBackColor = true;
            this.refreshcom.Click += new System.EventHandler(this.refreshcom_Click);
            // 
            // lbconfirm
            // 
            this.lbconfirm.AutoSize = true;
            this.lbconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbconfirm.ForeColor = System.Drawing.Color.Green;
            this.lbconfirm.Location = new System.Drawing.Point(90, 18);
            this.lbconfirm.Name = "lbconfirm";
            this.lbconfirm.Size = new System.Drawing.Size(53, 13);
            this.lbconfirm.TabIndex = 5;
            this.lbconfirm.Text = "<- confirm";
            this.lbconfirm.Visible = false;
            // 
            // port
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 160);
            this.Controls.Add(this.lbconfirm);
            this.Controls.Add(this.refreshcom);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "port";
            this.Text = "Serial port selection";
            this.Load += new System.EventHandler(this.port_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button refreshcom;
        private System.Windows.Forms.Label lbconfirm;

    }
}