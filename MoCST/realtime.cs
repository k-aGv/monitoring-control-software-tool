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
using System.Text.RegularExpressions;

using ZedGraph;

namespace Elaiotriveio
{
    public partial class realtime : Form
    {
        public realtime()
        {
            InitializeComponent();
        }

        private void realtime_Load(object sender, EventArgs e)
        {

            

            z = zedGraphControl1.GraphPane;
            z.XAxis.Scale.MinorStep = 1;
            z.XAxis.Scale.Max = 5; //values range on X axis
            //z.YAxis.Scale.Max = 100; //values range on Y axis
            z.YAxis.Scale.MaxAuto = true;
            z.YAxis.Scale.MinAuto = true;

            z.XAxis.MajorGrid.DashOff = 0;
            z.YAxis.MajorGrid.DashOff = 0;

            z.XAxis.MajorGrid.Color = Color.DarkSlateGray;
            z.XAxis.MinorGrid.IsVisible = true;
            z.XAxis.MinorGrid.Color = Color.Gray;
            z.XAxis.MajorGrid.IsVisible = true;

            z.YAxis.MajorGrid.Color = Color.DarkSlateGray;
            z.YAxis.MajorGrid.IsVisible = true;
            z.YAxis.MinorGrid.Color = Color.Gray;
            z.YAxis.MinorGrid.IsVisible = true;

            z.XAxis.IsAxisSegmentVisible = false;
            z.XAxis.IsVisible = false;

            z.Title.Text = "Realtime Values";
            z.XAxis.Title.Text = "Sensors";
            z.YAxis.Title.Text = "Temperature";
            
            drawNextSpot_curve(1);

            if (!cb[0])
                bar0.Label.IsVisible = false;
            if (!cb[1])
                bar1.Label.IsVisible = false;
            if (!cb[2])
                bar2.Label.IsVisible = false;
            if (!cb[3])
                bar3.Label.IsVisible = false;
            
                //drawNextSpot_curve(1);

            z.AxisChange();
            zedGraphControl1.IsAntiAlias = true;
            /*
            if (_running)
            {
                realtime_timer.Start();
            }
            */
        }

