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
    public partial class InventoryAdmin : Form
    {
        public InventoryAdmin()
        {
            InitializeComponent();
        }

        private int rowIndex = 0;

        
        string sqlStr = "SELECT * FROM [Inventory]";
        DataTable dt = new DataTable();

        private void InventoryAdmin_Load(object sender, EventArgs e)
        {
            Connection newconnection = new Connection();
            newconnection.GetConnection();

            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Connection.conn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sda.Dispose();

            // Change the color of lines in the dataGridView
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Start searching in the datagridview as soon as the first letter is typed
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("ItemId LIKE '{0}%'", txtSearch.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save changes you made to the database?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Connection newconnection = new Connection();
                //newconnection.GetConnection();

                SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Connection.conn);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                int changes = sda.Update(dt);
                if (changes > 0)
                    MessageBox.Show($"{changes} records changed");
                else
                    MessageBox.Show("No records changed");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Connection newconnection = new Connection();
            //newconnection.GetConnection();

            //Open frmAddItem 
            AddItem frm = new AddItem();
            frm.ShowDialog();

            //Empty the datagrid view on screen, 
            //so as to leave space to show the new updated datagridview
            dt = new DataTable();
            //Showing updated datagridview
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Connection.conn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sda.Dispose();
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dataGridView1.Rows[this.rowIndex].IsNewRow)
            {
                this.dataGridView1.Rows.RemoveAt(this.rowIndex);
                Save();
            }
        }

        //Save the value to the database
        private void Save()
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, Connection.conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(dt); sda.Dispose();
        }

        //the little cross in the search textbox, that is used to clear the textbox in the below picture
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPayroll MyPayroll = new AdminPayroll();
            MyPayroll.Show();
        }
    }
}
