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
    public partial class InventoryEmployees : Form
    {
        public InventoryEmployees()
        {
            InitializeComponent();
        }

        public static string totalInventory;

        public static decimal finalPrice;

        private int rowIndex = 0;

        
        string sqlStr = "SELECT * FROM [Inventory]";

        DataTable dt = new DataTable();

        public static decimal inventoryFinal;

        private void InventoryEmployees_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Connection.conn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sda.Dispose();

            // Change the color of lines in the dataGridView
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue;

            inventoryFinal = CustomerBooking.bookingtotal;
        }

        //Save the value to the database
        private void Save()
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Connection.conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(dt); sda.Dispose();
        }

        //Start searching in the datagridview as soon as the first letter is typed
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("ItemId LIKE '{0}%'", txtSearch.Text);
        }

        //Update database when value is changed in the datagridview and button update is pressed
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save changes you made to the database?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Connection.conn);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                int changes = sda.Update(dt);
                if (changes > 0)
                    MessageBox.Show($"{changes} records changed");
                else
                    MessageBox.Show("No records changed");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtItemId.Text = row.Cells[0].Value.ToString();
                txtItemName.Text = row.Cells[1].Value.ToString();
                txtSize.Text = row.Cells[2].Value.ToString();
                txtQuantityA.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
            }
        }

        //dataGridView1_CellMouseUp & deleteToolStripMenuItem_Click are used along with
        //to delete row when the user right click on a row
        //"Menu & Toolbar -> ContextMenuStrip" was added on the form 
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        //once the strip menu is on the form, rename it delete & double click on 'delete', then write code
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dataGridView1.Rows[this.rowIndex].IsNewRow)
            {
                this.dataGridView1.Rows.RemoveAt(this.rowIndex);
                Save();
            }
        }

        //Calculate final price and place it in txtFinalPrice when the user input value in txtQuantityR
        private void txtQuantityR_TextChanged(object sender, EventArgs e)
        {
            int QuantityR;
            try
            {
                QuantityR = int.Parse(txtQuantityR.Text);
                finalPrice = int.Parse(txtPrice.Text) * QuantityR;
                txtFinalPrice.Text = finalPrice.ToString();
            }
            catch
            {

            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int QuantityA = int.Parse(txtQuantityA.Text);
            int QuantityR = int.Parse(txtQuantityR.Text);
            if (QuantityR > QuantityA)
            {
                MessageBox.Show("Quantity required is greater than quantity available in stock!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double quantityleft = Convert.ToDouble(txtQuantityA.Text) - Convert.ToDouble(txtQuantityR.Text);
                bool found = false;
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    if (dt.Rows[i][3].Equals(QuantityA))
                    {
                        //update database => NumInStock = NumStock - QuantitySold
                        found = true;
                        dt.Rows[i][3] = quantityleft;
                        dataGridView1.CurrentRow.Cells[3].Value = quantityleft;
                        Save();

                        //Empty the datagrid view on screen, so as to leave space to show the new updated datagridview
                        dt = new DataTable();

                        //Showing updated datagridview
                        SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Connection.conn);
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                        sda.Dispose();

                        //end loop
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Item NOT Found !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //clear textboxes
            txtItemId.Clear();
            txtItemName.Clear();
            txtSize.SelectedIndex = -1;
            txtQuantityA.Clear();
            txtPrice.Clear();
            txtQuantityR.Clear();
            txtFinalPrice.Clear();


            //Message to warn the employee if, for any of the product, there is less than 10 item in the inventory
            string NumInStock;
            string item;
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                NumInStock = (dt.Rows[i][3]).ToString();
                if (double.Parse(NumInStock) < 10)
                {
                    item = (dt.Rows[i][1]).ToString();
                    MessageBox.Show($"Item {item} low inventory!!! Restock item {item}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            totalInventory = (finalPrice).ToString();
            inventoryFinal += finalPrice;
            MessageBox.Show("Selected items added to cart");

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeMenu MyMenu = new EmployeeMenu();
            MyMenu.Show();
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerPayment MyPayment = new CustomerPayment();
            MyPayment.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
    }
    
}
