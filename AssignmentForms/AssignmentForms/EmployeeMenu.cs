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
    public partial class EmployeeMenu : Form
    {
        public EmployeeMenu()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertCustomer insertCustomer = new InsertCustomer();
            insertCustomer.Show();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerBooking customerBooking = new CustomerBooking();
            customerBooking.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryEmployees inventoryEmployees= new InventoryEmployees();
            inventoryEmployees.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerPayment customerPayment= new CustomerPayment();
            customerPayment.Show();
        }
    }
}
