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
using ZedGraph;

namespace Elaiotriveio
{
    public partial class saved_logs_display : Form
    {
        public saved_logs_display()
        {
            InitializeComponent();
        }

        private void saved_logs_display_Load(object sender, EventArgs e)
        {

            zedGraphControl1.IsShowPointValues = true; 
            zedGraphControl1.IsShowHScrollBar = true;
            zedGraphControl1.IsShowVScrollBar = true;

            z.XAxis.Title.Text = "Samples";
            z.YAxis.Title.Text = "Temperature";
            z.Title.Text = "Values history graph";

            //X-Y axis values range
            z.XAxis.Scale.Max = 20; 
            //z.YAxis.Scale.Max = 40; 
            z.YAxis.Scale.MaxAuto = true;
            z.YAxis.Scale.MinAuto = true;

            //has to do with background GRID
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

            
            
            zedGraphControl1.IsAntiAlias = true; //improves graphics

            z.AxisChange(); //graph "update"
        }

        private void saved_logs_display_FormClosing(object sender, FormClosingEventArgs e)
        {
            search_timer.Stop();
            this.Dispose();
        }
        
        private string zedGraphControl1_PointValueEvent(ZedGraphControl sender, GraphPane pane, CurveItem curve, int iPt)
        {
            lineName=curve.Label.Text;
            pnts[0] = Convert.ToString(curve[iPt].X);
            pnts[1] = Convert.ToString(curve[iPt].Y);
            search();
            return default(string);
        } 
    }
}
