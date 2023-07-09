using Guna.UI2.WinForms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            uC_AddCar1.Visible = true;
            uC_Invoices1.Visible = false;
            uC_Statistics1.Visible = false;
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 118, b.Location.Y - 30);
            imgSlide.SendToBack();
        }
        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_AddCar1.Visible = true;
            uC_Invoices1.Visible = false;
            uC_Statistics1.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_AddCar1.Visible = false;
            uC_Invoices1.Visible = true;
            uC_Statistics1.Visible = false;
            uC_Invoices1.LoadData();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_AddCar1.Visible = false;
            uC_Invoices1.Visible = false;
            uC_Statistics1.Visible = true;
        }
    }
}
