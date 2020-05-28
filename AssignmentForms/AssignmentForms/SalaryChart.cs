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
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            FillChart();
        }

        private void FillChart()
        {
            //SqlConnection con = new SqlConnection("Data Source=LAPTOP-PRUQ23QK;Initial Catalog=UOMAssignmentApp;Integrated Security=True");
            Connection newconnection = new Connection();
            newconnection.GetConnection();
            DataSet ds = new DataSet();
            
            SqlDataAdapter adapt = new SqlDataAdapter("Select Employee.EmpFname,payroll.Amount,payroll.EmployeeId" +
                "                                      from payroll " +
                "                                      inner join Employee on " +
                "                                      payroll.employeeId = Employee.employeeId", Connection.conn);
            adapt.Fill(ds);
            SalaryChart.DataSource = ds;
            SalaryChart.Series["Salary"].XValueMember = "EmpFname";
            SalaryChart.Series["Salary"].YValueMembers = "Amount";
            SalaryChart.Titles.Add("Salary Chart");
            Connection.conn.Close();
            this.Controls.Add(this.SalaryChart);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
