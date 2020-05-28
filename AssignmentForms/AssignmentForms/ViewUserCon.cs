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
    public partial class ViewUserCon : UserControl
    {
        public ViewUserCon()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lviEmployees.Items.Clear();//clear to avoid data duplication
            //from database add to list view all stored data
            
            //sql command to retrieve data from tblPayroll
            string sqlReadStr = @"SELECT * FROM [payroll]";

            Connection newconnection = new Connection();
            newconnection.GetConnection();

            SqlCommand cmd = new SqlCommand(sqlReadStr, Connection.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            //adding items to list view using a while loop
            while (reader.Read())
            {
                ListViewItem lviEmployeeSalary = new ListViewItem(reader["EmployeeId"].ToString());
                lviEmployeeSalary.SubItems.Add(reader["HoursWorked"].ToString());
                lviEmployeeSalary.SubItems.Add(reader["Amount"].ToString());
                lviEmployees.Items.Add(lviEmployeeSalary);
            }
            Connection.conn.Close();
        }

        public void Clear()
        {
            lviEmployees.Items.Clear();
        }
    }
}
