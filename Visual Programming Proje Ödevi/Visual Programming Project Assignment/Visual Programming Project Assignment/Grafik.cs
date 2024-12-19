using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Visual_Programming_Project_Assignment
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
            InitializeChart();
        }
        private void InitializeChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            Series bardakSeries = new Series("Bardak Seçimleri")
            {
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie
            };
            chart1.Series.Add(bardakSeries);
        }
        public void UpdateChart(int bardak1Count, int bardak2Count, int bardak3Count)
        {
            Series bardakSeries = chart1.Series["Bardak Seçimleri"];
            bardakSeries.Points.Clear();

            int total = bardak1Count + bardak2Count + bardak3Count;
            if (total > 0)
            {
                bardakSeries.Points.AddXY("Bardak 1", (double)bardak1Count / total * 100);
                bardakSeries.Points.AddXY("Bardak 2", (double)bardak2Count / total * 100);
                bardakSeries.Points.AddXY("Bardak 3", (double)bardak3Count / total * 100);
            }
            else
            {
                bardakSeries.Points.AddXY("Bardak 1", 0);
                bardakSeries.Points.AddXY("Bardak 2", 0);
                bardakSeries.Points.AddXY("Bardak 3", 0);
            }
        }
        private void Grafik_Load(object sender, EventArgs e)
        {

        }
    }
}




