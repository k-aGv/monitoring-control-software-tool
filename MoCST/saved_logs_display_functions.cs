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
        int i;
        int pick_index;
        int comp_pick_index;
        string file;
        bool[] sensors1_cb = new bool[4];
        bool[] sensors2_cb = new bool[4];
        bool[] sensors3_cb = new bool[4];
        bool[] sensors4_cb = new bool[4];

        string[] sensors1 = new string[4];
        string[] sensors2 = new string[4];
        string[] sensors3 = new string[4];
        string[] sensors4 = new string[4];

        int[] maxValues = new int[4];

        //graph stuff
        GraphPane z;
        CurveItem curve0, curve1, curve2, curve3;
        double[] init = new double[1];
        double[] zero = new double[1];
        public bool init_Curves = true;
        string index;
        double[] init_value = new double[4];
        int init_reader_counter = 0;
        string[] pnts = new string[2];
        string lineName;

        /*
        private void search_timer_Tick(object sender, EventArgs e)
        {
            string cmp_item;
            if (pnts[0] != "" && pnts[1] != "")
            {
                for (int i = 0; i < logs_LB.Items.Count; i++)
                {
                    cmp_item = Convert.ToString(logs_LB.Items[i]);
                    if (cmp_item.Contains(
                        "Sample "+pnts[0]+
                        "      "+lineName+"   " +
                        "   Temperature  =  " + pnts[1]))
                    {
                        logs_LB.SelectedItem = logs_LB.Items[i];
                    }
                }
            }
            else
            {
                //label1.Text = "null";
            }
            
            search_timer.Stop();
          
        }
        */
        void initCurves()
        {
            zero[0] = Convert.ToDouble(index);

            init[0] = init_value[0];
            curve0 = zedGraphControl1.GraphPane.AddCurve("Sensor 1", zero, init, Color.Transparent);

            init[0] = init_value[1];
            curve1 = zedGraphControl1.GraphPane.AddCurve("Sensor 2", zero, init, Color.Transparent);

            init[0] = init_value[2];
            curve2 = zedGraphControl1.GraphPane.AddCurve("Sensor 3", zero, init, Color.Transparent);

            init[0] = init_value[3];
            curve3 = zedGraphControl1.GraphPane.AddCurve("Sensor 4", zero, init, Color.Transparent);

            curve0.Label.IsVisible = false;
            curve1.Label.IsVisible = false;
            curve2.Label.IsVisible = false;
            curve3.Label.IsVisible = false;

        } //creates the curves as objects
        public void search()
        {
            string cmp_item;
            if (pnts[0] != "" && pnts[1] != "")
            {
                for (int i = 0; i < logs_LB.Items.Count; i++)
                {
                    cmp_item = Convert.ToString(logs_LB.Items[i]);
                    if (cmp_item.Contains(
                        "Sample " + pnts[0] +
                        "      " + lineName + "   " +
                        "   Temperature  =  " + pnts[1]))
                    {
                        logs_LB.SelectedItem = logs_LB.Items[i];
                    }
                }
            }
            else
            {
                //label1.Text = "null";
            }

        }
        public void charts_display(int sensorindex)
        {
            i = 1;
            //<curves' values initialization> - pulls the 1st set of values from the xml
            XmlReader init_reader = XmlReader.Create(file);
            while (init_reader.Read())
            {
                if (init_reader.IsStartElement())
                {
                    if (i == 1)
                        init_reader.Read();
                    if (init_reader.IsStartElement())
                    {
                        init_reader.Read();
                        while (init_reader.IsStartElement())
                        {
                            if (init_reader.Name.Contains("Sensor") && init_reader_counter < 4)
                            {
                                init_value[init_reader_counter] = Convert.ToDouble(init_reader.GetAttribute(0));
                                init_reader.Read();
                                init_reader_counter++;
                            }
                            else
                                break;
                            init_reader.Read();
                        }
                    }
                }
            }
            init_reader.Close();
            //</curves' values initialization>


            //2 core functions here:
            //a) reads the xml and places each value on the graph
            //b) simultaneously fills the listbox on the right of the graph
            i = 1;
            XmlReader reader = XmlReader.Create(file);
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (i == 1)
                        reader.Read();
                    if (reader.IsStartElement())
                    {
                        index = reader.Name.Remove(0, 6);
                        reader.Read();
                        while (reader.IsStartElement())
                        {
                            // Horizontal Comparison //
                            //                       //
                            if (pick_index == 1)
                            {
                                if (sensors1_cb[0])
                                    if (reader.Name == "Sensor1")
                                    {
                                        //chart_counter++;
                                        drawNextSpot_curve(0, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve0.Label.IsVisible = true;
                                        curve0.Color = Color.Green;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 1   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                                if (sensors1_cb[1])
                                    if (reader.Name == "Sensor2")
                                    {
                                        //chart_counter++;
                                        drawNextSpot_curve(1, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve1.Label.IsVisible = true;
                                        curve1.Color = Color.Red;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 2   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                                if (sensors1_cb[2])
                                    if (reader.Name == "Sensor3")
                                    {

                                        //chart_counter++;
                                        drawNextSpot_curve(2, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve2.Label.IsVisible = true;
                                        curve2.Color = Color.Black;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 3   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                                if (sensors1_cb[3])
                                    if (reader.Name == "Sensor4")
                                    {

                                        //chart_counter++;
                                        drawNextSpot_curve(3, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve3.Label.IsVisible = true;
                                        curve3.Color = Color.Blue;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 4   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                            }
                            else if (pick_index == 2)
                            {
                                if (sensors2_cb[0])
                                    if (reader.Name == "Sensor1")
                                    {
                                        //chart_counter++;
                                        //drawNextSpot_curve(0, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                        drawNextSpot_curve(0, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve0.Label.IsVisible = true;
                                        curve0.Color = Color.Green;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 1   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                                if (sensors2_cb[1])
                                    if (reader.Name == "Sensor2")
                                    {
                                        //chart_counter++;
                                        //drawNextSpot_curve(1, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                        drawNextSpot_curve(1, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve1.Label.IsVisible = true;
                                        curve1.Color = Color.Red;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 2   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                                if (sensors2_cb[2])
                                    if (reader.Name == "Sensor3")
                                    {
                                        //chart_counter++;
                                        //drawNextSpot_curve(2, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                        drawNextSpot_curve(2, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve2.Label.IsVisible = true;
                                        curve2.Color = Color.Black;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 3   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                                if (sensors2_cb[3])
                                    if (reader.Name == "Sensor4")
                                    {
                                        //chart_counter++;
                                        //drawNextSpot_curve(3, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                        drawNextSpot_curve(3, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve3.Label.IsVisible = true;
                                        curve3.Color = Color.Blue;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 4   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                            }
                            else if (pick_index == 3)
                            {
                                if (sensors3_cb[0])
                                    if (reader.Name == "Sensor1")
                                    {
                                        //chart_counter++;
                                        //drawNextSpot_curve(0, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                        drawNextSpot_curve(0, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve0.Label.IsVisible = true;
                                        curve0.Color = Color.Green;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 1   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                                if (sensors3_cb[1])
                                    if (reader.Name == "Sensor2")
                                    {
                                        //chart_counter++;
                                        //drawNextSpot_curve(1, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                        drawNextSpot_curve(1, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve1.Label.IsVisible = true;
                                        curve1.Color = Color.Red;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 2   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                                if (sensors3_cb[2])
                                    if (reader.Name == "Sensor3")
                                    {
                                        //chart_counter++;
                                        //drawNextSpot_curve(2, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                        drawNextSpot_curve(2, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve2.Label.IsVisible = true;
                                        curve2.Color = Color.Black;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 3   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                                if (sensors3_cb[3])
                                    if (reader.Name == "Sensor4")
                                    {
                                        //chart_counter++;
                                        //drawNextSpot_curve(3, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                        drawNextSpot_curve(3, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve3.Label.IsVisible = true;
                                        curve3.Color = Color.Blue;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 4   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                            }
                            else if (pick_index == 4)
                            {
                                if (sensors4_cb[0])
                                    if (reader.Name == "Sensor1")
                                    {
                                        //chart_counter++;
                                        //drawNextSpot_curve(0, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                        drawNextSpot_curve(0, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve0.Label.IsVisible = true;
                                        curve0.Color = Color.Green;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 1   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                                if (sensors4_cb[1])
                                    if (reader.Name == "Sensor2")
                                    {
                                        //chart_counter++;
                                        //drawNextSpot_curve(1, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                        drawNextSpot_curve(1, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve1.Label.IsVisible = true;
                                        curve1.Color = Color.Red;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 2   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                                if (sensors4_cb[2])
                                    if (reader.Name == "Sensor3")
                                    {
                                        //chart_counter++;
                                        //drawNextSpot_curve(2, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                        drawNextSpot_curve(2, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve2.Label.IsVisible = true;
                                        curve2.Color = Color.Black;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 3   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                                if (sensors4_cb[3])
                                    if (reader.Name == "Sensor4")
                                    {
                                        //chart_counter++;
                                        //drawNextSpot_curve(3, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                        drawNextSpot_curve(3, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                        curve3.Label.IsVisible = true;
                                        curve3.Color = Color.Blue;
                                        logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      Sensor 4   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                    }
                            }
                            //                     //
                            // Vertical Comparison //
                            else if (pick_index == 21)
                            {
                                if (comp_pick_index == 1)
                                    if (sensors1_cb[0])
                                        if (reader.Name == "Sensor1")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(0, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(0, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve0.Label.IsVisible = true;
                                            curve0.Color = Color.Green;
                                            curve0.Label.Text = "File 1: sensor 1";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 1: sensor 1   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                                if (comp_pick_index == 2)
                                    if (sensors2_cb[0])
                                        if (reader.Name == "Sensor1")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(1, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(1, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve1.Label.IsVisible = true;
                                            curve1.Color = Color.Red;
                                            curve1.Label.Text = "File 2: sensor 1";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 2: sensor 1   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                                if (comp_pick_index == 3)
                                    if (sensors3_cb[0])
                                        if (reader.Name == "Sensor1")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(2, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(2, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve2.Label.IsVisible = true;
                                            curve2.Color = Color.Black;
                                            curve2.Label.Text = "File 3: sensor 1";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 3: sensor 1   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                                if (comp_pick_index == 4)
                                    if (sensors4_cb[0])
                                        if (reader.Name == "Sensor1")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(3, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(3, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve3.Label.IsVisible = true;
                                            curve3.Color = Color.Blue;
                                            curve3.Label.Text = "File 4: sensor 1";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 4: sensor 1   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                            }
                            else if (pick_index == 22)
                            {
                                if (comp_pick_index == 1)
                                    if (sensors1_cb[1])
                                        if (reader.Name == "Sensor2")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(0, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(0, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve0.Label.IsVisible = true;
                                            curve0.Color = Color.Green;
                                            curve0.Label.Text = "File 1: sensor 2";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 1: sensor 2   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                                if (comp_pick_index == 2)
                                    if (sensors2_cb[1])
                                        if (reader.Name == "Sensor2")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(1, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(1, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve1.Label.IsVisible = true;
                                            curve1.Color = Color.Red;
                                            curve1.Label.Text = "File 2: sensor 2";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 2: sensor 2   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                                if (comp_pick_index == 3)
                                    if (sensors3_cb[1])
                                        if (reader.Name == "Sensor2")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(2, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(2, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve2.Label.IsVisible = true;
                                            curve2.Color = Color.Black;
                                            curve2.Label.Text = "File 3: sensor 2";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 3: sensor 2   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                                if (comp_pick_index == 4)
                                    if (sensors4_cb[1])
                                        if (reader.Name == "Sensor2")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(3, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(3, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve3.Label.IsVisible = true;
                                            curve3.Color = Color.Blue;
                                            curve3.Label.Text = "File 4: sensor 2";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 4: sensor 2   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                            }
                            else if (pick_index == 23)
                            {
                                if (comp_pick_index == 1)
                                    if (sensors1_cb[2])
                                        if (reader.Name == "Sensor3")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(0, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(0, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve0.Label.IsVisible = true;
                                            curve0.Color = Color.Green;
                                            curve0.Label.Text = "File 1: sensor 3";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 1: sensor 3   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                                if (comp_pick_index == 2)
                                    if (sensors2_cb[2])
                                        if (reader.Name == "Sensor3")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(1, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(1, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve1.Label.IsVisible = true;
                                            curve1.Color = Color.Red;
                                            curve1.Label.Text = "File 2: sensor 3";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 2: sensor 3   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                                if (comp_pick_index == 3)
                                    if (sensors3_cb[2])
                                        if (reader.Name == "Sensor3")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(2, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(2, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve2.Label.IsVisible = true;
                                            curve2.Color = Color.Black;
                                            curve2.Label.Text = "File 3: sensor 3";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 3: sensor 3   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                                if (comp_pick_index == 4)
                                    if (sensors4_cb[2])
                                        if (reader.Name == "Sensor3")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(3, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(3, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve3.Label.IsVisible = true;
                                            curve3.Color = Color.Blue;
                                            curve3.Label.Text = "File 4: sensor 3";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 4: sensor 3   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                            }
                            else if (pick_index == 24)
                            {
                                if (comp_pick_index == 1)
                                    if (sensors1_cb[3])
                                        if (reader.Name == "Sensor4")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(0, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(0, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve0.Label.IsVisible = true;
                                            curve0.Color = Color.Green;
                                            curve0.Label.Text = "File 1: sensor 4";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 1: sensor 4   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                                if (comp_pick_index == 2)
                                    if (sensors2_cb[3])
                                        if (reader.Name == "Sensor4")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(1, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(1, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve1.Label.IsVisible = true;
                                            curve1.Color = Color.Red;
                                            curve1.Label.Text = "File 2: sensor 4";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 2: sensor 4   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                                if (comp_pick_index == 3)
                                    if (sensors3_cb[3])
                                        if (reader.Name == "Sensor4")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(2, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(2, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve2.Label.IsVisible = true;
                                            curve2.Color = Color.Black;
                                            curve2.Label.Text = "File 3: sensor 4";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 3: sensor 4   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                                if (comp_pick_index == 4)
                                    if (sensors4_cb[3])
                                        if (reader.Name == "Sensor4")
                                        {
                                            //chart_counter++;
                                            //drawNextSpot_curve(3, Convert.ToInt32(reader.GetAttribute(0)), chart_counter);
                                            drawNextSpot_curve(3, Convert.ToDouble(reader.GetAttribute(0)), Convert.ToInt16(index));
                                            curve3.Label.IsVisible = true;
                                            curve3.Color = Color.Blue;
                                            curve3.Label.Text = "File 4: sensor 4";
                                            logs_LB.Items.Add(
                                            "Sample " + index +
                                            "      File 4: sensor 4   " +
                                            "   Temperature  =  " + reader.GetAttribute(0) +
                                            "   Time  =  " + reader.GetAttribute(1));
                                        }
                            }
                            reader.Read();
                        }
                        if (pick_index > 0 && pick_index < 5)
                            logs_LB.Items.Add("\r\n");
                    }
                }

                i++;
            }
            if (sensorindex == -1)
                zedGraphControl1.ScrollMaxX = i;
            else
            {
                maxValues[sensorindex - 1] = i;
                zedGraphControl1.ScrollMaxX = maxValues.Max();
            }
            if (comp_pick_index > 0 && comp_pick_index < 5)
                logs_LB.Items.Add("\r\n");
            reader.Close();

            z.AxisChange();
        }
        public void drawNextSpot_curve(int ID, double value, int chart_counter)
        {
            if (init_Curves) //curves initialization
            {
                initCurves();

                z = zedGraphControl1.GraphPane;

                zedGraphControl1.IsShowHScrollBar = true;
                init_Curves = false;
            }
            else //adds next values to the existing curves
            {
                if (ID > 3 || ID < 0)
                    return;
                if (ID == 0)
                    curve0.AddPoint(chart_counter, value);
                if (ID == 1)
                    curve1.AddPoint(chart_counter, value);
                if (ID == 2)
                    curve2.AddPoint(chart_counter, value);
                if (ID == 3)
                    curve3.AddPoint(chart_counter, value);

                zedGraphControl1.Refresh();
                zedGraphControl1.Invalidate();
            }
        }
        public void transfer_data(int index, bool[] checkbox_bools, string filename, int comp_index)
        {
            file = filename;

            if (index == 1)
            {
                sensors1_cb = checkbox_bools;
                pick_index = index;
            }
            if (index == 2)
            {
                sensors2_cb = checkbox_bools;
                pick_index = index;
            }
            if (index == 3)
            {
                sensors3_cb = checkbox_bools;
                pick_index = index;
            }
            if (index == 4)
            {
                sensors4_cb = checkbox_bools;
                pick_index = index;
            }
            if (index == 21)
            {
                if (comp_index == 1)
                {
                    sensors1_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                if (comp_index == 2)
                {
                    sensors2_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                if (comp_index == 3)
                {
                    sensors3_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                if (comp_index == 4)
                {
                    sensors4_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                pick_index = index;
            }
            if (index == 22)
            {
                if (comp_index == 1)
                {
                    sensors1_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                if (comp_index == 2)
                {
                    sensors2_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                if (comp_index == 3)
                {
                    sensors3_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                if (comp_index == 4)
                {
                    sensors4_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                pick_index = index;
            }
            if (index == 23)
            {
                if (comp_index == 1)
                {
                    sensors1_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                if (comp_index == 2)
                {
                    sensors2_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                if (comp_index == 3)
                {
                    sensors3_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                if (comp_index == 4)
                {
                    sensors4_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                pick_index = index;
            }
            if (index == 24)
            {
                if (comp_index == 1)
                {
                    sensors1_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                if (comp_index == 2)
                {
                    sensors2_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                if (comp_index == 3)
                {
                    sensors3_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                if (comp_index == 4)
                {
                    sensors4_cb = checkbox_bools;
                    comp_pick_index = comp_index;
                }
                pick_index = index;
            }
        }
    }
}
