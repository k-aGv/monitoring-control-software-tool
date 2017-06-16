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
        public string input = "", d1 = "", d2 = "", d3 = "", d4 = "";
        SerialPort receiver;
        bool excp = false;


        string selectedPort = "";
        int Ports;

        XmlWriterSettings settings = new XmlWriterSettings();
        Random rnd = new Random(); //required only for demo-mode
      
        /// //////////////////////////////////////////////////////////////////////////////////
        realtime _f2;// = new realtime();
        realtimecharts charts;// = new realtimecharts();
        bool _f2created = false;
        bool chartscreated = false;
        //////////////////////////////////////////////////////////////////////////////////

        Point loc = new Point(); //X-Y form coordinates


        public double[] b = new double[4]; //table which incoming values are stored into
        public bool[] cb_state = new bool[4];
        public string[] sensors_status_var = new string[4];
        public string[] comments = new string[4];

        int counter = 0;
        int i = 0;
        int totalSamples;

        string dir = Directory.GetCurrentDirectory() + "\\_temp";
        string curtime, curdate;
        string pickeddate, pickedtime, pickedhour = "", pickedminute = "";
        string pickeddatestop, pickedtimestop, pickedhourstop = "", pickedminutestop = "";
        string curhour = "", curminute = "", cursec = "";

        public bool running = false;
        bool monitor_started = false;
        bool started;
        
        public string time_format()
        {
            if (DateTime.Now.Hour < 10)
                curhour = "0";
            else
                curhour = "";

            if (DateTime.Now.Minute < 10)
                curminute = "0";
            else
                curminute = "";

            if (DateTime.Now.Second < 10)
                cursec = "0";
            else
                cursec = "";

            curtime = curhour + DateTime.Now.Hour.ToString()
                + ":" + curminute + DateTime.Now.Minute.ToString()
                + ":" + cursec + DateTime.Now.Second.ToString();
            return curtime;
        }
        public void sensors_status(bool[] cb_state)
        {
            for (int i = 0; i < 4; i++)
            {
                sensors_status_var[i] = "OFF";
                if (cb_state[i])
                {
                    sensors_status_var[i] = "ON";
                }
            }
        }
        public void reset()
        {
            i = 0;
            //charts.Hide();
            //_f2.Hide();
            ///////////////////////////////////////////////////////////////////////////
            charts.Dispose();
            _f2.Dispose();
            _f2created = false;
            chartscreated = false;
            ///////////////////////////////////////////////////////////////////////////

            selectedPort = "";
            selectedportlabel.Text = "";
            start.Text = "Start";
            Stop.Enabled = false;
            save.Enabled = false;
            triggerLeds();


            enableToolStripMenuItem.Enabled = true;
            enableToolStripMenuItem1.Enabled = true;
            disableToolStripMenuItem.Enabled = true;
            disableToolStripMenuItem1.Enabled = true;

            trackBar1.Enabled = true;

            enableToolStripMenuItem.Checked = false;
            disableToolStripMenuItem.Checked = true;
            enableToolStripMenuItem1.Checked = false;
            disableToolStripMenuItem1.Checked = true;

            openFileToolStripMenuItem.Enabled = true;
            ScheduledMonitorCB.Enabled = true;
            sensor1CB.Enabled = true;
            sensor2CB.Enabled = true;
            sensor3CB.Enabled = true;
            sensor4CB.Enabled = true;


            if (File.Exists(dir + "\\_temp.xml"))
                File.Delete(dir + "\\_temp.xml");

            if (is_busy_check_timer.Enabled)
                is_busy_check_timer.Stop();
            if (logger.Enabled)
                logger.Stop();
            if (timer2.Enabled)
                timer2.Stop();
            if (timer3.Enabled)
                timer3.Stop();
            if (arduino_sampler.Enabled)
                arduino_sampler.Stop();

            cb_demo.Enabled = true;
        }
        public void Start()
        {
            if (selectedPort != "" || cb_demo.Checked)
            {
                started = false;
                //<saves checkboxes status>
                cb_state[0] = sensor1CB.Checked;
                cb_state[1] = sensor2CB.Checked;
                cb_state[2] = sensor3CB.Checked;
                cb_state[3] = sensor4CB.Checked;
                //<saves checkboxes status>
                if(start.Text=="Start")
                {
                    charts = new realtimecharts();
                    _f2 = new realtime();
                }


                sensors_status(cb_state); //sensors info for comments

                //<transfers checkboxes status to graphic forms>
                charts.getCBstate(cb_state);
                _f2.getCBstate(cb_state);
                //<transfers checkboxes status to graphic forms>

                //<disables sensors checkboxes while running>
                sensor1CB.Enabled = false;
                sensor2CB.Enabled = false;
                sensor3CB.Enabled = false;
                sensor4CB.Enabled = false;
                //<disables sensors checkboxes while running>

                openFileToolStripMenuItem.Enabled = false;

                if (start.Text == "Start")
                {
                    //charts + arduino interval modifications
                    logger.Interval = trackBar1.Value * 500;
                    arduino_sampler.Interval = trackBar1.Value * 500;
                    charts.getTimerInterval(arduino_sampler.Interval);
                    _f2.getTimerInterval(arduino_sampler.Interval);
                    is_busy_check_timer.Start();

                    

                    //<informs the graph forms that monitoring has started & transfers values>
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    //running = true;
                    //_f2.running_state(running);
                    //charts.running_state(running);
                    _f2.getValues(b);
                    charts.getValues(b);
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    //<informs the graph forms that monitoring has started & transfers values>

                    if (File.Exists(dir + "\\_temp.xml"))
                        File.Delete(dir + "\\_temp.xml");


                    save.Enabled = false;
                }

                if (!ScheduledMonitorCB.Checked)
                {
                    
                    if (start.Text != "Stop")
                    {
                        enableToolStripMenuItem.Enabled = true;
                        enableToolStripMenuItem1.Enabled = true;
                        disableToolStripMenuItem.Enabled = true;
                        disableToolStripMenuItem1.Enabled = true;

                        realTimeGraphMonitoringToolStripMenuItem.Enabled = true;
                        realtimevaluesToolStripMenuItem.Enabled = true;

                        is_busy_check_timer.Start();

                        ScheduledMonitorCB.Enabled = false;
                        Stop.Enabled = false;
                        save.Enabled = false;
                        start.Text = "Stop";

                        //<serial handling>
                        excp = false;
                        try {
                            if (!cb_demo.Checked) {
                                receiver.Open();
                                receiver.ReadLine();
                            } else
                                input = Convert.ToString(rnd.Next(10, 35)) + "n"
                                        + Convert.ToString(rnd.Next(10, 35)) + "n"
                                        + Convert.ToString(rnd.Next(10, 35)) + "n"
                                        + Convert.ToString(rnd.Next(10, 35));
                            InitCurveValues();

                            counter = 0;
                            logger.Start();
                            arduino_sampler.Start();



                        } catch (System.IO.IOException) {
                            MessageBox.Show("Μη διαθέσιμη θύρα COM.", "COM error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            excp = true;
                        } catch (System.ArgumentException) {
                            receiver.PortName = "";
                            MessageBox.Show("Μη έγκυρο όνομα θύρας", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            excp = true;
                        } catch (Exception ex) {
                            MessageBox.Show(ex + "");
                        }
                        //<serial handling>
                    }
                    else
                    {
                        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        if (_f2.Enabled)
                        {
                            _f2.Hide();
                            _f2.realtime_timer.Stop();
                        }
                        if(charts.Enabled)
                        {
                            charts.Hide();
                            charts.logger.Stop();
                        }
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        realTimeGraphMonitoringToolStripMenuItem.Enabled = false;
                        realtimevaluesToolStripMenuItem.Enabled = false;



                        Stop.Enabled = true;
                        start.Text = "Resume";
                        logger.Stop();
                        arduino_sampler.Stop();
                        save.Enabled = true;


                        if(!cb_demo.Checked)
                            receiver.Close();
                        input = null;
                    }
                }
                else
                {
                    time_check();
                }
            }
            else
            {
                MessageBox.Show("Please select the desired COM port from Settings menu");
                return;
            }
            cb_demo.Enabled = false;
        }
        public void time_check()
        {
            if (!monitor_started)
                if (start.Text != "Stop")
                {

                    //==================================================================================================
                    //=======================================Picked hours format edit===================================
                    //==================================================================================================
                    if (starthour.Value < 10)
                        pickedhour = "0";
                    else
                        pickedhour = "";

                    if (startminute.Value < 10)
                        pickedminute = "0";
                    else
                        pickedminute = "";

                    pickedtime = pickedhour + starthour.Value.ToString()
                        + ":" + pickedminute + startminute.Value.ToString();
                    //==================================================================================================
                    //=======================================END of picked hours format edit============================
                    //==================================================================================================


                    //==================================================================================================
                    //=======================================Current time format edit===================================
                    //==================================================================================================
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
                    //==================================================================================================
                    //=======================================END of current time format edit============================
                    //==================================================================================================

                    pickeddate = startdate.Value.Day.ToString()
                        + "/" + startdate.Value.Month.ToString()
                        + "/" + startdate.Value.Year.ToString();

                    curdate = DateTime.Now.Day.ToString()
                        + "/" + DateTime.Now.Month.ToString()
                        + "/" + DateTime.Now.Year.ToString();

                    start.Text = "Stop";
                    Stop.Enabled = false;
                    ScheduledMonitorCB.Enabled = false;
                    timer2.Start();
                }
                else
                {
                    Stop.Enabled = true;
                    start.Text = "Start";
                    if (logger.Enabled)
                        logger.Stop();
                    if (arduino_sampler.Enabled)
                        arduino_sampler.Stop();
                    timer2.Stop();
                    //stop_flag = true;
                }
            else
            {
                if (start.Text == "Stop")
                {
                    start.Text = "Resume";
                    Stop.Enabled = true;
                    if (logger.Enabled)
                        logger.Stop();
                    if (arduino_sampler.Enabled)
                        arduino_sampler.Stop();
                }
                else
                {
                    Stop.Enabled = false;
                    start.Text = "Stop";
                    if (!logger.Enabled)
                        logger.Start();
                    if (!arduino_sampler.Enabled)
                        arduino_sampler.Start();
                }
            }
        }
        public void InitCurveValues()
        {
            if (input != "" && !(input.Length < 1))
            {
                char[] delim = { 'n' };
                string[] _tempValues;
                _tempValues = input.Split(delim, 4);

                if (_tempValues[0] != "")
                    if (cb_state[0])
                        b[0] = Convert.ToDouble(_tempValues[0]);

                if (_tempValues[1] != "")
                    if (cb_state[1])
                        b[1] = Convert.ToDouble(_tempValues[1]);

                if (_tempValues[2] != "")
                    if (cb_state[2])
                        b[2] = Convert.ToDouble(_tempValues[2]);

                if (_tempValues[3] != "")
                    if (cb_state[3])
                        b[3] = Convert.ToDouble(_tempValues[3]);

                _f2.getValues(b);
                charts.getValues(b);
            }

        }
        public void receiveData()
        {
            try {
                if (!cb_demo.Checked)
                    input = receiver.ReadLine();
                else
                    input = Convert.ToString(rnd.Next(10, 60)) + "n"
                        + Convert.ToString(rnd.Next(10, 60)) + "n"
                        + Convert.ToString(rnd.Next(10, 60)) + "n"
                        + Convert.ToString(rnd.Next(10, 60));
            } catch (System.InvalidOperationException) {
                arduino_sampler.Stop();
                MessageBox.Show("Η επιλεγμένη θύρα παρουσίασε σφάλμα. Πατήστε Stop για νέα δοκιμή.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!File.Exists(dir + "\\_temp.xml"))
            {
            }
            else
                dataProcessing();
        }
        public void dataProcessing()
        {

            char[] delim = { 'n' };
            string[] _tempValues;
            _tempValues = input.Split(delim, 4);

            if (arduino_sampler.Enabled && !excp)
            {
                values_generator(_tempValues);
            }

        }
        public void values_generator(string[] _tempValues)
        {
            i++; //xml sample index


            if (input.Length < 1)
                return;

            if (_tempValues[0] != "")
                b[0] = Convert.ToDouble(_tempValues[0]);

            if (_tempValues[1] != "")
                b[1] = Convert.ToDouble(_tempValues[1]);

            if (_tempValues[2] != "")
                b[2] = Convert.ToDouble(_tempValues[2]);

            if (_tempValues[3] != "")
                b[3] = Convert.ToDouble(_tempValues[3]);

            _f2.getValues(b);
            charts.getValues(b);
            write_to_xml(i);
        }
        public void triggerLeds()
        {
            dtrLed.BackColor = Color.Red;
            rtsLed.BackColor = Color.Red;
        }
        public void triggerLeds(string led, bool turnOn)
        {
            if (led == "dtr")
            {
                if (turnOn)
                    dtrLed.BackColor = Color.Green;
                else
                    dtrLed.BackColor = Color.Red;
            }
            else if (led == "rts")
            {
                if (turnOn)
                    rtsLed.BackColor = Color.Green;
                else
                    rtsLed.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Invalid arguments");
            }

        }
        public void write_to_xml(int i)
        {

            XDocument doc = XDocument.Load(dir + "\\_temp.xml");
            //1234
            if (sensor1CB.Checked && sensor2CB.Checked && sensor3CB.Checked && sensor4CB.Checked)
            {
                XElement value1 = new XElement("Sample" + i,
                    new XElement("Sensor1",
                        new XAttribute("value", b[0]),
                        new XAttribute("Time", "" + time_format())),//+ ":" + DateTime.Now.Second)),
                    new XElement("Sensor2",
                        new XAttribute("value", b[1]),
                        new XAttribute("Time", "" + time_format())),// + ":" + DateTime.Now.Second)),
                    new XElement("Sensor3",
                        new XAttribute("value", b[2]),
                        new XAttribute("Time", "" + time_format())),// + ":" + DateTime.Now.Second)),
                    new XElement("Sensor4",
                        new XAttribute("value", b[3]),
                        new XAttribute("Time", "" + time_format())));// + ":" + DateTime.Now.Second)));
                doc.Root.Add(value1);
            }
            //123
            else if (sensor1CB.Checked && sensor2CB.Checked && sensor3CB.Checked && !sensor4CB.Checked)
            {
                XElement value1 = new XElement("Sample" + i,
                    new XElement("Sensor1",
                        new XAttribute("value", b[0]),
                        new XAttribute("Time", "" + time_format())),//+ ":" + DateTime.Now.Second)),
                    new XElement("Sensor2",
                        new XAttribute("value", b[1]),
                        new XAttribute("Time", "" + time_format())),//+ ":" + DateTime.Now.Second)),
                    new XElement("Sensor3",
                        new XAttribute("value", b[2]),
                        new XAttribute("Time", "" + time_format())));// + ":" + DateTime.Now.Second)));
                doc.Root.Add(value1);
            }
            //124
            else if (sensor1CB.Checked && sensor2CB.Checked && !sensor3CB.Checked && sensor4CB.Checked)
            {
                XElement value1 = new XElement("Sample" + i,
                    new XElement("Sensor1",
                        new XAttribute("value", b[0]),
                        new XAttribute("Time", "" + time_format())),//+ ":" + DateTime.Now.Second)),
                    new XElement("Sensor2",
                        new XAttribute("value", b[1]),
                        new XAttribute("Time", "" + time_format())),//+ ":" + DateTime.Now.Second)),
                    new XElement("Sensor4",
                        new XAttribute("value", b[3]),
                        new XAttribute("Time", "" + time_format())));// + ":" + DateTime.Now.Second)));
                doc.Root.Add(value1);
            }
            //134
            else if (sensor1CB.Checked && !sensor2CB.Checked && sensor3CB.Checked && sensor4CB.Checked)
            {
                XElement value1 = new XElement("Sample" + i,
                   new XElement("Sensor1",
                       new XAttribute("value", b[0]),
                       new XAttribute("Time", "" + time_format())),//+ ":" + DateTime.Now.Second)),
                   new XElement("Sensor3",
                       new XAttribute("value", b[2]),
                       new XAttribute("Time", "" + time_format())),//+ ":" + DateTime.Now.Second)),
                   new XElement("Sensor4",
                       new XAttribute("value", b[3]),
                       new XAttribute("Time", "" + time_format())));//+ ":" + DateTime.Now.Second)),
                doc.Root.Add(value1);
            }
            //234
            else if (!sensor1CB.Checked && sensor2CB.Checked && sensor3CB.Checked && sensor4CB.Checked)
            {
                XElement value1 = new XElement("Sample" + i,
                   new XElement("Sensor2",
                       new XAttribute("value", b[1]),
                       new XAttribute("Time", "" + time_format())),//+ ":" + DateTime.Now.Second)),
                   new XElement("Sensor3",
                       new XAttribute("value", b[2]),
                       new XAttribute("Time", "" + time_format())),//+ ":" + DateTime.Now.Second)),
                   new XElement("Sensor4",
                       new XAttribute("value", b[3]),
                       new XAttribute("Time", "" + time_format())));//+ ":" + DateTime.Now.Second)),
                doc.Root.Add(value1);
            }
            //12
            else if (sensor1CB.Checked && sensor2CB.Checked && !sensor3CB.Checked && !sensor4CB.Checked)
            {
                XElement value1 = new XElement("Sample" + i,
                   new XElement("Sensor1",
                       new XAttribute("value", b[0]),
                       new XAttribute("Time", "" + time_format())),//+ ":" + DateTime.Now.Second)),
                   new XElement("Sensor2",
                       new XAttribute("value", b[1]),
                       new XAttribute("Time", "" + time_format())));//+ ":" + DateTime.Now.Second)),
                doc.Root.Add(value1);
            }
            //13
            else if (sensor1CB.Checked && !sensor2CB.Checked && sensor3CB.Checked && !sensor4CB.Checked)
            {
                XElement value1 = new XElement("Sample" + i,
                   new XElement("Sensor1",
                       new XAttribute("value", b[0]),
                       new XAttribute("Time", "" + time_format())),//+ ":" + DateTime.Now.Second)),
                   new XElement("Sensor3",
                       new XAttribute("value", b[2]),
                       new XAttribute("Time", "" + time_format())));//+ ":" + DateTime.Now.Second)),
                doc.Root.Add(value1);
            }
            //14
            else if (sensor1CB.Checked && !sensor2CB.Checked && !sensor3CB.Checked && sensor4CB.Checked)
            {
                XElement value1 = new XElement("Sample" + i,
                   new XElement("Sensor1",
                       new XAttribute("value", b[0]),
                       new XAttribute("Time", "" + time_format())),//+ ":" + DateTime.Now.Second)),
                   new XElement("Sensor4",
                       new XAttribute("value", b[3]),
                       new XAttribute("Time", "" + time_format())));//+ ":" + DateTime.Now.Second)),
                doc.Root.Add(value1);
            }
            //23
            else if (!sensor1CB.Checked && sensor2CB.Checked && sensor3CB.Checked && !sensor4CB.Checked)
            {
                XElement value1 = new XElement("Sample" + i,
                   new XElement("Sensor2",
                       new XAttribute("value", b[1]),
                       new XAttribute("Time", "" + time_format())),//+ ":" + DateTime.Now.Second)),
                   new XElement("Sensor3",
                       new XAttribute("value", b[2]),
                       new XAttribute("Time", "" + time_format())));//+ ":" + DateTime.Now.Second)),
                doc.Root.Add(value1);
            }
            //24
            else if (!sensor1CB.Checked && sensor2CB.Checked && !sensor3CB.Checked && sensor4CB.Checked)
            {
                XElement value1 = new XElement("Sample" + i,
                   new XElement("Sensor2",
                       new XAttribute("value", b[1]),
                       new XAttribute("Time", "" + time_format())),//+ ":" + DateTime.Now.Second)),
                   new XElement("Sensor4",
                       new XAttribute("value", b[3]),
                       new XAttribute("Time", "" + time_format())));//+ ":" + DateTime.Now.Second)),
                doc.Root.Add(value1);
            }
            //34
            else if (!sensor1CB.Checked && !sensor2CB.Checked && sensor3CB.Checked && sensor4CB.Checked)
            {
                XElement value1 = new XElement("Sample" + i,
                   new XElement("Sensor3",
                       new XAttribute("value", b[2]),
                       new XAttribute("Time", "" + time_format())),//+ ":" + DateTime.Now.Second)),
                   new XElement("Sensor4",
                       new XAttribute("value", b[3]),
                       new XAttribute("Time", "" + time_format())));//+ ":" + DateTime.Now.Second)),
                doc.Root.Add(value1);
            }
            //1
            else if (sensor1CB.Checked && !sensor2CB.Checked && !sensor3CB.Checked && !sensor4CB.Checked)
            {
                XElement value1 = new XElement("Sample" + i,
                   new XElement("Sensor1",
                       new XAttribute("value", b[0]),
                       new XAttribute("Time", "" + time_format())));// + ":" + DateTime.Now.Second)));
                doc.Root.Add(value1);
            }
            //2
            else if (!sensor1CB.Checked && sensor2CB.Checked && !sensor3CB.Checked && !sensor4CB.Checked)
            {
                XElement value1 = new XElement("Sample" + i,
                   new XElement("Sensor2",
                       new XAttribute("value", b[1]),
                       new XAttribute("Time", "" + time_format())));// + ":" + DateTime.Now.Second)));
                doc.Root.Add(value1);
            }
            //3
            else if (!sensor1CB.Checked && !sensor2CB.Checked && sensor3CB.Checked && !sensor4CB.Checked)
            {
                XElement value1 = new XElement("Sample" + i,
                   new XElement("Sensor3",
                       new XAttribute("value", b[2]),
                       new XAttribute("Time", "" + time_format())));// + ":" + DateTime.Now.Second)));
                doc.Root.Add(value1);
            }
            //4
            else if (!sensor1CB.Checked && !sensor2CB.Checked && !sensor3CB.Checked && sensor4CB.Checked)
            {
                XElement value1 = new XElement("Sample" + i,
                   new XElement("Sensor4",
                       new XAttribute("value", b[3]),
                       new XAttribute("Time", "" + time_format())));// + ":" + DateTime.Now.Second)));
                doc.Root.Add(value1);
            }
            doc.Save(dir + "\\_temp.xml");
        }
        public void time_reached()
        {
            if (logger.Enabled)
                logger.Stop();
            if (timer2.Enabled)
                timer2.Stop();
            if (timer3.Enabled)
                timer3.Stop();
            if (arduino_sampler.Enabled)
                arduino_sampler.Stop();
            MessageBox.Show("Set time has been reached.\nMonitoring has stopped.");
        }
        public void savefile(string type)
        {
            if (type == "xml")
            {
                saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                saveFileDialog1.FileName = "";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        File.Delete(saveFileDialog1.FileName);
                    }
                    File.Copy(dir + "\\_temp.xml", saveFileDialog1.FileName);
                }
            }
            else if (type == "txt")
            {
                saveFileDialog1.Filter = "TEXT files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FileName = "";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        File.Delete(saveFileDialog1.FileName);
                    }
                    File.Copy(dir + "\\convertedXML.txt", saveFileDialog1.FileName);
                }
            }
            else if (type == "xlsx")
            {
                saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog1.FileName = "";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        File.Delete(saveFileDialog1.FileName);
                    }
                    File.Copy(dir + "\\convertedXML.xlsx", saveFileDialog1.FileName);
                    if (File.Exists(dir + "\\convertedXML.xlsx"))
                    {
                        COMrelease();
                        Application.DoEvents();
                        File.Delete(dir + "\\convertedXML.xlsx");
                    }
                }
                else
                    if (File.Exists(dir + "\\convertedXML.xlsx"))
                    {
                        COMrelease();
                        Application.DoEvents();
                        File.Delete(dir + "\\convertedXML.xlsx");
                    }

            }
        }
        public void xmlcommentsParser(string filename) {
            i = 0;

            XmlReader comments_reader = XmlReader.Create(filename); //stream for comments
            while (comments_reader.Read()) {
                switch (comments_reader.NodeType) {
                    case XmlNodeType.Comment:
                        comments[i] = comments_reader.Value.ToString();
                        i++;
                        break;
                }
            }
            comments_reader.Close();
        }
        public void ConvertToTxt()
        {
            string filename = null;
            bool fileOpened = false;

            openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                fileOpened = true;
            }
            else
                filename = null;


            if (fileOpened)
            {
                try {
                    xmlcommentsParser(filename);
                } catch (Exception z) {
                    MessageBox.Show
                        (
                        "An error has occured while parsing the chosen file. A possible file corruption may cause this error.\nPlease try again.",
                        "Conversion failed"
                        );
                    return;
                }

                int _1stparse = 0;
                char[] del = { '/', ':' };
                string[] sensors = comments[3].Split(del, 8);

                char[] attrValuesDelimiters = { '"' };
                string[] attrValues;
                string line1, line2;


                StreamReader xmlreader = new StreamReader(filename);
                StreamWriter writer = new StreamWriter(dir + "\\convertedXML.txt");

                for (int i = 0; i < 8; i++)
                    if (sensors[i].Contains("ON"))
                        writer.Write(sensors[i - 1].Replace(" ", "") + ", Time" + ", ");
                writer.Write("Record date, " + "Record time, " + "Sampling time");

                writer.Write("\r\n");

                while (!xmlreader.EndOfStream)
                {
                    line1 = xmlreader.ReadLine();
                    line2 = line1;
                    if (line1.Contains("<Sensor1")
                        || line1.Contains("<Sensor2")
                        || line1.Contains("<Sensor3")
                        || line1.Contains("<Sensor4"))
                    {
                        attrValues = line1.Split(attrValuesDelimiters, 5);
                        writer.Write(attrValues[1] + ", " + attrValues[3] + ", ");

                    }
                    if (line1.Contains("</Sample"))
                    {
                        _1stparse++;
                        if (_1stparse == 1)
                            writer.Write(comments[0] + ", " + comments[1] + ", " + comments[2] + ", ");
                        writer.Write("\r\n");
                    }
                }
                xmlreader.Close();
                writer.Close();
                savefile("txt");
            }
            if (File.Exists(dir + "\\convertedXML.txt"))
                File.Delete(dir + "\\convertedXML.txt");
        }
        public void ConvertToXLSX()
        {
            string filename = null;
            bool fileOpened = false;

            openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                fileOpened = true;
            }
            else
                filename = null;

            if (fileOpened)
            {
                try {
                    xmlcommentsParser(filename);
                } 
                catch (Exception z) {
                    MessageBox.Show
                        (
                        "An error has occured while parsing the chosen file. A possible file corruption may cause this error.\nPlease try again.", 
                        "Conversion failed"
                        );
                    return;
                }
                int columnIndex = 1;
                int rawIndex = 1;

                COMrelease(); //clears every process of Excel for no memory leaks - USER IS INFORMED through Messagebox
                convertXmlFileToTxtToolStripMenuItem1.Enabled = false;
                convertXmlFileToXlsToolStripMenuItem.Enabled = false;
                Excel.Application xlApp = new Excel.Application();
                
                
                if (xlApp == null)
                {
                    MessageBox.Show("You need to first install Excel.");
                    return;
                }
                
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;

                xlWorkBook = xlApp.Workbooks.Add();
                xlWorkSheet = xlApp.Worksheets.get_Item(1);


                char[] del = { '/', ':' };
                string[] sensors = comments[3].Split(del, 8);

                char[] attrValuesDelimiters = { '"' };
                string[] attrValues;

                //<xlsx initialization - column titles & alignment>
                for (int j = 0; j < sensors.Length; j++)
                    if (sensors[j].Contains("ON"))
                    {
                        xlWorkSheet.Cells[rawIndex, columnIndex] = sensors[j - 1];
                        columnIndex++;
                        xlWorkSheet.Cells[rawIndex, columnIndex] = "Time";
                        columnIndex++;
                    }

                for (int column = 1; column < columnIndex; column++)
                {
                    xlWorkSheet.Columns[column].ColumnWidth = 10;
                    xlWorkSheet.Columns[column].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                }

                xlWorkSheet.Cells[rawIndex, columnIndex] = "Log's date";
                xlWorkSheet.Columns[columnIndex].ColumnWidth = 10;
                xlWorkSheet.Cells[rawIndex + 1, columnIndex] = comments[0];

                columnIndex++;
                xlWorkSheet.Cells[rawIndex, columnIndex] = "Creation time";
                xlWorkSheet.Columns[columnIndex].ColumnWidth = 13;
                xlWorkSheet.Cells[rawIndex + 1, columnIndex] = comments[1];

                columnIndex++;
                xlWorkSheet.Cells[rawIndex, columnIndex] = "Sampling time";
                xlWorkSheet.Columns[columnIndex].ColumnWidth = 13;
                xlWorkSheet.Cells[rawIndex + 1, columnIndex] = comments[2].Replace('.', ',');
                //</xlsx initialization - column titles & alignment>

                //<xlxs data import>
                StreamReader reader = new StreamReader(filename);
                samplesCounter(reader); //this will read the whole file and <<reader>> will reach its end
                reader.BaseStream.Position = 0; //so here I "tell" reader to go back to the top of the stream
                
                //<progress form initialization>
                Progress prog_form = new Progress();
                loc.X=this.Size.Width + this.Location.X;
                loc.Y = this.Location.Y;
                prog_form.GetSet_location(loc);
                prog_form.stop.Text = "Stop";
                prog_form.progressBar1.Maximum = totalSamples;
                prog_form.progressBar1.Step = 1;
                prog_form.Show();
                //</progress form initialization>

                string current_line;
                rawIndex++;
                columnIndex = 0;
                while (!(reader.EndOfStream))
                {
                    if (prog_form.stopped)
                    {
                        xlApp.Quit();
                        COMrelease();
                        MessageBox.Show("Conversion has been stoped");
                        prog_form.Dispose();
                        convertXmlFileToTxtToolStripMenuItem1.Enabled = true;
                        convertXmlFileToXlsToolStripMenuItem.Enabled = true;
                        return;
                    }

                    current_line = reader.ReadLine();
                    if (   current_line.Contains("<Sensor1")
                        || current_line.Contains("<Sensor2")
                        || current_line.Contains("<Sensor3")
                        || current_line.Contains("<Sensor4"))
                    {
                        try
                        {
                            
                            attrValues = current_line.Split(attrValuesDelimiters);

                            columnIndex++;
                            if (rawIndex % 2 == 0)
                            {
                                xlWorkSheet.Cells[rawIndex, columnIndex].Interior.Color = Color.LightGray;
                            }
                            xlWorkSheet.Cells[rawIndex, columnIndex] = attrValues[1];

                            columnIndex++;
                            if (rawIndex % 2 == 0)
                            {
                                xlWorkSheet.Cells[rawIndex, columnIndex].Interior.Color = Color.LightGray;
                            }
                            xlWorkSheet.Cells[rawIndex, columnIndex] = attrValues[3];
                        }
                        catch
                        {
                            MessageBox.Show("failed");
                            COMrelease();
                            return;
                        }
                    }

                    if(current_line.Contains("/Sample"))
                    {
                        prog_form.progressBar1.Value++;
                        prog_form.current_samples_LB.Text ="Converting: " + prog_form.progressBar1.Value + " / " + totalSamples + " samples.";
                        prog_form.conversion_progress_LB.Text ="Conversion in progress... " + (100 * prog_form.progressBar1.Value) / totalSamples + " %";

                        rawIndex++;
                        columnIndex = 0;
                    }
                    

                    //no use of this command would cause the application to freeze
                    //for as long the conversion is in progress
                    Application.DoEvents(); 
                    
                }
                //</xlsx data import>

                //<xlsx save>
                try
                {
                    prog_form.conversion_progress_LB.Text = "Conversion finished!";
                    prog_form.current_samples_LB.Text = "Converted: " + prog_form.progressBar1.Value + " / " + totalSamples + " samples.";
                    xlWorkBook.SaveAs(dir + "\\convertedXML.xlsx");
                    xlApp.Quit();
                    COMrelease();

                    savefile("xlsx");
                    if(prog_form.Enabled)
                        prog_form.Dispose();

                    convertXmlFileToTxtToolStripMenuItem1.Enabled = true; ;
                    convertXmlFileToXlsToolStripMenuItem.Enabled = true; ;
                }
                catch
                {
                    MessageBox.Show("An unexpected error has occured.\r\nConversion will now terminate.");
                    COMrelease();
                    return;
                }
                //</xlsx save>

                COMrelease();
            }
        }
        public void samplesCounter(StreamReader reader)
        {
            totalSamples = 0;
            string current_line;
            while (!(reader.EndOfStream))
            {
                current_line = reader.ReadLine();
                if (current_line.Contains("/Sample"))
                {
                    totalSamples++;
                }
            }

        }
        public void COMrelease()
        {
            System.Diagnostics.Process[] objProcess = System.Diagnostics.Process.GetProcessesByName("EXCEL");

            if (objProcess.Length > 0)
            {
                System.Collections.Hashtable objHashtable = new System.Collections.Hashtable();

                // check to kill the right process
                foreach (System.Diagnostics.Process processInExcel in objProcess)
                {
                    if (objHashtable.ContainsKey(processInExcel.Id) == false)
                    {
                        processInExcel.Kill();
                    }
                }
                objProcess = null;
            }
        }
    }
}
