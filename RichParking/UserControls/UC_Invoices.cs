using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichParking.UserControls
{
    public partial class UC_Invoices : UserControl
    {
        RichParkingEntities db = new RichParkingEntities();
        public UC_Invoices()
        {
            InitializeComponent();
            LoadData();
        }

        #region methods
        public void LoadData()
        {
            var result = from i in db.Invoices
                         where i.IsDeleted == false
                         join c in db.Cars on i.CarID equals c.CarID
                         select new
                         {
                             InvoiceID = i.InvoiceID,
                             CarType = c.CarType,
                             LicensePlate = c.LicensePlate,
                             InTime = c.InTime,
                             OutTime = c.OutTime,
                             IsWash = c.IsWash,
                             IsOilChange = c.IsOilChange,
                             Price = i.Price
                         };
            dtgvInvoice.DataSource = result.ToList();
            //AddBinding();
        }

        void LoadSearch(string txt)
        {
            var result = from i in db.Invoices
                         join c in db.Cars on i.CarID equals c.CarID into iGr
                         from ig in iGr
                         where i.IsDeleted == false &&
                            (
                                i.InvoiceID.Contains(txt)
                                || i.Price.ToString().Contains(txt)
                                || ig.LicensePlate.Contains(txt)
                                || ig.CarType.ToString().Contains(txt)
                                || ig.CarID.Contains(txt)
                            )
                         select new
                         {
                             InvoiceID = i.InvoiceID,
                             CarType = ig.CarType,
                             LicensePlate = ig.LicensePlate,
                             InTime = ig.InTime,
                             OutTime = ig.OutTime,
                             IsWash = ig.IsWash,
                             IsOilChange = ig.IsOilChange,
                             Price = i.Price
                         };
            dtgvInvoice.DataSource = result.ToList();
        }
        #endregion

        #region events
        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSearch(inputSearch.Text);
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            string carId;
            string invoiceId ="";
            if (dtgvInvoice.SelectedCells.Count > 0)
            {
                int rowIndex = dtgvInvoice.SelectedCells[0].RowIndex;
                Console.WriteLine("Row Index: " + rowIndex);
                DataGridViewRow selectedRow = dtgvInvoice.Rows[rowIndex];
                invoiceId = selectedRow.Cells["InvoiceID"].Value.ToString();
            }
            Invoice i = db.Invoices.Find(invoiceId);
            Car c = db.Cars.Find(i.CarID);
            InvoicePrint ip = new InvoicePrint(c, i);
            ip.ShowDialog();
        }

        #endregion
    }
}
