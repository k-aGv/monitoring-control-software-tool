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

using System.IO.Ports;
using Excel = Microsoft.Office.Interop.Excel;

namespace Elaiotriveio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ScheduledMonitorCB_CheckedChanged(object sender, EventArgs e)
        {
            if (!ScheduledMonitorCB.Checked)
            {
                this.Height -= 100;
                groupBox1.Visible = false;
                datelabel.Visible = false;
                hourlabel.Visible = false;
                minutelabel.Visible = false;
                scheduledstop.Visible = false;
                scheduledstart.Visible = false;
                startdate.Visible = false;
                enddate.Visible = false;
                starthour.Visible = false;
                startminute.Visible = false;
                endminute.Visible = false;
                endhour.Visible = false;
            }
            else
            {
                this.Height += 100;

                groupBox1.Visible = true;
                datelabel.Visible = true;
                hourlabel.Visible = true;
                minutelabel.Visible = true;
                scheduledstop.Visible = true;
                scheduledstart.Visible = true;
                startdate.Visible = true;
                enddate.Visible = true;
                starthour.Visible = true;
                startminute.Visible = true;
                endminute.Visible = true;
                endhour.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * checks for COM devices that are connected to PC
            string[] p =SerialPort.GetPortNames();
            foreach (string port in p)
            {
                MessageBox.Show(port);
            }
            */
            if (File.Exists(dir + "\\convertedXML.xlsx"))
                File.Delete(dir + "\\convertedXML.xlsx");
            if (File.Exists(dir + "\\convertedXML.txt"))
                File.Delete(dir + "\\convertedXML.txt");
            if (File.Exists(dir + "\\_temp.xml"))
                File.Delete(dir + "\\_temp.xml");
           
            triggerLeds();
            enableToolStripMenuItem.Enabled = false;
            enableToolStripMenuItem1.Enabled = false;
            disableToolStripMenuItem.Enabled = false;
            disableToolStripMenuItem1.Enabled = false;
            
            enableToolStripMenuItem.Checked = false;
            disableToolStripMenuItem.Checked = true;
            enableToolStripMenuItem1.Checked = false;
            disableToolStripMenuItem1.Checked = true;
            
            trackBar1.Value = 1;
            logger.Interval = trackBar1.Value*500;
            arduino_sampler.Interval = logger.Interval;
            lbSamplingTime.Text = arduino_sampler.Interval.ToString()+" ms" ;

            selectedportlabel.Text = "";
            

            if (!ScheduledMonitorCB.Checked)
                this.Height -= 100;
            else
                this.Height += 100;

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void logger_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 1)
            {
                running = true;
                _f2.running_state(running);
            }
            
            

            if (i > 86399) //a day's seconds
            {
                arduino_sampler.Stop();
                logger.Stop();
                savefile("xml");
            }
            else
                if (!File.Exists(dir + "\\_temp.xml"))
                {
                    settings.Indent = true;
                    XmlWriter writer = XmlWriter.Create(dir + "\\_temp.xml", settings);
                    if (!started)
                    {
                        writer.WriteStartDocument();
                        writer.WriteComment(DateTime.Now.Day.ToString()
                                     +"/"+DateTime.Now.Month.ToString()
                                     +"/"+DateTime.Now.Year.ToString()); //date in log file

                        writer.WriteComment(time_format()); //time in log file

                        writer.WriteComment((logger.Interval+0.0)/1000+" s"); //sampling time in log file

                        writer.WriteComment("Sensor1: " + sensors_status_var[0]
                                      + " /  Sensor2: " + sensors_status_var[1]
                                      + " /  Sensor3: " + sensors_status_var[2]
                                      + " /  Sensor4: " + sensors_status_var[3]); //sensors' status in log file
                        

                        writer.WriteStartElement("Values");
                        writer.Close();

                        started = true;
                    }

                }
                else
                {}
        }

        private void start_Click(object sender, EventArgs e)
        {
            Start();
        }
  
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!logger.Enabled)
            {
                if (curdate == pickeddate && curtime == pickedtime)
                {
                    logger.Start();
                    arduino_sampler.Start();
                    timer3.Start();
                    monitor_started = true;
                    realTimeGraphMonitoringToolStripMenuItem.Enabled = true;
                    realtimevaluesToolStripMenuItem.Enabled = true;
                    timer2.Stop();
                }
                else
                {
                    curdate = DateTime.Now.Day.ToString()
                    + "/" + DateTime.Now.Month.ToString()
                    + "/" + DateTime.Now.Year.ToString();

                    if (DateTime.Now.Hour < 10)
                        curhour = "0";
                    else
                        curhour = "";

                    if (DateTime.Now.Minute < 10)
                        curminute = "0";
                    else
                        curminute = "";

                    curtime = curhour + DateTime.Now.Hour.ToString()
                        + ":" + curminute + DateTime.Now.Minute.ToString();
                }
            }
        
        }

        private void timer3_Tick(object sender, EventArgs e) //programmed monitoring timer
        {
            if (pickeddatestop == curdate && pickedtimestop == curtime)
            {
                time_reached();
                charts.Hide();
                _f2.Hide();
                savefile("xml");

                realTimeGraphMonitoringToolStripMenuItem.Enabled = false;
                realtimevaluesToolStripMenuItem.Enabled = false;
                charts.Hide(); //new additions
                _f2.Hide(); //new additions
            }
            else
            {
                if (DateTime.Now.Hour < 10)
                    curhour = "0";
                else
                    curhour = "";

                if (DateTime.Now.Minute < 10)
                    curminute = "0";
                else
                    curminute = "";

                curtime = curhour + DateTime.Now.Hour.ToString()
                    + ":" + curminute + DateTime.Now.Minute.ToString();

                curdate = DateTime.Now.Day.ToString()
                            + "/" + DateTime.Now.Month.ToString()
                            + "/" + DateTime.Now.Year.ToString();

                if (endhour.Value < 10)
                    pickedhourstop = "0";
                else
                    pickedhourstop = "";

                if (endminute.Value < 10)
                    pickedminutestop = "0";
                else
                    pickedminutestop = "";

                pickedtimestop = pickedhourstop + endhour.Value.ToString()
                    + ":" + pickedminutestop + endminute.Value.ToString();

                pickeddatestop = enddate.Value.Day.ToString()
                            + "/" + enddate.Value.Month.ToString()
                            + "/" + enddate.Value.Year.ToString();
            }
        }

        private void realTimeGraphMonitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartscreated = true;
            charts.getCBstate(cb_state);
            charts.logger.Start();
            charts.Show();
        }

        private void realtimevaluesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _f2created = true;
            sensors_status(cb_state);
            _f2.realtime_timer.Start();
            _f2.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            savefile("xml");
        }
        
        private void openLogsFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_logs_form savedlogs = new open_logs_form();
            savedlogs.Show();
        }

        private void is_busy_check_timer_Tick(object sender, EventArgs e)
        {
            if (!logger.Enabled)
            {
                realTimeGraphMonitoringToolStripMenuItem.Enabled = false;
                realtimevaluesToolStripMenuItem.Enabled = false;
            }
            else
            {
                realTimeGraphMonitoringToolStripMenuItem.Enabled = true;
                realtimevaluesToolStripMenuItem.Enabled = true;

                enableToolStripMenuItem.Enabled = false;
                disableToolStripMenuItem.Enabled = false;
                enableToolStripMenuItem1.Enabled = false;
                disableToolStripMenuItem1.Enabled = false;

                trackBar1.Enabled = false;

            }

        }

        private void portToolStripMenuItem_Click(object sender, EventArgs e)
        {
            port portform = new port();

            if (portform.ShowDialog() == DialogResult.OK)
            {
                enableToolStripMenuItem.Enabled = true;
                enableToolStripMenuItem1.Enabled = true;
                disableToolStripMenuItem.Enabled = true;
                disableToolStripMenuItem1.Enabled = true;

                selectedPort = portform.getPort();

                Ports = SerialPort.GetPortNames().Length;
                selectedportlabel.Text = selectedPort;
                receiver = new SerialPort(selectedPort, 9600);
            }
            else
            {
                MessageBox.Show("COM port not selected");
            }
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableToolStripMenuItem.Checked = true;
            disableToolStripMenuItem.Checked = false;
            receiver.DtrEnable = true;
            triggerLeds("dtr", true); 
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableToolStripMenuItem.Checked = false;
            disableToolStripMenuItem.Checked = true;
            receiver.DtrEnable = false;
            triggerLeds("dtr", false);
        }

        private void enableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            enableToolStripMenuItem1.Checked = true;
            disableToolStripMenuItem1.Checked = false;
            receiver.RtsEnable = true;
            triggerLeds("rts", true);
        }

        private void disableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            enableToolStripMenuItem1.Checked = false;
            disableToolStripMenuItem1.Checked = true;
            receiver.RtsEnable = false;
            triggerLeds("rts", false);
        }

        private void arduino_sampler_Tick(object sender, EventArgs e)
        {
            receiveData();
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manual _manualForm = new manual();
            _manualForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about _aboutForm = new about();
            _aboutForm.ShowDialog();
        }

        private void trackBar1_MouseMove(object sender, MouseEventArgs e)
        {
                lbSamplingTime.Text = (500*trackBar1.Value).ToString() + " ms";
                logger.Interval = trackBar1.Value*500;
                arduino_sampler.Interval = logger.Interval; 
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_f2created)
                _f2.Dispose();
            if (chartscreated)
                charts.Dispose();
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_f2created)
                _f2.Dispose();
            if(chartscreated)
                charts.Dispose();
            Application.Restart();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(dir + "\\convertedXML.xlsx"))
                File.Delete(dir + "\\convertedXML.xlsx");
            if (File.Exists(dir + "\\convertedXML.txt"))
                File.Delete(dir + "\\convertedXML.txt");
            if (File.Exists(dir + "\\_temp.xml"))
                File.Delete(dir + "\\_temp.xml");
        }

        private void convertXmlFileToXlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(dir + "\\convertedXML.xls"))
            {
                File.Delete(dir + "\\convertedXML.xls");
            }
            MessageBox.Show("Before proceeding further, please close all instances of\r\nMicrosoft Excel and save your work.");
            ConvertToXLSX();
        }

        private void convertXmlFileToTxtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (File.Exists(dir + "\\convertedXML.txt"))
            {
                File.Delete(dir + "\\convertedXML.txt");
            }
            ConvertToTxt();
        }

    }
}
