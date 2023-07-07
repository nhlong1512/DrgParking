using LiveCharts;
using LiveCharts.Wpf;
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
using SeriesCollection = LiveCharts.SeriesCollection;

namespace RichParking.UserControls
{
    public partial class UC_Statistics : UserControl
    {
        RichParkingEntities db = new RichParkingEntities();
        public UC_Statistics()
        {
            InitializeComponent();
            revenueChart.Visible = false;
            QtyCarTypeChart.Visible = false;
            txtRevenue.Visible = false;
            txtQtyType.Visible = false;
            ShowChartRevenue();
        }

        #region methods
        public void ShowChartRevenue()
        {
            revenueChart.Series.Clear();
            var cars = db.Cars;
            var invoices = db.Invoices;
            List<int> revenueMonth = new List<int>();
            for (int i = 1; i <= 12; i++)
            {
                int revenue = 0;
                foreach (Invoice iv in invoices)
                {
                    DateTime createdDate = (DateTime)iv.CreatedDate;
                    int month = createdDate.Month;
                    if (month == i)
                    {
                        revenue += (int)iv.Price;
                    }
                }
                revenueMonth.Add(revenue);
                Console.WriteLine(revenue);
            }
            ChartValues<int> chartValues = new ChartValues<int>(revenueMonth);
            if (revenueChart.AxisX.Count == 0)
            {
                revenueChart.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Month",
                    Labels = new[] {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul",
                                "Aug","Sep", "Oct", "Nov", "Dec"}
                });

            }
            if (revenueChart.AxisY.Count == 0)
            {

                revenueChart.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Revenue by month in 2023",
                    //LabelFormatter = value => value.ToString("C")
                });
            }
            revenueChart.LegendLocation = LiveCharts.LegendLocation.Right;
            revenueChart.Series.Add(new LineSeries
            {
                Title = "2023",
                Values = chartValues
            });
            revenueChart.Width = 1100;
            revenueChart.Height = 360;
            txtQtyType.Visible = false;
            txtRevenue.Visible = true;
            QtyCarTypeChart.Visible = false;
            revenueChart.Visible = true;
        }

        public void ShowChartQtyCarType()
        {
            QtyCarTypeChart.Series.Clear();
            var cars = db.Cars;
            var invoices = db.Invoices;
            var qtyCar = 0;
            var qtyCar7Seater = 0;
            var qtyTruck = 0;
            foreach (var c in cars)
            {
                if (c.CarType == 1)
                {
                    qtyCar++;
                }
                else if (c.CarType == 2)
                {
                    qtyCar7Seater++;
                }
                else
                {
                    qtyTruck++;
                }
            }
            string[] labels = { "Car", "7 Seater Car", "Truck"};
            Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);


            LiveCharts.SeriesCollection sers = new SeriesCollection();
            sers.Add(new PieSeries() { Title = "Car", Values = new ChartValues<int> { qtyCar }, DataLabels = true, LabelPoint = labelPoint });
            sers.Add(new PieSeries() { Title = "7 Seater Car", Values = new ChartValues<int> { qtyCar7Seater }, DataLabels = true, LabelPoint = labelPoint });
            sers.Add(new PieSeries() { Title = "Truck", Values = new ChartValues<int> { qtyTruck }, DataLabels = true, LabelPoint = labelPoint });
            QtyCarTypeChart.Series = sers;
            QtyCarTypeChart.Width = 360;
            QtyCarTypeChart.Height = 360;
            txtRevenue.Visible = false;
            txtQtyType.Visible = true;
            revenueChart.Visible = false;
            QtyCarTypeChart.Visible = true;
            QtyCarTypeChart.LegendLocation = LegendLocation.Right;
        }

        #endregion

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            ShowChartRevenue();
        }

        private void btnQtyType_Click(object sender, EventArgs e)
        {
            ShowChartQtyCarType();

        }
    }
}
