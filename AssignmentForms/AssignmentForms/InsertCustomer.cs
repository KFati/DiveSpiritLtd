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
    public partial class InsertCustomer : Form
    {
        public InsertCustomer()
        {
            InitializeComponent();
        }

        public static int customerId;
        public static int employeeId;
        public static string diverLevel;
        string newCustomerId;
        private string gender;


        private void InsertCustomer_Load(object sender, EventArgs e)
        {
            Connection newconnection = new Connection();
            newconnection.GetConnection();

            string sqlStr = "Select * from [Customer]";
            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Connection.conn);
            sda.Fill(dt);
            sda.Dispose();
            LoadData();

            // Change the color of lines in the dataGridView
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue;

            //Take the Id of the last customer and add 1 to make a new customerId
            int last;
            string lastCustomerId;
            last = dt.Rows.Count - 1;
            lastCustomerId = (dt.Rows[last][0]).ToString();
            newCustomerId = (double.Parse(lastCustomerId) + 1).ToString();
            txtCustomerId.Text = newCustomerId;
        }

        private void cbDiverLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DiverLevelcb = cbDiverLevel.Text;
            switch (DiverLevelcb)
            {
                case "Beginner":
                    diverLevel = "Beginner";
                    break;
                case "Advanced":
                    diverLevel = "Advanced";
                    break;
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                customerId = int.Parse(txtCustomerId.Text);
                employeeId = int.Parse(txtEmployeeId.Text);

               

                //Connection newconnection = new Connection();
                //newconnection.GetConnection();
                SqlDataAdapter sda = new SqlDataAdapter("InsertCustomer", Connection.conn);
                
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customerId;
                sda.SelectCommand.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = employeeId;
                sda.SelectCommand.Parameters.Add("@CustomerFname", SqlDbType.VarChar).Value = txtCustFname.Text;
                sda.SelectCommand.Parameters.Add("@CustomerLname", SqlDbType.VarChar).Value = txtCustLname.Text;
                if (radMale.Checked)
                    sda.SelectCommand.Parameters.Add("@gender", SqlDbType.VarChar).Value = "Male";
                else if (radFemale.Checked)
                    sda.SelectCommand.Parameters.Add("@gender", SqlDbType.VarChar).Value = "Female";

                sda.SelectCommand.Parameters.Add("@CustomerAddress", SqlDbType.VarChar).Value = txtCustAddress.Text;
                sda.SelectCommand.Parameters.Add("@MedicalStatement", SqlDbType.VarChar).Value = txtMedStatement.Text;
                sda.SelectCommand.Parameters.Add("@DiveInsuranceNum", SqlDbType.Int).Value = txtDiveInsuNum.Text;

                sda.SelectCommand.Parameters.Add("@DiverLevel", SqlDbType.VarChar).Value = diverLevel;

                sda.SelectCommand.Parameters.Add("@EmailAddress", SqlDbType.VarChar).Value = txtEmailAdd.Text;
                sda.SelectCommand.Parameters.Add("@PhoneNum", SqlDbType.Int).Value = txtPhoneNum.Text;

                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Details added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Customer] ([EmployeeId], [CustomerFname], [CustomerLname],[gender], [CustomerAddress], [MedicalStatement], [DiveInsuranceNum], [DiverLevel], [EmailAddress], [PhoneNum])
                // VALUES
                //('" + txtEmployeeId.Text + "' , '" + txtCustFname.Text + "' , '" + txtCustLname.Text + "' , '" + gender + "' , '" + txtCustAddress.Text + "' , '" + txtMedStatement.Text + "' , '" + txtDiveInsuNum.Text + "' , '" + txtDiverLevel.Text + "' , '" + txtEmailAdd.Text + "' , '" + txtPhoneNum.Text +  "')", Con);
                //cmd.ExecuteNonQuery();

                Connection.conn.Close();
                LoadData();
            }
            catch
            {
                MessageBox.Show("Please fill in all the information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
            
            



        }

        public void LoadData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from  [Customer]", Connection.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["CustomerId"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["EmployeeId"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["CustomerFname"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["CustomerLname"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["gender"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["CustomerAddress"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["MedicalStatement"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["DiveInsuranceNum"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["DiverLevel"].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item["EmailAddress"].ToString();
                dataGridView1.Rows[n].Cells[10].Value = item["PhoneNum"].ToString();
            }


        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeId.Clear();
            txtCustFname.Clear();
            txtCustLname.Clear();
            radFemale.Checked = false;
            radMale.Checked = false;
            txtCustAddress.Clear();
            txtMedStatement.Clear();
            txtDiveInsuNum.Clear();
            cbDiverLevel.SelectedIndex = -1;
            txtEmailAdd.Clear();
            txtPhoneNum.Clear();

            txtCustomerId.Text = newCustomerId; //re-add the latest customer id to the textbox
        }

        private void txtDiveInsuNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }


        private void radMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerBooking MyBooking = new CustomerBooking();
            MyBooking.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string genderDG;
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                //populate the textbox from specific value of the coordinates of column and row.
                txtCustomerId.Text = row.Cells[0].Value.ToString();
                txtEmployeeId.Text = row.Cells[1].Value.ToString();
                txtCustFname.Text = row.Cells[2].Value.ToString();
                txtCustLname.Text = row.Cells[3].Value.ToString();

                genderDG = row.Cells[4].Value.ToString();
                if (genderDG.Equals("Male"))
                {
                    radMale.Checked = true;
                }
                else if (genderDG.Equals("Female"))
                {
                    radFemale.Checked = true;
                }

                txtCustAddress.Text = row.Cells[5].Value.ToString();
                txtMedStatement.Text = row.Cells[6].Value.ToString();
                txtDiveInsuNum.Text = row.Cells[7].Value.ToString();
                cbDiverLevel.Text = row.Cells[8].Value.ToString();
                txtEmailAdd.Text = row.Cells[9].Value.ToString();
                txtPhoneNum.Text = row.Cells[10].Value.ToString();

                customerId = int.Parse(txtCustomerId.Text);
                employeeId = int.Parse(txtEmployeeId.Text);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeMenu MyEmpMenu = new EmployeeMenu();
            MyEmpMenu.Show();
        }
    }
}
