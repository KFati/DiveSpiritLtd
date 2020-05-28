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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        //string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UOMDiveSpirit.mdf;Integrated Security=True";
        string sqlStr = "SELECT * FROM [Inventory]";
        DataTable dt = new DataTable();

        private void AddItem_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Connection.conn);
            sda.Fill(dt);
            sda.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newRow = dt.NewRow();
            newRow["ItemId"] = txtItemId.Text;
            newRow["ItemName"] = txtItemName.Text;
            newRow["size"] = txtSize.Text;
            newRow["NumInStock"] = txtQuantity.Text;
            newRow["Price"] = txtPrice.Text;
            dt.Rows.Add(newRow);
            Save();

            txtItemId.Clear();
            txtItemName.Clear();
            txtSize.SelectedIndex = -1;
            txtQuantity.Clear();
            txtPrice.Clear();

            MessageBox.Show("Item Added", " ", MessageBoxButtons.OK);
        }
        private void Save()
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Connection.conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            sda.Dispose();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
