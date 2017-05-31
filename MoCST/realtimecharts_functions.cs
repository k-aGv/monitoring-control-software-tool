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
        // <graph stuff>
        GraphPane z;
        CurveItem curve0, curve1, curve2, curve3;
        double[] init = new double[1];
        double[] zero = new double[1];
        bool init_Curves = true;
        bool scrolltrack;
        bool scroll_handler = true;
        //4 gia 4 sensors
        //1 tha ginetai kathe fora resize
        double[,] varsX = new double[1, 4];
        double[,] varsY = new double[1, 4];
        int[] countX = new int[4];
        int[] countY = new int[4];
        //t[xy , values, ID]
        double[, ,] t = new double[2, 50, 4];
        // </graph stuff>


        int i = 0;
        double xvalue1 = 0;
        double xvalue2 = 0;
        double xvalue3 = 0;
        double xvalue4 = 0;
        bool _running;
        //<bools for sensors' checkboxes>
        bool t1cbBOOL = false;
        bool t2cbBOOL = false;
        bool t3cbBOOL = false;
        bool t4cbBOOL = false;
        //</bools for sensors' checkboxes>
        public bool[] cb;
        public double[] values;

        //<unused functions - saved for just in case>
        /*
        
        T[,] ResizeArray<T>(T[,] original, int rows, int cols) //manually resize 2d array.let it be here just in case
        {
            var newArray = new T[rows, cols];
            int minRows = Math.Min(rows, original.GetLength(0));
            int minCols = Math.Min(cols, original.GetLength(1));
            for (int i = 0; i < minRows; i++)
                for (int j = 0; j < minCols; j++)
                    newArray[i, j] = original[i, j];
            return newArray;
        }
        */
        /*
        public void sensors_check() //sensors check unused
        {
            if (!cb[0])
            {
                t1cb.Enabled = false;
                sensor1.Enabled = false;
                sensor1.Checked = false;
                sensor1maxthres.Enabled = false;
                sensor1minthres.Enabled = false;
                sensor1maxthres.BackColor = Color.White;
                sensor1minthres.BackColor = Color.White;
            }
            else
            {
                //MessageBox.Show("sensor1 enabled");
                t1cb.Enabled = true;
                sensor1.Enabled = true;
                sensor1maxthres.Enabled = true;
                sensor1minthres.Enabled = true;
            }


            if (!cb[1])
            {
                t2cb.Enabled = false;
                sensor2.Checked = false;
                sensor2.Enabled = false;
                sensor2maxthres.Enabled = false;
                sensor2minthres.Enabled = false;
                sensor2maxthres.BackColor = Color.White;
                sensor2minthres.BackColor = Color.White;
            }
            else
            {
                //MessageBox.Show("sensor2 enabled");
                t2cb.Enabled = true;
                sensor2.Enabled = true;
                sensor2maxthres.Enabled = true;
                sensor2minthres.Enabled = true;
            }


            if (!cb[2])
            {
                t3cb.Enabled = false;
                sensor3.Checked = false;
                sensor3.Enabled = false;
                sensor3maxthres.Enabled = false;
                sensor3minthres.Enabled = false;
                sensor3maxthres.BackColor = Color.White;
                sensor3minthres.BackColor = Color.White;
            }
            else
            {
                t3cb.Enabled = true;
                sensor3.Enabled = true;
                sensor3maxthres.Enabled = true;
                sensor3minthres.Enabled = true;
            }


            if (!cb[3])
            {
                t4cb.Enabled = false;
                sensor4.Checked = false;
                sensor4.Enabled = false;
                sensor4maxthres.Enabled = false;
                sensor4minthres.Enabled = false;
                sensor4maxthres.BackColor = Color.White;
                sensor4minthres.BackColor = Color.White;
            }
            else
            {
                t4cb.Enabled = true;
                sensor4.Enabled = true;
                sensor4maxthres.Enabled = true;
                sensor4minthres.Enabled = true;
            }
        }
        */
        /*
        public void reset()
        {

            curve0.Clear();
            curve1.Clear();
            curve2.Clear();
            curve3.Clear();
        }
        */
        //</unused functions - saved for just in case>

        public double setValues(double[] _values, int c)
        {
            c--;
            double temp = _values[c];
            return temp;
        }
        public void getValues(double[] varsFromForm1)
        {
            values = varsFromForm1;
        }
        public void displayCharts()
        {
            xvalue1++;
            xvalue2++;
            xvalue3++;
            xvalue4++;

            t[0, i, 0] = xvalue1;
            t[1, i, 0] = setValues(values, 1);

            t[0, i, 1] = xvalue2;
            t[1, i, 1] = setValues(values, 2);

            t[0, i, 2] = xvalue3;
            t[1, i, 2] = setValues(values, 3);

            t[0, i, 3] = xvalue4;
            t[1, i, 3] = setValues(values, 4);


            if (cb[0])
            {
                if (t1cb.Checked)
                {
                    if (sensor1.Checked)
                    {
                        if (t[1, i, 0] > Convert.ToDouble(sensor1maxthres.Value))
                            sensor1maxthres.BackColor = Color.Red;
                        else
                            sensor1maxthres.BackColor = Color.White;

                        if (t[1, i, 0] < Convert.ToDouble(sensor1minthres.Value))
                            sensor1minthres.BackColor = Color.Red;
                        else
                            sensor1minthres.BackColor = Color.White;
                    }
                    else
                    {
                        sensor1maxthres.BackColor = Color.White;
                        sensor1minthres.BackColor = Color.White;
                    }
                    s1temperature.Text = "Sensor 1: " + t[1, i, 0] + "°C";
                }
                else
                {
                    sensor1maxthres.BackColor = Color.White;
                    sensor1minthres.BackColor = Color.White;

                    s1temperature.Text = "Sensor 1: N/A";
                }

                drawNextSpot_curve(0);
            }
            else
            {
                s1temperature.Text = "Sensor 1: N/A";

            }


            if (cb[1])
            {
                if (t2cb.Checked)
                {
                    if (sensor2.Checked)
                    {
                        if (t[1, i, 1] > Convert.ToDouble(sensor2maxthres.Value))
                            sensor2maxthres.BackColor = Color.Red;
                        else
                            sensor2maxthres.BackColor = Color.White;

                        if (t[1, i, 1] < Convert.ToDouble(sensor2minthres.Value))
                            sensor2minthres.BackColor = Color.Red;
                        else
                            sensor2minthres.BackColor = Color.White;
                    }
                    else
                    {
                        sensor2maxthres.BackColor = Color.White;
                        sensor2minthres.BackColor = Color.White;
                    }
                    s2temperature.Text = "Sensor 2: " + t[1, i, 1] + "°C";
                }
                else
                {
                    sensor2maxthres.BackColor = Color.White;
                    sensor2minthres.BackColor = Color.White;
                    s2temperature.Text = "Sensor 2: N/A";
                }


                drawNextSpot_curve(1);

            }
            else
            {
                s2temperature.Text = "Sensor 2: N/A";

            }


            if (cb[2])
            {
                if (t3cb.Checked)
                {
                    if (sensor3.Checked)
                    {
                        if (t[1, i, 2] > Convert.ToDouble(sensor3maxthres.Value))
                            sensor3maxthres.BackColor = Color.Red;
                        else
                            sensor3maxthres.BackColor = Color.White;

                        if (t[1, i, 2] < Convert.ToDouble(sensor3minthres.Value))
                            sensor3minthres.BackColor = Color.Red;
                        else
                            sensor3minthres.BackColor = Color.White;
                    }
                    else
                    {
                        sensor3maxthres.BackColor = Color.White;
                        sensor3minthres.BackColor = Color.White;
                    }
                    s3temperature.Text = "Sensor 3: " + t[1, i, 2] + "°C";
                }
                else
                {
                    sensor3maxthres.BackColor = Color.White;
                    sensor3minthres.BackColor = Color.White;
                    s3temperature.Text = "Sensor 3: N/A";
                }

                drawNextSpot_curve(2);

            }
            else
            {
                s3temperature.Text = "Sensor 3: N/A";

            }


            if (cb[3])
            {
                if (t4cb.Checked)
                {
                    if (sensor4.Checked)
                    {
                        if (t[1, i, 3] > Convert.ToDouble(sensor4maxthres.Value))
                            sensor4maxthres.BackColor = Color.Red;
                        else
                            sensor4maxthres.BackColor = Color.White;
                        if (t[1, i, 3] < Convert.ToDouble(sensor4minthres.Value))
                            sensor4minthres.BackColor = Color.Red;
                        else
                            sensor4minthres.BackColor = Color.White;
                    }
                    else
                    {
                        sensor4maxthres.BackColor = Color.White;
                        sensor4minthres.BackColor = Color.White;
                    }
                    s4temperature.Text = "Sensor 4: " + t[1, i, 3] + "°C";
                }
                else
                {
                    sensor4maxthres.BackColor = Color.White;
                    sensor4minthres.BackColor = Color.White;
                    s4temperature.Text = "Sensor 4 N/A";
                }

                drawNextSpot_curve(3);

            }
            else
            {
                s4temperature.Text = "Sensor 4 N/A";

            }


            i++;
            if (i == 50)
            {
                i = 0;

            }

            if (!cb[0])
            {
                t1cb.Enabled = false;
                t1cb.Checked = false;

                sensor1.Enabled = false;
                sensor1.Checked = false;
                sensor1maxthres.BackColor = Color.White;
                sensor1minthres.BackColor = Color.White;
                sensor1maxthres.Enabled = false;
                sensor1minthres.Enabled = false;

                curve0.Label.IsVisible = false;
            }
            else
            {
                if (!t1cbBOOL)
                {
                    t1cb.Enabled = true;
                    t1cb.Checked = true;
                    sensor1.Enabled = true;
                    curve0.Label.IsVisible = true;
                }
            }

            if (!cb[1])
            {
                t2cb.Checked = false;
                t2cb.Enabled = false;

                sensor2.Enabled = false;
                sensor2.Checked = false;
                sensor2maxthres.BackColor = Color.White;
                sensor2minthres.BackColor = Color.White;
                sensor2maxthres.Enabled = false;
                sensor2minthres.Enabled = false;

                curve1.Label.IsVisible = false;
            }
            else
            {
                if (!t2cbBOOL)
                {
                    t2cb.Checked = true;
                    t2cb.Enabled = true;
                    sensor2.Enabled = true;
                    curve1.Label.IsVisible = true;
                }
            }

            if (!cb[2])
            {
                t3cb.Checked = false;
                t3cb.Enabled = false;

                sensor3.Enabled = false;
                sensor3.Checked = false;
                sensor3maxthres.BackColor = Color.White;
                sensor3minthres.BackColor = Color.White;
                sensor3maxthres.Enabled = false;
                sensor3minthres.Enabled = false;

                curve2.Label.IsVisible = false;
            }
            else
            {
                if (!t3cbBOOL)
                {
                    t3cb.Checked = true;
                    t3cb.Enabled = true;
                    sensor3.Enabled = true;
                    curve2.Label.IsVisible = true;
                }
            }

            if (!cb[3])
            {
                t4cb.Checked = false;
                t4cb.Enabled = false;

                sensor4.Enabled = false;
                sensor4.Checked = false;
                sensor4maxthres.BackColor = Color.White;
                sensor4minthres.BackColor = Color.White;
                sensor4maxthres.Enabled = false;
                sensor4minthres.Enabled = false;

                curve3.Label.IsVisible = false;
            }
            else
            {
                if (!t4cbBOOL)
                {
                    t4cb.Checked = true;
                    t4cb.Enabled = true;
                    sensor4.Enabled = true;
                    curve3.Label.IsVisible = true;
                }
            }
        }
        public void initCurves()
        {
            zero[0] = 0;
            init[0] = t[1, 0, 0];
            curve0 = zedGraphControl1.GraphPane.AddCurve("Sensor 1", zero, init, Color.Green);
            init[0] = t[1, 0, 1];
            curve1 = zedGraphControl1.GraphPane.AddCurve("Sensor 2", zero, init, Color.Red);
            init[0] = t[1, 0, 2];
            curve2 = zedGraphControl1.GraphPane.AddCurve("Sensor 3", zero, init, Color.Black);
            init[0] = t[1, 0, 3];
            curve3 = zedGraphControl1.GraphPane.AddCurve("Sensor 4", zero, init, Color.Blue);

        }
        public void drawNextSpot_curve(int ID)
        {
            if (init_Curves)
            {
                initCurves();
                z = zedGraphControl1.GraphPane;
                zedGraphControl1.IsShowHScrollBar = true;
                zedGraphControl1.IsAutoScrollRange = true;
                zedGraphControl1.AutoScroll = true;
                init_Curves = false;
            }
            else
            {
                if (i == 20 && scrolltrack)// && scroll_handler)
                {
                    scrolltrack = false;
                    zedGraphControl1.Controls[0].Focus();
                    SendKeys.Send("{RIGHT}");
                }
                if (z.XAxis.Scale.Max > 20 && scroll_handler)
                {
                    double range = z.XAxis.Scale.Max - z.XAxis.Scale.Min;
                    z.XAxis.Scale.Max = t[0, i, ID] + 5;//+10 to be in the middle
                    z.XAxis.Scale.Min = z.XAxis.Scale.Max - range;
                    zedGraphControl1.ScrollMaxX = xvalue1;
                }

                if (ID > 3 || ID < 0)
                    return;
                if (ID == 0)
                    curve0.AddPoint(t[0, i, ID], t[1, i, ID]);
                if (ID == 1)
                    curve1.AddPoint(t[0, i, ID], t[1, i, ID]);
                if (ID == 2)
                    curve2.AddPoint(t[0, i, ID], t[1, i, ID]);
                if (ID == 3)
                    curve3.AddPoint(t[0, i, ID], t[1, i, ID]);



                zedGraphControl1.Refresh();
                zedGraphControl1.Invalidate();
            }
        }
        public void getCBstate(bool[] boolsFromForm1)
        {
            cb = boolsFromForm1;
        }
        public void getTimerInterval(int interval)
        {
            logger.Interval = interval;
        }
        public void running_state(bool x)
        {
            _running = x;
        }
    }
}
