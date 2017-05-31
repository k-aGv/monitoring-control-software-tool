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
        int i;
        int active_sensors_counter = 0;

        int[] values_from_file = new int[4];

        string filename = "";
        string filename1 = "";
        string filename2 = "";
        string filename3 = "";
        string filename4 = "";

        string[] sensors_comments = new string[4];
        string[] comments = new string[4];

        bool[] sensors1_cb_status = new bool[4];
        bool[] sensors2_cb_status = new bool[4];
        bool[] sensors3_cb_status = new bool[4];
        bool[] sensors4_cb_status = new bool[4];


        public void commentsreader(string filename)
        {
            i = 0;
            //stream for comments
            XmlReader comments_reader = XmlReader.Create(filename);
            while (comments_reader.Read())
            {
                switch (comments_reader.NodeType)
                {
                    case XmlNodeType.Comment:
                        comments[i] = comments_reader.Value.ToString();
                        i++;
                        break;
                }
            }
            comments_reader.Close();
        }
        public void sensorsparser()
        {
            active_sensors_counter = 0;
            if (comments[3].Contains("Sensor1: ON"))
            {
                active_sensors_counter++;
                sensors_comments[0] = "Active";
            }
            else if (comments[3].Contains("Sensor1: OFF"))
            {
                sensors_comments[0] = "Inactive";
            }
            if (comments[3].Contains("Sensor2: ON"))
            {
                active_sensors_counter++;
                sensors_comments[1] = "Active";
            }
            else if (comments[3].Contains("Sensor2: OFF"))
            {
                sensors_comments[1] = "Inactive";
            }
            if (comments[3].Contains("Sensor3: ON"))
            {
                active_sensors_counter++;
                sensors_comments[2] = "Active";
            }
            else if (comments[3].Contains("Sensor3: OFF"))
            {
                sensors_comments[2] = "Inactive";
            }
            if (comments[3].Contains("Sensor4: ON"))
            {
                active_sensors_counter++;
                sensors_comments[3] = "Active";
            }
            else if (comments[3].Contains("Sensor4: OFF"))
            {
                sensors_comments[3] = "Inactive";
            }
        }
        public string openfile()
        {
            openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                return filename;
            }
            else
            {
                return "";
            }
        }


        public void openfile1()
        {
            filename1 = openfile();
            if (filename1 != "")
            {
                commentsreader(filename1);
                sensorsparser();
                date1_label.Text = "Logs Date: " + comments[0];
                time1_label.Text = "Logs Time: " + comments[1];
                sampling1_label.Text = "Sampling time: " + comments[2];
                sensors1_label.Text = "Sensors: " + active_sensors_counter;

                logs1_information_GB.Visible = true;
                available_sensors_GB1.Visible = true;

                show_file1_bt.Visible = true;

                compare_sensor1_bt.Visible = true;
                compare_sensor2_bt.Visible = true;
                compare_sensor3_bt.Visible = true;
                compare_sensor4_bt.Visible = true;

                if (sensors_comments[0] == "Active")
                    sensor1cb_file1.Enabled = true;
                else
                {
                    sensor1cb_file1.Enabled = false;
                    sensor1cb_file1.Checked = false;
                }

                if (sensors_comments[1] == "Active")
                    sensor2cb_file1.Enabled = true;
                else
                {
                    sensor2cb_file1.Enabled = false;
                    sensor2cb_file1.Checked = false;
                }

                if (sensors_comments[2] == "Active")
                    sensor3cb_file1.Enabled = true;
                else
                {
                    sensor3cb_file1.Enabled = false;
                    sensor3cb_file1.Checked = false;
                }

                if (sensors_comments[3] == "Active")
                    sensor4cb_file1.Enabled = true;
                else
                {
                    sensor4cb_file1.Enabled = false;
                    sensor4cb_file1.Checked = false;
                }
            }
            else
            {
            }
        }
        public void openfile2()
        {
            filename2 = openfile();
            if (filename2 != "")
            {
                commentsreader(filename2);
                sensorsparser();
                date2_label.Text = "Logs Date: " + comments[0];
                time2_label.Text = "Logs Time: " + comments[1];
                sampling2_label.Text = "Sampling time: " + comments[2];
                sensors2_label.Text = "Sensors: " + active_sensors_counter;

                logs2_information_GB.Visible = true;
                available_sensors_GB2.Visible = true;

                show_file2_bt.Visible = true;

                compare_sensor1_bt.Visible = true;
                compare_sensor2_bt.Visible = true;
                compare_sensor3_bt.Visible = true;
                compare_sensor4_bt.Visible = true;

                if (sensors_comments[0] == "Active")
                    sensor1cb_file2.Enabled = true;
                else
                {
                    sensor1cb_file2.Enabled = false;
                    sensor1cb_file2.Checked = false;
                }

                if (sensors_comments[1] == "Active")
                    sensor2cb_file2.Enabled = true;
                else
                {
                    sensor2cb_file2.Enabled = false;
                    sensor2cb_file2.Checked = false;
                }

                if (sensors_comments[2] == "Active")
                    sensor3cb_file2.Enabled = true;
                else
                {
                    sensor3cb_file2.Enabled = false;
                    sensor3cb_file2.Checked = false;
                }

                if (sensors_comments[3] == "Active")
                    sensor4cb_file2.Enabled = true;
                else
                {
                    sensor4cb_file2.Enabled = false;
                    sensor4cb_file2.Checked = false;
                }
            }
            else
            {
            }
        }
        public void openfile3()
        {
            filename3 = openfile();
            if (filename3 != "")
            {
                commentsreader(filename3);
                sensorsparser();
                date3_label.Text = "Logs Date: " + comments[0];
                time3_label.Text = "Logs Time: " + comments[1];
                sampling3_label.Text = "Sampling time: " + comments[2];
                sensors3_label.Text = "Sensors: " + active_sensors_counter;

                logs3_information_GB.Visible = true;
                available_sensors_GB3.Visible = true;

                show_file3_bt.Visible = true;

                compare_sensor1_bt.Visible = true;
                compare_sensor2_bt.Visible = true;
                compare_sensor3_bt.Visible = true;
                compare_sensor4_bt.Visible = true;

                if (sensors_comments[0] == "Active")
                    sensor1cb_file3.Enabled = true;
                else
                {
                    sensor1cb_file3.Enabled = false;
                    sensor1cb_file3.Checked = false;
                }

                if (sensors_comments[1] == "Active")
                    sensor2cb_file3.Enabled = true;
                else
                {
                    sensor2cb_file3.Enabled = false;
                    sensor2cb_file3.Checked = false;
                }

                if (sensors_comments[2] == "Active")
                    sensor3cb_file3.Enabled = true;
                else
                {
                    sensor3cb_file3.Enabled = false;
                    sensor3cb_file3.Checked = false;
                }

                if (sensors_comments[3] == "Active")
                    sensor4cb_file3.Enabled = true;
                else
                {
                    sensor4cb_file3.Enabled = false;
                    sensor4cb_file3.Checked = false;
                }
            }
            else
            {
            }
        }
        public void openfile4()
        {
            filename4 = openfile();
            if (filename4 != "")
            {
                commentsreader(filename4);
                sensorsparser();
                date4_label.Text = "Logs Date: " + comments[0];
                time4_label.Text = "Logs Time: " + comments[1];
                sampling4_label.Text = "Sampling time: " + comments[2];
                sensors4_label.Text = "Sensors: " + active_sensors_counter;

                logs4_information_GB.Visible = true;
                available_sensors_GB4.Visible = true;

                show_file4_bt.Visible = true;

                compare_sensor1_bt.Visible = true;
                compare_sensor2_bt.Visible = true;
                compare_sensor3_bt.Visible = true;
                compare_sensor4_bt.Visible = true;

                if (sensors_comments[0] == "Active")
                    sensor1cb_file4.Enabled = true;
                else
                {
                    sensor1cb_file4.Enabled = false;
                    sensor1cb_file4.Checked = false;
                }

                if (sensors_comments[1] == "Active")
                    sensor2cb_file4.Enabled = true;
                else
                {
                    sensor2cb_file4.Enabled = false;
                    sensor2cb_file4.Checked = false;
                }

                if (sensors_comments[2] == "Active")
                    sensor3cb_file4.Enabled = true;
                else
                {
                    sensor3cb_file4.Enabled = false;
                    sensor3cb_file4.Checked = false;
                }

                if (sensors_comments[3] == "Active")
                    sensor4cb_file4.Enabled = true;
                else
                {
                    sensor4cb_file4.Enabled = false;
                    sensor4cb_file4.Checked = false;
                }
            }
            else
            {
            }
        }

        public void showfile1()
        {
            if (sensor1cb_file1.Checked)
                sensors1_cb_status[0] = true;
            else
                sensors1_cb_status[0] = false;

            if (sensor2cb_file1.Checked)
                sensors1_cb_status[1] = true;
            else
                sensors1_cb_status[1] = false;

            if (sensor3cb_file1.Checked)
                sensors1_cb_status[2] = true;
            else
                sensors1_cb_status[2] = false;

            if (sensor4cb_file1.Checked)
                sensors1_cb_status[3] = true;
            else
                sensors1_cb_status[3] = false;

            saved_logs_display _form = new saved_logs_display();
            _form.transfer_data(1, sensors1_cb_status, filename1, -1);

            _form.charts_display(-1);

            _form.Show();
        }
        public void showfile2()
        {
            if (sensor1cb_file2.Checked)
                sensors2_cb_status[0] = true;
            else
                sensors2_cb_status[0] = false;

            if (sensor2cb_file2.Checked)
                sensors2_cb_status[1] = true;
            else
                sensors2_cb_status[1] = false;

            if (sensor3cb_file2.Checked)
                sensors2_cb_status[2] = true;
            else
                sensors2_cb_status[2] = false;

            if (sensor4cb_file2.Checked)
                sensors2_cb_status[3] = true;
            else
                sensors2_cb_status[3] = false;

            saved_logs_display _form = new saved_logs_display();
            _form.transfer_data(2, sensors2_cb_status, filename2, -1);
            _form.charts_display(-1);

            _form.Show();
        }
        public void showfile3()
        {
            if (sensor1cb_file3.Checked)
                sensors3_cb_status[0] = true;
            else
                sensors3_cb_status[0] = false;

            if (sensor2cb_file3.Checked)
                sensors3_cb_status[1] = true;
            else
                sensors3_cb_status[1] = false;

            if (sensor3cb_file3.Checked)
                sensors3_cb_status[2] = true;
            else
                sensors3_cb_status[2] = false;

            if (sensor4cb_file3.Checked)
                sensors3_cb_status[3] = true;
            else
                sensors3_cb_status[3] = false;

            saved_logs_display _form = new saved_logs_display();
            _form.transfer_data(3, sensors3_cb_status, filename3, -1);
            _form.charts_display(-1);

            _form.Show();
        }
        public void showfile4()
        {
            if (sensor1cb_file4.Checked)
                sensors4_cb_status[0] = true;
            else
                sensors4_cb_status[0] = false;

            if (sensor2cb_file4.Checked)
                sensors4_cb_status[1] = true;
            else
                sensors4_cb_status[1] = false;

            if (sensor3cb_file4.Checked)
                sensors4_cb_status[2] = true;
            else
                sensors4_cb_status[2] = false;

            if (sensor4cb_file4.Checked)
                sensors4_cb_status[3] = true;
            else
                sensors4_cb_status[3] = false;

            saved_logs_display _form = new saved_logs_display();
            _form.transfer_data(4, sensors4_cb_status, filename4, -1);
            _form.charts_display(-1);

            _form.Show();
        }

        public void comparesensor1()
        {
            saved_logs_display _form = new saved_logs_display();

            if (sensor1cb_file1.Checked)
                sensors1_cb_status[0] = true;
            else
                sensors1_cb_status[0] = false;

            if (sensor1cb_file2.Checked)
                sensors2_cb_status[0] = true;
            else
                sensors2_cb_status[0] = false;

            if (sensor1cb_file3.Checked)
                sensors3_cb_status[0] = true;
            else
                sensors3_cb_status[0] = false;

            if (sensor1cb_file4.Checked)
                sensors4_cb_status[0] = true;
            else
                sensors4_cb_status[0] = false;

            if (sensors1_cb_status[0])
            {
                _form.transfer_data(21, sensors1_cb_status, filename1, 1);
                _form.charts_display(1);
            }
            if (sensors2_cb_status[0])
            {
                _form.transfer_data(21, sensors2_cb_status, filename2, 2);
                _form.charts_display(2);
            }
            if (sensors3_cb_status[0])
            {
                _form.transfer_data(21, sensors3_cb_status, filename3, 3);
                _form.charts_display(3);
            }
            if (sensors4_cb_status[0])
            {
                _form.transfer_data(21, sensors4_cb_status, filename4, 4);
                _form.charts_display(4);
            }

            _form.Show();
            _form.Width += 30;
            _form.logs_LB.Width += 30;
        }
        public void comparesensor2()
        {
            saved_logs_display _form = new saved_logs_display();

            if (sensor2cb_file1.Checked)
                sensors1_cb_status[1] = true;
            else
                sensors1_cb_status[1] = false;

            if (sensor2cb_file2.Checked)
                sensors2_cb_status[1] = true;
            else
                sensors2_cb_status[1] = false;

            if (sensor2cb_file3.Checked)
                sensors3_cb_status[1] = true;
            else
                sensors3_cb_status[1] = false;

            if (sensor2cb_file4.Checked)
                sensors4_cb_status[1] = true;
            else
                sensors4_cb_status[1] = false;

            if (sensors1_cb_status[1])
            {
                _form.transfer_data(22, sensors1_cb_status, filename1, 1);
                _form.charts_display(1);
            }
            if (sensors2_cb_status[1])
            {
                _form.transfer_data(22, sensors2_cb_status, filename2, 2);
                _form.charts_display(2);
            }
            if (sensors3_cb_status[1])
            {
                _form.transfer_data(22, sensors3_cb_status, filename3, 3);
                _form.charts_display(3);
            }
            if (sensors4_cb_status[1])
            {
                _form.transfer_data(22, sensors4_cb_status, filename4, 4);
                _form.charts_display(4);
            }

            _form.Show();
            _form.Width += 30;
            _form.logs_LB.Width += 30;
        }
        public void comparesensor3()
        {
            saved_logs_display _form = new saved_logs_display();

            if (sensor3cb_file1.Checked)
                sensors1_cb_status[2] = true;
            else
                sensors1_cb_status[2] = false;

            if (sensor3cb_file2.Checked)
                sensors2_cb_status[2] = true;
            else
                sensors2_cb_status[2] = false;

            if (sensor3cb_file3.Checked)
                sensors3_cb_status[2] = true;
            else
                sensors3_cb_status[2] = false;

            if (sensor3cb_file4.Checked)
                sensors4_cb_status[2] = true;
            else
                sensors4_cb_status[2] = false;

            if (sensors1_cb_status[2])
            {
                _form.transfer_data(23, sensors1_cb_status, filename1, 1);
                _form.charts_display(1);
            }
            if (sensors2_cb_status[2])
            {
                _form.transfer_data(23, sensors2_cb_status, filename2, 2);
                _form.charts_display(2);
            }
            if (sensors3_cb_status[2])
            {
                _form.transfer_data(23, sensors3_cb_status, filename3, 3);
                _form.charts_display(3);
            }
            if (sensors4_cb_status[2])
            {
                _form.transfer_data(23, sensors4_cb_status, filename4, 4);
                _form.charts_display(4);
            }

            _form.Show();
            _form.Width += 30;
            _form.logs_LB.Width += 30;
        }
        public void comparesensor4()
        {
            saved_logs_display _form = new saved_logs_display();

            if (sensor4cb_file1.Checked)
                sensors1_cb_status[3] = true;
            else
                sensors1_cb_status[3] = false;

            if (sensor4cb_file2.Checked)
                sensors2_cb_status[3] = true;
            else
                sensors2_cb_status[3] = false;

            if (sensor4cb_file3.Checked)
                sensors3_cb_status[3] = true;
            else
                sensors3_cb_status[3] = false;

            if (sensor4cb_file4.Checked)
                sensors4_cb_status[3] = true;
            else
                sensors4_cb_status[3] = false;

            if (sensors1_cb_status[3])
            {
                _form.transfer_data(24, sensors1_cb_status, filename1, 1);
                _form.charts_display(1);
            }
            if (sensors2_cb_status[3])
            {
                _form.transfer_data(24, sensors2_cb_status, filename2, 2);
                _form.charts_display(2);
            }
            if (sensors3_cb_status[3])
            {
                _form.transfer_data(24, sensors3_cb_status, filename3, 3);
                _form.charts_display(3);
            }
            if (sensors4_cb_status[3])
            {
                _form.transfer_data(24, sensors4_cb_status, filename4, 4);
                _form.charts_display(4);
            }

            _form.Show();
            _form.Width += 30;
            _form.logs_LB.Width += 30;
        }
    }
}
