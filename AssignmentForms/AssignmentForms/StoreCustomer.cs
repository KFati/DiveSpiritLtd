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
    public partial class StoreCustomer : Form
    {
        public StoreCustomer()
        {
            InitializeComponent();
        }

        

        private string sqlStr = "SELECT * FROM Customer";
        DataTable dt = new DataTable();
        private int inc;
        private void NavigateRecords()
        {
            txtCustomerId.Text = dt.Rows[inc]["CustomerId"].ToString();
            txtEmployeeId.Text = dt.Rows[inc]["EmployeeId"].ToString();
            txtFname.Text = dt.Rows[inc]["CustomerFname"].ToString();
            txtLname.Text = dt.Rows[inc]["CustomerLname"].ToString();
            txtgender.Text = dt.Rows[inc]["gender"].ToString();
            txtAddress.Text = dt.Rows[inc]["CustomerAddress"].ToString();
            txtMedical.Text = dt.Rows[inc]["MedicalStatement"].ToString();
            txtDiveNum.Text = dt.Rows[inc]["DiveInsuranceNum"].ToString();
            txtLevel.Text = dt.Rows[inc]["DiverLevel"].ToString();
            txtEmail.Text = dt.Rows[inc]["EmailAddress"].ToString();
            txtPhone.Text = dt.Rows[inc]["PhoneNum"].ToString();

        }

        private void StoreCustomer_Load(object sender, EventArgs e)
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

        private void BtnnextForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            StoreEmployee MyEmployee = new StoreEmployee();
            MyEmployee.Show();
        }
    }
}
