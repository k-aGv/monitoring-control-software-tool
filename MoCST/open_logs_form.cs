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
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Elaiotriveio
{
    public partial class open_logs_form : Form
    {
        public open_logs_form()
        {
            InitializeComponent();
        }

        
        private void openfile1button_Click(object sender, EventArgs e)
        {
            openfile1();
        }

        private void openfilebutton2_Click(object sender, EventArgs e)
        {
            openfile2();
        }

        private void openfilebutton3_Click(object sender, EventArgs e)
        {
            openfile3();
        }

        private void openfilebutton4_Click(object sender, EventArgs e)
        {
            openfile4();
        }

        private void show_file1_bt_Click(object sender, EventArgs e)
        {
            showfile1();
        }

        private void show_file2_bt_Click(object sender, EventArgs e)
        {
            showfile2();
        }

        private void show_file3_bt_Click(object sender, EventArgs e)
        {
            showfile3();
        }

        private void show_file4_bt_Click(object sender, EventArgs e)
        {
            showfile4();
        }

        private void compare_sensor1_bt_Click(object sender, EventArgs e)
        {
            comparesensor1();
        }

        private void compare_sensor2_bt_Click(object sender, EventArgs e)
        {
            comparesensor2();
        }

        private void compare_sensor3_bt_Click(object sender, EventArgs e)
        {
            comparesensor3();
        }

        private void compare_sensor4_bt_Click(object sender, EventArgs e)
        {
            comparesensor4();
        }

        // File 1 //
        private void sensor1cb_file1_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file1.Checked || sensor2cb_file2.Checked || sensor3cb_file1.Checked || sensor4cb_file1.Checked)
                show_file1_bt.Enabled = true;
            else
                show_file1_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor1cb_file1.Checked || sensor1cb_file2.Checked || sensor1cb_file3.Checked || sensor1cb_file4.Checked)
                compare_sensor1_bt.Enabled = true;
            else
                compare_sensor1_bt.Enabled = false;
        }

        private void sensor2cb_file1_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file1.Checked || sensor2cb_file1.Checked || sensor3cb_file1.Checked || sensor4cb_file1.Checked)
                show_file1_bt.Enabled = true;
            else
                show_file1_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor2cb_file1.Checked || sensor2cb_file2.Checked || sensor2cb_file3.Checked || sensor2cb_file4.Checked)
                compare_sensor2_bt.Enabled = true;
            else
                compare_sensor2_bt.Enabled = false;
        }

        private void sensor3cb_file1_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file1.Checked || sensor2cb_file2.Checked || sensor3cb_file1.Checked || sensor4cb_file1.Checked)
                show_file1_bt.Enabled = true;
            else
                show_file1_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor3cb_file1.Checked || sensor3cb_file2.Checked || sensor3cb_file3.Checked || sensor3cb_file4.Checked)
                compare_sensor3_bt.Enabled = true;
            else
                compare_sensor3_bt.Enabled = false;
        }

        private void sensor4cb_file1_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file1.Checked || sensor2cb_file2.Checked || sensor3cb_file1.Checked || sensor4cb_file1.Checked)
                show_file1_bt.Enabled = true;
            else
                show_file1_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor4cb_file1.Checked || sensor4cb_file2.Checked || sensor4cb_file3.Checked || sensor4cb_file4.Checked)
                compare_sensor4_bt.Enabled = true;
            else
                compare_sensor4_bt.Enabled = false;
        }

        // File 2 //
        private void sensor1cb_file2_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file2.Checked || sensor2cb_file2.Checked || sensor3cb_file2.Checked || sensor4cb_file2.Checked)
                show_file2_bt.Enabled = true;
            else
                show_file2_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor1cb_file1.Checked || sensor1cb_file2.Checked || sensor1cb_file3.Checked || sensor1cb_file4.Checked)
                compare_sensor1_bt.Enabled = true;
            else
                compare_sensor1_bt.Enabled = false;
        }

        private void sensor2cb_file2_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file2.Checked || sensor2cb_file2.Checked || sensor3cb_file2.Checked || sensor4cb_file2.Checked)
                show_file2_bt.Enabled = true;
            else
                show_file2_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor2cb_file1.Checked || sensor2cb_file2.Checked || sensor2cb_file3.Checked || sensor2cb_file4.Checked)
                compare_sensor2_bt.Enabled = true;
            else
                compare_sensor2_bt.Enabled = false;
        }

        private void sensor3cb_file2_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file2.Checked || sensor2cb_file2.Checked || sensor3cb_file2.Checked || sensor4cb_file2.Checked)
                show_file2_bt.Enabled = true;
            else
                show_file2_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor3cb_file1.Checked || sensor3cb_file2.Checked || sensor3cb_file3.Checked || sensor3cb_file4.Checked)
                compare_sensor3_bt.Enabled = true;
            else
                compare_sensor3_bt.Enabled = false;
        }

        private void sensor4cb_file2_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file2.Checked || sensor2cb_file2.Checked || sensor3cb_file2.Checked || sensor4cb_file2.Checked)
            {
                show_file2_bt.Enabled = true;
            }
            else
                show_file2_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor4cb_file1.Checked || sensor4cb_file2.Checked || sensor4cb_file3.Checked || sensor4cb_file4.Checked)
                compare_sensor4_bt.Enabled = true;
            else
                compare_sensor4_bt.Enabled = false;
        }

        // File 3 //
        private void sensor1cb_file3_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file3.Checked || sensor2cb_file3.Checked || sensor3cb_file3.Checked || sensor4cb_file3.Checked)
                show_file3_bt.Enabled = true;
            else
                show_file3_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor1cb_file1.Checked || sensor1cb_file2.Checked || sensor1cb_file3.Checked || sensor1cb_file4.Checked)
                compare_sensor1_bt.Enabled = true;
            else
                compare_sensor1_bt.Enabled = false;
        }

        private void sensor2cb_file3_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file3.Checked || sensor2cb_file3.Checked || sensor3cb_file3.Checked || sensor4cb_file3.Checked)
                show_file3_bt.Enabled = true;
            else
                show_file3_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor2cb_file1.Checked || sensor2cb_file2.Checked || sensor2cb_file3.Checked || sensor2cb_file4.Checked)
                compare_sensor2_bt.Enabled = true;
            else
                compare_sensor2_bt.Enabled = false;
        }

        private void sensor3cb_file3_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file3.Checked || sensor2cb_file3.Checked || sensor3cb_file3.Checked || sensor4cb_file3.Checked)
                show_file3_bt.Enabled = true;
            else
                show_file3_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor3cb_file1.Checked || sensor3cb_file2.Checked || sensor3cb_file3.Checked || sensor3cb_file4.Checked)
                compare_sensor3_bt.Enabled = true;
            else
                compare_sensor3_bt.Enabled = false;
        }

        private void sensor4cb_file3_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file3.Checked || sensor2cb_file3.Checked || sensor3cb_file3.Checked || sensor4cb_file3.Checked)
                show_file3_bt.Enabled = true;
            else
                show_file3_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor4cb_file1.Checked || sensor4cb_file2.Checked || sensor4cb_file3.Checked || sensor4cb_file4.Checked)
                compare_sensor4_bt.Enabled = true;
            else
                compare_sensor4_bt.Enabled = false;
        }

        // File 4 //
        private void sensor1cb_file4_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file4.Checked || sensor2cb_file4.Checked || sensor3cb_file4.Checked || sensor4cb_file4.Checked)
                show_file4_bt.Enabled = true;
            else
                show_file4_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor1cb_file1.Checked || sensor1cb_file2.Checked || sensor1cb_file3.Checked || sensor1cb_file4.Checked)
                compare_sensor1_bt.Enabled = true;
            else
                compare_sensor1_bt.Enabled = false;
        }

        private void sensor2cb_file4_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file4.Checked || sensor2cb_file4.Checked || sensor3cb_file4.Checked || sensor4cb_file4.Checked)
                show_file4_bt.Enabled = true;
            else
                show_file4_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor2cb_file1.Checked || sensor2cb_file2.Checked || sensor2cb_file3.Checked || sensor2cb_file4.Checked)
                compare_sensor2_bt.Enabled = true;
            else
                compare_sensor2_bt.Enabled = false;
        }

        private void sensor3cb_file4_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file4.Checked || sensor2cb_file4.Checked || sensor3cb_file4.Checked || sensor4cb_file4.Checked)
                show_file4_bt.Enabled = true;
            else
                show_file4_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor3cb_file1.Checked || sensor3cb_file2.Checked || sensor3cb_file3.Checked || sensor3cb_file4.Checked)
                compare_sensor3_bt.Enabled = true;
            else
                compare_sensor3_bt.Enabled = false;
        }

        private void sensor4cb_file4_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1cb_file4.Checked || sensor2cb_file4.Checked || sensor3cb_file4.Checked || sensor4cb_file4.Checked)
                show_file4_bt.Enabled = true;
            else
                show_file4_bt.Enabled = false;
            ///////////////////////////////////////////////////////
            if (sensor4cb_file1.Checked || sensor4cb_file2.Checked || sensor4cb_file3.Checked || sensor4cb_file4.Checked)
                compare_sensor4_bt.Enabled = true;
            else
                compare_sensor4_bt.Enabled = false;
        }

    }
}
