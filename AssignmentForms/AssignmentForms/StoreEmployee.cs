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

namespace AssignmentForms
{
    public partial class StoreEmployee : Form
    {
        public StoreEmployee()
        {
            InitializeComponent();
        }

       
        private string sqlStr = "SELECT * FROM Employee";
        DataTable dt = new DataTable();
        private int inc;
        private void NavigateRecords()
        {
            txtEmployeeId.Text = dt.Rows[inc]["EmployeeId"].ToString();
            txtEmpFname.Text = dt.Rows[inc]["EmpFname"].ToString();
            txtEmpLname.Text = dt.Rows[inc]["EmpLname"].ToString();
            txtEmpAddress.Text = dt.Rows[inc]["EmpAddress"].ToString();
            txtSex.Text = dt.Rows[inc]["gender"].ToString();
            txtPosition.Text = dt.Rows[inc]["position"].ToString();

        }
        

        private void StoreEmployee_Load(object sender, EventArgs e)
        {
            Connection newconnection = new Connection();
            newconnection.GetConnection();

            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Connection.conn);
            sda.Fill(dt);
            sda.Dispose();
            NavigateRecords();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            inc = 0;
            NavigateRecords();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (inc > 0)
                inc--;
            NavigateRecords();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (inc < dt.Rows.Count - 1)
                inc++;
            NavigateRecords();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            inc = dt.Rows.Count - 1;
            NavigateRecords();
        }

        

        private void btnPreviousForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            StoreCustomer MyCustStore = new StoreCustomer();
            MyCustStore.Show();
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingDetails MyBooking = new BookingDetails();
            MyBooking.Show();
        }
    }
}
