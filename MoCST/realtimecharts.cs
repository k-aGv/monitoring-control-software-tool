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

using ZedGraph;
namespace Elaiotriveio
{
    public partial class realtimecharts : Form
    {
        public realtimecharts()
        {
            InitializeComponent();
        }
        

        

        
     
        
        
        private void logger_Tick(object sender, EventArgs e)
        {
            z.AxisChange();

            displayCharts();
        }

        private void realtimecharts_FormClosed(object sender, FormClosedEventArgs e)
        {
            init_Curves = true;
            logger.Stop();
        }

        private void realtimecharts_FormClosing(object sender, FormClosingEventArgs e)
        {
            //logger.Stop();
            t1cbBOOL = false;
            t2cbBOOL = false;
            t3cbBOOL = false;
            t4cbBOOL = false;


            this.Hide();
            e.Cancel = true;
            //scrollbar_tracker_CB.Checked = false;
        }

        private void t1cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb[0])
            {
                if (!t1cb.Checked)
                {
                    curve0.Label.IsVisible = false;
                    curve0.Color = Color.Transparent;

                    sensor1.Enabled = false;
                    sensor1maxthres.Enabled = false;
                    sensor1minthres.Enabled = false;

                }
                else
                {
                    curve0.Label.IsVisible = true;
                    curve0.Color = Color.Green;

                    sensor1.Enabled = true;
                    sensor1maxthres.Enabled = true;
                    sensor1minthres.Enabled = true;
                }
            }
            t1cbBOOL = true;
            
        }

        private void t2cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb[1])
            {
                if (!t2cb.Checked)
                {
                    curve1.Label.IsVisible = false;
                    curve1.Color = Color.Transparent;

                    sensor2.Enabled = false;
                    sensor2maxthres.Enabled = false;
                    sensor2minthres.Enabled = false;
                }
                else
                {
                    curve1.Label.IsVisible = true;
                    curve1.Color = Color.Red;

                    sensor2.Enabled = true;
                    sensor2maxthres.Enabled = true;
                    sensor2minthres.Enabled = true;
                }
            }
            t2cbBOOL = true;
        }

        private void t3cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb[2])
            {
                if (!t3cb.Checked)
                {
                    curve2.Label.IsVisible = false;
                    curve2.Color = Color.Transparent;

                    sensor3.Enabled = false;
                    sensor3maxthres.Enabled = false;
                    sensor3minthres.Enabled = false;
                }
                else
                {
                    curve2.Label.IsVisible = true;
                    curve2.Color = Color.Black;

                    sensor3.Enabled = true;
                    sensor3maxthres.Enabled = true;
                    sensor3minthres.Enabled = true;
                }
            }
            t3cbBOOL = true;
        }

        private void t4cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb[3])
            {
                if (!t4cb.Checked)
                {
                    curve3.Label.IsVisible = false;
                    curve3.Color = Color.Transparent;

                    sensor4.Enabled = false;
                    sensor4maxthres.Enabled = false;
                    sensor4minthres.Enabled = false;
                }
                else
                {
                    curve3.Label.IsVisible = true;
                    curve3.Color = Color.Blue;

                    sensor4.Enabled = true;
                    sensor4maxthres.Enabled = true;
                    sensor4minthres.Enabled = true;
                }
            }
            t4cbBOOL = true;
        }
    
        private void realtimecharts_Load(object sender, EventArgs e)
        {
            //to interval tou logger kathorizetai apo ti main Form
            //mesw tou trackbar

            

            scrolltrack = true;

            
            z = zedGraphControl1.GraphPane;
            z.XAxis.Scale.MinorStep = 1;
            
            z.XAxis.Scale.Max = 20; //euros timwn ston X
            //z.YAxis.Scale.Max = 100; //euros timwn ston Y
            z.YAxis.Scale.MaxAuto = true;
            z.YAxis.Scale.MinAuto = true;
            
            
            zedGraphControl1.ScrollMaxX = 21;

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

            z.XAxis.Title.Text = "Samples";
            z.YAxis.Title.Text = "Temperature";
            z.Title.Text = "Realtime monitoring";
            
            

            z.AxisChange();
            zedGraphControl1.IsAntiAlias = true;
            zedGraphControl1.Refresh();
            
            
            /*
            if (_running)
            {
                logger.Start();
            }
            */

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (scrollbar_tracker_CB.Checked)
            {
                //zedGraphControl1.Controls[0].Focus();
                //SendKeys.Send("{RIGHT}");
                scroll_handler = true;
            }
            else
                scroll_handler = false;
        }
    }
}
