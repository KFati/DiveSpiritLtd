using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AssignmentForms
{
    public partial class AddUserCon : UserControl
    {
        public AddUserCon()
        {
            InitializeComponent();
        }

        private void btnCalcSalary_Click(object sender, EventArgs e)
        {
            //exception for null txtbox messagebox?
            double amount = 0;
            double basicSalary = 5000;
            int numOfHours = int.Parse(txtHoursWorked.Text);
            amount = numOfHours * basicSalary;
            txtAmount.Text = amount.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeId.Clear();
            txtHoursWorked.Clear();
            txtAmount.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //when entering data in text boxes, save to database

            string sqlStr = @"Insert into [payroll]([EmployeeId],[HoursWorked],[Amount]) " +
            "values('" + txtEmployeeId.Text + "','" + txtHoursWorked.Text + "','" + txtAmount.Text + "'); ";

            Connection newconnection = new Connection();
            newconnection.GetConnection();

            SqlCommand cmd = new SqlCommand(sqlStr, Connection.conn);
            cmd.ExecuteNonQuery();
            Connection.conn.Close();
            MessageBox.Show("Data Saved Successfully");
        }


        
    }
}
