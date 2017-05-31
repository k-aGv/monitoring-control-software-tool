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
        bool _running;
        bool[] cb;
        double[] values;

        // <graph stuff>
        GraphPane z;
        BarItem bar0, bar1, bar2, bar3;
        double[] init = new double[1];
        double[] zero = new double[1];
        bool init_Curves = true;
        
        double[,] varsX = new double[1, 4];
        double[,] varsY = new double[1, 4];
        int[] countX = new int[4];
        int[] countY = new int[4];
        //xy , values, ID
        double[, ,] t = new double[2, 50, 4];
        // </graph stuff>

        public void initCurves()
        {
            zero[0] = 1;
            init[0] = values[0];
            bar0 = zedGraphControl1.GraphPane.AddBar("Sensor 1", zero, init, Color.Green);

            zero[0] = 2;
            init[0] = values[1];
            bar1 = zedGraphControl1.GraphPane.AddBar("Sensor 2", zero, init, Color.Red);

            zero[0] = 3;
            init[0] = values[2];
            bar2 = zedGraphControl1.GraphPane.AddBar("Sensor 3", zero, init, Color.Black);

            zero[0] = 4;
            init[0] = values[3];
            bar3 = zedGraphControl1.GraphPane.AddBar("Sensor 4", zero, init, Color.Blue);

        }
        public void drawNextSpot_curve(int ID)
        {

            if (init_Curves)
            {
                initCurves();
                init_Curves = false;
            }
            else
            {
                if (ID > 3 || ID < 0)
                    return;
                if (ID == 0)
                    bar0.AddPoint(1, values[0]);
                if (ID == 1)
                    bar1.AddPoint(2, values[1]);
                if (ID == 2)
                    bar2.AddPoint(3, values[2]);
                if (ID == 3)
                    bar3.AddPoint(4, values[3]);




                //zedGraphControl1.AxisChange();
                zedGraphControl1.Refresh();
                zedGraphControl1.Invalidate();
            }
        }
        public void getTimerInterval(int interval)
        {
            realtime_timer.Interval = interval;
        }
        public void running_state(bool x)
        {
            _running = x;
        }
        public void getValues(double[] varsFromForm1)
        {
            values = varsFromForm1;
            //MessageBox.Show(values[0] + "\r\n" + values[1] + "\r\n" + values[2] + "\r\n" + values[3]);
        }
        public void getCBstate(bool[] boolsFromForm1)
        {
            cb = boolsFromForm1;
        }
    }
}
