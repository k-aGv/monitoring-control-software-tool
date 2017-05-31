/*!
Apache License
Version 2.0, January 2004

Copyright (c) 2017 Giannis Menexes <johnmenex@hotmail.com>, Dimitris Katikaridis <dkatikaridis@gmail.com>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;
namespace Elaiotriveio
{
    public partial class port : Form
    {

        public port()
        {
            InitializeComponent();
        }

        public string getPort()
        {
            return Convert.ToString(btnok.Text);
        }

        private void port_Load(object sender, EventArgs e)
        {
            //isPluggedIn.Start();
            //isPluggedOut.Start();
            label1.Text = "COM Ports:";
            btnok.Text = "OK";
            btncancel.Text = "Cancel";
            refreshcom.Text = "Refresh ports";
            btnok.DialogResult = DialogResult.OK;
            btncancel.DialogResult = DialogResult.Cancel;



            

        }
        
        private void cbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
            //listBox1.DropDownStyle = ComboBoxStyle.DropDownList; 
        }
      
        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() != ""
                || listBox1.SelectedItem.ToString() != " "
                || listBox1.SelectedItem.ToString() != null)
            {
                btnok.Enabled = true;
                btnok.Text = listBox1.SelectedItem.ToString();
                lbconfirm.Visible = true;
            }
            else
            {
                MessageBox.Show("An error was encountered.\r\nPlease try again.");
            }
        }

        private void refreshcom_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (SerialPort.GetPortNames().Length == 0)
            {
                listBox1.Items.Clear();
                btnok.Text = "OK";
                btnok.Enabled = false;
                lbconfirm.Visible = false;
                return;
            }
            else
            {
                listBox1.Items.Clear();
                foreach (string port in SerialPort.GetPortNames())
                {
                    listBox1.Items.Add(port.ToString());
                }
            }
            listBox1.Height = (15 * (listBox1.Items.Count));
        }
    }
}
