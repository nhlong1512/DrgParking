using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichParking
{
    public partial class InvoicePrint : Form
    {
        Car car;
        Invoice invoice;
        public InvoicePrint(Car car, Invoice invoice)
        {
            InitializeComponent();
            this.car = car;
            this.invoice = invoice;
            Console.WriteLine("Car", car);
            Console.WriteLine("Invoice", invoice);
        }

        private void InvoicePrint_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pLicensePlate", car.LicensePlate),
                new Microsoft.Reporting.WinForms.ReportParameter("pCarType", car.CarType == 1 ? "Car": (car.CarType == 2 ? "7 Seater car" : "Truck")),
                new Microsoft.Reporting.WinForms.ReportParameter("pInTime", car.InTime.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pOutTime", car.OutTime.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pIsWash", car.IsWash == true ? "Yes" : "No"),
                new Microsoft.Reporting.WinForms.ReportParameter("pIsOilChange", car.IsOilChange == true ? "Yes" : "No"),
                new Microsoft.Reporting.WinForms.ReportParameter("pInvoiceID", invoice.InvoiceID.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pPrice", invoice.Price.ToString() + " $"),

            };
            if (p != null)
            {
                this.reportViewer1.LocalReport.SetParameters(p);
            }
            this.reportViewer1.RefreshReport();

        }
    }
}
