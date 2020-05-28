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
    public partial class DeleteUserCon : UserControl
    {
        public DeleteUserCon()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lviEmployees.CheckedItems.Count;// total num of checked items
            if (i >= 1)//at least one item checked
            {
                if (MessageBox.Show($"Are you sure you want to delete {i} item(s)?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (ListViewItem lvitem in lviEmployees.Items)
                    {
                        if (lvitem.Checked)//check if item is checked
                        {
                            lviEmployees.Items.Remove(lvitem);//remove item
                            //remove from database
                            
                            string sqlReadStr = @" DELETE FROM [payroll] WHERE EmployeeId=" + lvitem.Text + ";";
                            Connection newconnection = new Connection();
                            newconnection.GetConnection();
                            SqlCommand cmd = new SqlCommand(sqlReadStr, Connection.conn);
                            cmd.ExecuteNonQuery();
                            Connection.conn.Close();
                        }
                    }
                }
            }
            else//no items checked
            {
                MessageBox.Show("No items have been selected.Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            lviEmployees.Items.Clear();
            //enabling checkboxes
            lviEmployees.CheckBoxes = true;
            //upon load all data already appears:
           
            Connection newconnection = new Connection();
            newconnection.GetConnection();

            //sql command to retrieve data from tblPayroll
            string sqlReadStr = @"SELECT * FROM [Payroll]";

            //SqlConnection Con = new SqlConnection(conStr);
            //Con.Open();

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
    }
}
