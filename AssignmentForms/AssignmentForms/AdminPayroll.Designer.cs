namespace AssignmentForms
{
    partial class AdminPayroll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.BtnChart = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnViewPanel = new System.Windows.Forms.Button();
            this.btnDeletePanel = new System.Windows.Forms.Button();
            this.btnAddPanel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addUserCon2 = new AssignmentForms.AddUserCon();
            this.deleteUserCon2 = new AssignmentForms.DeleteUserCon();
            this.viewUserCon2 = new AssignmentForms.ViewUserCon();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.SidePanel);
            this.panel2.Controls.Add(this.BtnChart);
            this.panel2.Controls.Add(this.btnCloseForm);
            this.panel2.Controls.Add(this.btnViewPanel);
            this.panel2.Controls.Add(this.btnDeletePanel);
            this.panel2.Controls.Add(this.btnAddPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 469);
            this.panel2.TabIndex = 2;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Red;
            this.SidePanel.Location = new System.Drawing.Point(0, 105);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(15, 47);
            this.SidePanel.TabIndex = 16;
            // 
            // BtnChart
            // 
            this.BtnChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnChart.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChart.ForeColor = System.Drawing.Color.White;
            this.BtnChart.Location = new System.Drawing.Point(23, 394);
            this.BtnChart.Name = "BtnChart";
            this.BtnChart.Size = new System.Drawing.Size(162, 43);
            this.BtnChart.TabIndex = 15;
            this.BtnChart.Text = "Salary Chart";
            this.BtnChart.UseVisualStyleBackColor = true;
            this.BtnChart.Click += new System.EventHandler(this.BtnChart_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Image = global::AssignmentForms.Properties.Resources.icons8_delete_40;
            this.btnCloseForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseForm.Location = new System.Drawing.Point(23, 323);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(163, 43);
            this.btnCloseForm.TabIndex = 14;
            this.btnCloseForm.Text = "Close?";
            this.btnCloseForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnViewPanel
            // 
            this.btnViewPanel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnViewPanel.FlatAppearance.BorderSize = 0;
            this.btnViewPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPanel.ForeColor = System.Drawing.Color.White;
            this.btnViewPanel.Image = global::AssignmentForms.Properties.Resources.icons8_view_40;
            this.btnViewPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPanel.Location = new System.Drawing.Point(23, 252);
            this.btnViewPanel.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewPanel.Name = "btnViewPanel";
            this.btnViewPanel.Size = new System.Drawing.Size(162, 43);
            this.btnViewPanel.TabIndex = 13;
            this.btnViewPanel.Text = " View?";
            this.btnViewPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewPanel.UseVisualStyleBackColor = true;
            this.btnViewPanel.Click += new System.EventHandler(this.btnViewPanel_Click);
            // 
            // btnDeletePanel
            // 
            this.btnDeletePanel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDeletePanel.FlatAppearance.BorderSize = 0;
            this.btnDeletePanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletePanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePanel.ForeColor = System.Drawing.Color.White;
            this.btnDeletePanel.Image = global::AssignmentForms.Properties.Resources.icons8_delete_bin_40;
            this.btnDeletePanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePanel.Location = new System.Drawing.Point(23, 174);
            this.btnDeletePanel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePanel.Name = "btnDeletePanel";
            this.btnDeletePanel.Size = new System.Drawing.Size(162, 47);
            this.btnDeletePanel.TabIndex = 12;
            this.btnDeletePanel.Text = "      Delete?";
            this.btnDeletePanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletePanel.UseVisualStyleBackColor = true;
            this.btnDeletePanel.Click += new System.EventHandler(this.btnDeletePanel_Click);
            // 
            // btnAddPanel
            // 
            this.btnAddPanel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPanel.ForeColor = System.Drawing.Color.White;
            this.btnAddPanel.Image = global::AssignmentForms.Properties.Resources.icons8_add_user_group_man_man_45;
            this.btnAddPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPanel.Location = new System.Drawing.Point(23, 105);
            this.btnAddPanel.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPanel.Name = "btnAddPanel";
            this.btnAddPanel.Size = new System.Drawing.Size(163, 47);
            this.btnAddPanel.TabIndex = 11;
            this.btnAddPanel.Text = "    Add?";
            this.btnAddPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPanel.UseVisualStyleBackColor = true;
            this.btnAddPanel.Click += new System.EventHandler(this.btnAddPanel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(207, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 66);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYROLL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(207, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 29);
            this.panel1.TabIndex = 5;
            // 
            // addUserCon2
            // 
            this.addUserCon2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(239)))));
            this.addUserCon2.Location = new System.Drawing.Point(207, 94);
            this.addUserCon2.Name = "addUserCon2";
            this.addUserCon2.Size = new System.Drawing.Size(681, 375);
            this.addUserCon2.TabIndex = 8;
            // 
            // deleteUserCon2
            // 
            this.deleteUserCon2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(239)))));
            this.deleteUserCon2.Location = new System.Drawing.Point(207, 94);
            this.deleteUserCon2.Name = "deleteUserCon2";
            this.deleteUserCon2.Size = new System.Drawing.Size(681, 375);
            this.deleteUserCon2.TabIndex = 7;
            // 
            // viewUserCon2
            // 
            this.viewUserCon2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(239)))));
            this.viewUserCon2.Location = new System.Drawing.Point(209, 94);
            this.viewUserCon2.Name = "viewUserCon2";
            this.viewUserCon2.Size = new System.Drawing.Size(681, 375);
            this.viewUserCon2.TabIndex = 6;
            // 
            // AdminPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(888, 469);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.addUserCon2);
            this.Controls.Add(this.deleteUserCon2);
            this.Controls.Add(this.viewUserCon2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPayroll";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnCloseForm;
        public System.Windows.Forms.Button btnViewPanel;
        public System.Windows.Forms.Button btnDeletePanel;
        public System.Windows.Forms.Button btnAddPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private DeleteUserCon deleteUserCon1;
        private ViewUserCon viewUserCon1;
        private AddUserCon addUserCon1;
        private ViewUserCon viewUserCon2;
        private DeleteUserCon deleteUserCon2;
        private AddUserCon addUserCon2;
        private System.Windows.Forms.Button BtnChart;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label label1;
    }
}