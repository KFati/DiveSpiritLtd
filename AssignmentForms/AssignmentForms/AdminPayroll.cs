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
    public partial class AdminPayroll : Form
    {
        public AdminPayroll()
        {
            InitializeComponent();
        }

        private void btnAddPanel_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAddPanel.Height;
            SidePanel.Top = btnAddPanel.Top;
            addUserCon2.BringToFront();
        }

        private void btnDeletePanel_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDeletePanel.Height;
            SidePanel.Top = btnDeletePanel.Top;
            deleteUserCon2.BringToFront();
            deleteUserCon2.LoadData();//load data upon clicking on side btn by using method in user control
        }

        private void btnViewPanel_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnViewPanel.Height;
            SidePanel.Top = btnViewPanel.Top;
            viewUserCon2.BringToFront();
            viewUserCon2.Clear();//clear to avoid seeing previous data :o
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnChart_Click(object sender, EventArgs e)
        {
            Form newfrmchart = new FormChart();
            newfrmchart.Show();
        }
    }
}
