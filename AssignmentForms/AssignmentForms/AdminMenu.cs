using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentForms
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            StoreCustomer MyCustomer = new StoreCustomer();
            MyCustomer.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            StoreEmployee MyEmployee= new StoreEmployee();
            MyEmployee.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryAdmin myinventoryAdmin = new InventoryAdmin();
            myinventoryAdmin.Show();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPayroll MyPayroll= new AdminPayroll();
            MyPayroll.Show();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingDetails MyBooking = new BookingDetails();
            MyBooking.Show();
        }
    }
}