        private void realtime_timer_Tick(object sender, EventArgs e)
        {
            if (values[0] > z.YAxis.Scale.Max ||
                values[1] > z.YAxis.Scale.Max ||
                values[2] > z.YAxis.Scale.Max ||
                values[3] > z.YAxis.Scale.Max ||
                
                values[0]<z.YAxis.Scale.Min ||
                values[1]<z.YAxis.Scale.Min ||
                values[2]<z.YAxis.Scale.Min ||
                values[3]<z.YAxis.Scale.Min)
            {
                z.AxisChange(); //adjusts Yaxis
            }
            if (cb[0])
            {
                if (sensor1CB.Checked)
                {
                    if (values[0] > Convert.ToDouble(sensor1maxthres.Value))
                        sensor1maxthres.BackColor = Color.Red;
                    else
                        sensor1maxthres.BackColor = Color.White;

                    if (values[0] < Convert.ToDouble(sensor1minthres.Value))
                        sensor1minthres.BackColor = Color.Red;
                    else
                        sensor1minthres.BackColor = Color.White;
                }
                else
                {
                    sensor1maxthres.BackColor = Color.White;
                    sensor1minthres.BackColor = Color.White;
                }
                if (!init_Curves)
                {
                    bar0.Clear();
                    bar0.Label.IsVisible = true;
                }
                drawNextSpot_curve(0);
                s1temperature.Text = "Sensor 1: " + values[0] + "°C";
            }
            else
            {
                    bar0.Clear();
                    bar0.Label.IsVisible = false;
            }


            if (cb[1])
            {
                if (sensor2CB.Checked)
                {
                    if (values[1] > Convert.ToDouble(sensor2maxthres.Value))
                        sensor2maxthres.BackColor = Color.Red;
                    else
                        sensor2maxthres.BackColor = Color.White;

                    if (values[1] < Convert.ToDouble(sensor2minthres.Value))
                        sensor2minthres.BackColor = Color.Red;
                    else
                        sensor2minthres.BackColor = Color.White;
                }
                else
                {
                    sensor2maxthres.BackColor = Color.White;
                    sensor2minthres.BackColor = Color.White;
                }
                if (!init_Curves)
                {
                    bar1.Clear();
                    bar1.Label.IsVisible = true;
                }
                drawNextSpot_curve(1);
                s2temperature.Text = "Sensor 2: " + values[1] + "°C";
            }
            else
            {
                bar1.Clear();
                bar1.Label.IsVisible = false;
            }


            if (cb[2])
            {
                if (sensor3CB.Checked)
                {
                    if (values[2] > Convert.ToDouble(sensor3maxthres.Value))
                        sensor3maxthres.BackColor = Color.Red;
                    else
                        sensor3maxthres.BackColor = Color.White;

                    if (values[2] < Convert.ToDouble(sensor3minthres.Value))
                        sensor3minthres.BackColor = Color.Red;
                    else
                        sensor3minthres.BackColor = Color.White;
                }
                else
                {
                    sensor3maxthres.BackColor = Color.White;
                    sensor3minthres.BackColor = Color.White;
                }
                if (!init_Curves)
                {
                    bar2.Clear();
                    bar2.Label.IsVisible = true;
                }
                drawNextSpot_curve(2);
                s3temperature.Text = "Sensor 3: " + values[2] + "°C";
            }
            else
            {
                bar2.Clear();
                bar2.Label.IsVisible = false;
            }


            if (cb[3])
            {
                if (sensor4CB.Checked)
                {
                    if (values[3] > Convert.ToDouble(sensor4maxthres.Value))
                        sensor4maxthres.BackColor = Color.Red;
                    else
                        sensor4maxthres.BackColor = Color.White;

                    if (values[3] < Convert.ToDouble(sensor4minthres.Value))
                        sensor4minthres.BackColor = Color.Red;
                    else
                        sensor4minthres.BackColor = Color.White;
                }
                else
                {
                    sensor4maxthres.BackColor = Color.White;
                    sensor4minthres.BackColor = Color.White;
                }


                if (!init_Curves)
                {
                    bar3.Clear();
                    bar3.Label.IsVisible = true;
                }
                drawNextSpot_curve(3);
                s4temperature.Text = "Sensor 4: " + values[3] + "°C";
            }
            else
            {
                bar3.Clear();
                bar3.Label.IsVisible = false;
            }


            if (realtime_timer.Enabled)
            {
                if (cb[0])
                    sensor1thresholds.Enabled = true;
                else
                {
                    sensor1thresholds.Enabled = false;
                    sensor1maxthres.BackColor = Color.White;
                    sensor1minthres.BackColor = Color.White;
                    sensor1CB.Checked = false;

                    s1temperature.Text = "Sensor 1: N/A";
                }
                if (cb[1])
                    sensor2thresholds.Enabled = true;
                else
                {
                    sensor2thresholds.Enabled = false;
                    sensor2maxthres.BackColor = Color.White;
                    sensor2minthres.BackColor = Color.White;
                    sensor2CB.Checked = false;

                    s2temperature.Text = "Sensor 2: N/A";
                }
                if (cb[2])
                    sensor3thresholds.Enabled = true;
                else
                {
                    sensor3thresholds.Enabled = false;
                    sensor3maxthres.BackColor = Color.White;
                    sensor3minthres.BackColor = Color.White;
                    sensor3CB.Checked = false;

                    s3temperature.Text = "Sensor 3: N/A";
                }
                if (cb[3])
                    sensor4thresholds.Enabled = true;
                else
                {
                    sensor4thresholds.Enabled = false;
                    sensor4maxthres.BackColor = Color.White;
                    sensor4minthres.BackColor = Color.White;
                    sensor4CB.Checked = false;

                    s4temperature.Text = "Sensor 4: N/A";
                }
            }
        }

        private void realtime_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void sensor1CB_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor1CB.Checked)
                sensor1CB.Text = "Disable";
            else
                sensor1CB.Text = "Enable";
        }

        private void sensor2CB_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor2CB.Checked)
                sensor2CB.Text = "Disable";
            else
                sensor2CB.Text = "Enable";
        }

        private void sensor3CB_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor3CB.Checked)
                sensor3CB.Text = "Disable";
            else
                sensor3CB.Text = "Enable";
        }

        private void sensor4CB_CheckedChanged(object sender, EventArgs e)
        {
            if (sensor4CB.Checked)
                sensor4CB.Text = "Disable";
            else
                sensor4CB.Text = "Enable";
        }
    }
}
