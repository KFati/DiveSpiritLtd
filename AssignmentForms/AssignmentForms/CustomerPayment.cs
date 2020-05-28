using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace AssignmentForms
{
    public partial class CustomerPayment : Form
    {
        public CustomerPayment()
        {
            InitializeComponent();
        }

        private string sqlStr = "SELECT * FROM [Payment]";
        DataTable dt = new DataTable();

        decimal total;

        string paymentMethod;
        string bookingid;

        private void CustomerPayment_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Connection.conn);
            sda.Fill(dt);
            sda.Dispose();
            
            txtCustomerId.Text = InsertCustomer.customerId.ToString();
            txtEmployeeId.Text = InsertCustomer.employeeId.ToString();
            txtNoOfDives.Text = CustomerBooking.NumberOfDive;
            txtDivePrice.Text = CustomerBooking.divePriceFinal;
            txtCoursePrice.Text = CustomerBooking.coursePriceFinal;
            txtProductPrice.Text = InventoryEmployees.totalInventory;
            bookingid = CustomerBooking.newbookingid;
            total = InventoryEmployees.inventoryFinal;
            lblDate.Text = DateTime.Now.ToString("dd MMMM,yyyy");
            txtTotal.Text = total.ToString();

            //load data on receipt
            lblAccountNo.Text = txtAccountNo.Text;
            lblCustomerID.Text = txtCustomerId.Text;
            lblEmployeeID.Text = txtEmployeeId.Text;
            lblDivePrice.Text = txtDivePrice.Text;
            lblCoursePrice.Text = txtCoursePrice.Text;
            lblProductPrice.Text = txtProductPrice.Text;
            lblTotal.Text = txtTotal.Text;
        }

        private void txtAccountNo_TextChanged(object sender, EventArgs e)
        {
            lblAccountNo.Text = txtAccountNo.Text;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (radCreditCard.Checked)
            {
                paymentMethod = "Credit Card";
                if (MessageBox.Show("Print Receipt", "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    PrintDocument doc = new PrintDocument();
                    doc.PrintPage += this.Doc_PrintPage;
                    PrintDialog dlgSettings = new PrintDialog();
                    dlgSettings.Document = doc;
                    if (dlgSettings.ShowDialog() == DialogResult.OK)
                    {
                        doc.Print();
                    }
                }
            }

            else if (radMCBJuice.Checked)
            {
                paymentMethod = "MCB Juice";
                MessageBox.Show("101030300200000", "Diving Centre’s Account Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (radCash.Checked)
            {
                paymentMethod = "Cash";
                if (MessageBox.Show("Print Receipt", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    PrintDocument doc = new PrintDocument();
                    doc.PrintPage += this.Doc_PrintPage;
                    PrintDialog dlgSettings = new PrintDialog();
                    dlgSettings.Document = doc;
                    if (dlgSettings.ShowDialog() == DialogResult.OK)
                    {
                        doc.Print();
                    }
                }
            }

            DataRow newRow = dt.NewRow();
            newRow["AccountNumber"] = txtAccountNo.Text;
            newRow["BookingId"] = bookingid;
            newRow["CustomerId"] = txtCustomerId.Text;
            newRow["EmployeeId"] = txtEmployeeId.Text;

            try
            {
                newRow["NumberOfDives"] = txtNoOfDives.Text;
            }
            catch
            {
                txtNoOfDives.Text = "0";
                newRow["NumberOfDives"] = txtNoOfDives.Text;
            }

            newRow["DivePrice"] = txtDivePrice.Text;
            newRow["CoursePrice"] = txtCoursePrice.Text;
            newRow["ProductPrice"] = txtProductPrice.Text;
            newRow["PaymentMethod"] = paymentMethod;
            newRow["TotalAmount"] = txtTotal.Text;

            dt.Rows.Add(newRow);
            Save();

            if (MessageBox.Show("Do you want to exit the application?", "Transaction Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Save()
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Connection.conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            sda.Dispose();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(this.groupBox1.Width, this.groupBox1.Height);
            this.groupBox1.DrawToBitmap(bmp, new Rectangle(0, 0, this.groupBox1.Width, this.groupBox1.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeMenu myEmployee = new EmployeeMenu();
            myEmployee.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    
}
