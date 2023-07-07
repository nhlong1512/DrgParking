using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichParking.UserControls
{
    public partial class UC_AddCar : UserControl
    {
        RichParkingEntities db = new RichParkingEntities();
        public UC_AddCar()
        {
            InitializeComponent();
            LoadData();
        }

        #region methods
        void AddBinding()
        {
            inputLicensePlate.DataBindings.Clear();
            inputLicensePlate.DataBindings.Add("Text", dtgvCar.DataSource, "LicensePlate");
        }

        void LoadData()
        {
            var result = from c in db.Cars
                         where c.IsDeleted == false
                         select new { CarID = c.CarID, CarType = c.CarType, LicensePlate = c.LicensePlate, InTime = c.InTime, OutTime = c.OutTime };
            dtgvCar.DataSource = result.ToList();
            AddBinding();
        }

        void LoadInvoice(string invoiceId)
        {
            Invoice i = db.Invoices.Find(invoiceId);
            MessageBox.Show("Total parking fee: " + i.Price + "$", "Parking fee", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void LoadSearch(string txt)
        {
            var result = from c in db.Cars
                         where c.IsDeleted == false &&
                            (
                                c.LicensePlate.Contains(txt)
                                || c.CarType.ToString().Contains(txt)
                                || c.CarID.Contains(txt)
                            )
                         select new
                         {
                             CarID = c.CarID,
                             CarType = c.CarType,
                             LicensePlate = c.LicensePlate,
                             InTime = c.InTime,
                             OutTime = c.OutTime
                         };
            dtgvCar.DataSource = result.ToList();
        }
        void AddData()
        {
            Guid id = Guid.NewGuid();
            try
            {
                db.Cars.Add(new Car()
                {
                    CarID = id.ToString(),
                    CarType = rbtnCar.Checked ? 1 : (rbtnCar7.Checked ? 2 : 3),
                    IsWash = ckBoxWash.Checked ? true : false,
                    IsOilChange = ckBoxOilChange.Checked ? true : false,
                    LicensePlate = inputLicensePlate.Text,
                    InTime = DateTime.Now,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                });
                db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationError in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationError.ValidationErrors)
                    {
                        Console.WriteLine($"Error validation: {validationError.PropertyName} - {validationError.ErrorMessage}");
                    }
                }
            }
            LoadData();
        }

        string AddInvoice(string carId)
        {
            //Caculate hours
            Car car = db.Cars.Find(carId);
            TimeSpan timeParking = (TimeSpan)(car.OutTime - car.InTime);
            //soGio = GioRa - GioVao + 1;
            double hours = timeParking.TotalHours + 1;
            Console.WriteLine("Total hours: " + hours);
            //Caclute Price of Bill
            int price;
            int days = (int)Math.Ceiling((double)hours / 24);

            if (car.CarType == 1)
            {
                price = days * 5;
            }
            else if (car.CarType == 2)
            {
                price = days * 7;
            }
            else
            {
                price = days * 9;
            }

            //Check Services Wash Car is 10$ and Oil Change: 50$
            if ((bool)car.IsWash)
            {
                price += 10;
            }
            if ((bool)car.IsOilChange)
            {
                price += 50;
            }

            Guid id = Guid.NewGuid();
            try
            {
                db.Invoices.Add(new Invoice()
                {
                    InvoiceID = id.ToString(),
                    Price = price,
                    CarID = carId,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,

                });
                db.SaveChanges();

            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationError in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationError.ValidationErrors)
                    {
                        Console.WriteLine($"Error Validation: {validationError.PropertyName} - {validationError.ErrorMessage}");
                    }
                }
            }
            return id.ToString();
        }

        void DeleteCar(string carId)
        {
            Car car = db.Cars.Find(carId);
            car.IsDeleted = true;
            db.SaveChanges();
            LoadData();
        }


        #endregion

        #region events

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddData();
        }


        private void dtgvCar_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvCar.SelectedCells.Count > 0)
            {
                int rowIndex = dtgvCar.SelectedCells[0].RowIndex;
                Console.WriteLine("Row Index: " + rowIndex);
                DataGridViewRow selectedRow = dtgvCar.Rows[rowIndex];
                string carId = selectedRow.Cells["CarID"].Value.ToString();
                Car car = db.Cars.Find(carId);
                int carType = (int)car.CarType;
                Console.WriteLine("Car Type: " + car.CarType);
                // Check if radio button car type is checked
                rbtnCar.Checked = (carType == 1);
                rbtnCar7.Checked = (carType == 2);
                rbtnVan.Checked = (carType == 3);
                bool isWash = (bool)car.IsWash;
                bool isOilChange = (bool)car.IsOilChange;
                ckBoxWash.Checked = isWash;
                ckBoxOilChange.Checked = isOilChange;
            }
            AddBinding();
        }

        private void btnCarOut_Click(object sender, EventArgs e)
        {
            if (dtgvCar.SelectedCells.Count > 0)
            {
                int rowIndex = dtgvCar.SelectedCells[0].RowIndex;
                Console.WriteLine("Row Index: " + rowIndex);
                DataGridViewRow selectedRow = dtgvCar.Rows[rowIndex];
                string carId = selectedRow.Cells["CarID"].Value.ToString();
                string licensePlate = selectedRow.Cells["LicensePlate"].Value.ToString();
                Console.WriteLine("Car: " + carId);
                Console.WriteLine("License Plate: " + licensePlate);
                Car car = db.Cars.Find(carId);
                car.OutTime = DateTime.Now;
                db.SaveChanges();
                LoadData();
                //Add Bill 
                string invoiceId = AddInvoice(carId);
                LoadInvoice(invoiceId);
                DeleteCar(carId);
            }

        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSearch(inputSearch.Text);
        }


        #endregion
    }
}
