using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Collections.Generic;

namespace BinaryTree
{
    class Program
    {
        static Random random = new Random();

        static int[] GenerateArray(int length)
        {
            var array = new int[length];
            for (int i = 1; i < array.Length; i++)
                array[i] = array[i - 1] + random.Next(10000) + 1;
            return array;
        }

        static LinkedList<int> GenerateLinkedList(int length)
        {
            var linked = new LinkedList<int>();
            linked.AddLast(random.Next(10000) + 1);
            for (int i = 1; i < length; i++)
            {
                linked.AddLast(linked.Last.Value + random.Next(10000) + 1);
            }
            return linked;
        }

        static void MeasureTime(int[] array, Series series)
        {
            var tree = new Tree();
            var watch = new Stopwatch();
            watch.Start();
            foreach (var item in array)
                tree.Add(item);
            tree.Sort(null);
            watch.Stop();
            series.Points.Add(new DataPoint(array.Length, tree.Iterations));
        }

        static void MeasureTime(LinkedList<int> linked, Series series)
        {
            var tree = new Tree();
            var watch = new Stopwatch();
            watch.Start();
            foreach (var item in linked)
                tree.Add(item);
            tree.Sort(null);
            watch.Stop();
            series.Points.Add(new DataPoint(linked.Count, tree.Iterations));
        }

        private static Chart MakeChart(Series array, Series linked)
        {
            var chart = new Chart();
            chart.ChartAreas.Add(new ChartArea());
            
            array.ChartType = SeriesChartType.FastLine;
            array.Color = Color.Red;

            linked.ChartType = SeriesChartType.FastLine;
            linked.Color = Color.Blue;

            chart.Series.Add(array);
            chart.Series.Add(linked);
            chart.Dock = DockStyle.Fill;
            return chart;
        }
        
        static void Main()
        {
            var array = new Series();
            var linked = new Series();

            Random random = new Random();
            Stopwatch watch = new Stopwatch();

            for (int i = 100; i < 10000; i += 100)
            {
                GC.Collect();
                var aarraayy = GenerateArray(i);
                var lliinnkkeedd = GenerateLinkedList(i);
                MeasureTime(aarraayy, array);
                MeasureTime(lliinnkkeedd, linked);
            }

            var chart = MakeChart(array, linked);
            var form = new Form();
            form.ClientSize = new Size(1400, 800);
            form.Controls.Add(chart);
            Application.Run(form);
        }
    }
}