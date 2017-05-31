using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Elaiotriveio
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }
        //System.Diagnostics.Process.Start("https://www.autom.teithe.gr/gr/");
        string _loc=Directory.GetCurrentDirectory()+"/resources/logo.png";

        private void about_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(_loc);
        }

        private void aboutLinklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.autom.teithe.gr/gr/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.food.teithe.gr/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.autom.teithe.gr/gr/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.autom.teithe.gr/gr/");
        }
    }
}
