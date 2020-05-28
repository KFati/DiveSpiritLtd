namespace AssignmentForms
{
    partial class InsertCustomer
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
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicalStatement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiveInsuranceNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiverLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtEmailAdd = new System.Windows.Forms.TextBox();
            this.txtDiveInsuNum = new System.Windows.Forms.TextBox();
            this.txtMedStatement = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustLname = new System.Windows.Forms.TextBox();
            this.txtCustFname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.cbDiverLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerId.Location = new System.Drawing.Point(283, 82);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(269, 27);
            this.txtCustomerId.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 82;
            this.label1.Text = "Customer  ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.EmployeeId,
            this.CustomerFname,
            this.CustomerLname,
            this.gen,
            this.CustomerAddress,
            this.MedicalStatement,
            this.DiveInsuranceNum,
            this.DiverLevel,
            this.EmailAddress,
            this.PhoneNum});
            this.dataGridView1.Location = new System.Drawing.Point(6, 591);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(801, 253);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.MinimumWidth = 6;
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Width = 125;
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.MinimumWidth = 6;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Width = 125;
            // 
            // CustomerFname
            // 
            this.CustomerFname.HeaderText = "CustomerFname";
            this.CustomerFname.MinimumWidth = 6;
            this.CustomerFname.Name = "CustomerFname";
            this.CustomerFname.Width = 125;
            // 
            // CustomerLname
            // 
            this.CustomerLname.HeaderText = "CustomerLname";
            this.CustomerLname.MinimumWidth = 6;
            this.CustomerLname.Name = "CustomerLname";
            this.CustomerLname.Width = 125;
            // 
            // gen
            // 
            this.gen.HeaderText = "Gender";
            this.gen.MinimumWidth = 6;
            this.gen.Name = "gen";
            this.gen.Width = 125;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.HeaderText = "CustomerAddress";
            this.CustomerAddress.MinimumWidth = 6;
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Width = 125;
            // 
            // MedicalStatement
            // 
            this.MedicalStatement.HeaderText = "MedicalStatement";
            this.MedicalStatement.MinimumWidth = 6;
            this.MedicalStatement.Name = "MedicalStatement";
            this.MedicalStatement.Width = 125;
            // 
            // DiveInsuranceNum
            // 
            this.DiveInsuranceNum.HeaderText = "DiveInsuranceNum";
            this.DiveInsuranceNum.MinimumWidth = 6;
            this.DiveInsuranceNum.Name = "DiveInsuranceNum";
            this.DiveInsuranceNum.Width = 125;
            // 
            // DiverLevel
            // 
            this.DiverLevel.HeaderText = "DiverLevel";
            this.DiverLevel.MinimumWidth = 6;
            this.DiverLevel.Name = "DiverLevel";
            this.DiverLevel.Width = 125;
            // 
            // EmailAddress
            // 
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.MinimumWidth = 6;
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Width = 125;
            // 
            // PhoneNum
            // 
            this.PhoneNum.HeaderText = "PhoneNum";
            this.PhoneNum.MinimumWidth = 6;
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Width = 125;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId.Location = new System.Drawing.Point(284, 128);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(269, 27);
            this.txtEmployeeId.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(23, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 21);
            this.label10.TabIndex = 78;
            this.label10.Text = "Employee  ID:";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.BackColor = System.Drawing.Color.Transparent;
            this.radFemale.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.ForeColor = System.Drawing.Color.Black;
            this.radFemale.Location = new System.Drawing.Point(411, 265);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(95, 25);
            this.radFemale.TabIndex = 77;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = false;
            this.radFemale.CheckedChanged += new System.EventHandler(this.radFemale_CheckedChanged);
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.BackColor = System.Drawing.Color.Transparent;
            this.radMale.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.ForeColor = System.Drawing.Color.Black;
            this.radMale.Location = new System.Drawing.Point(303, 265);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(74, 25);
            this.radMale.TabIndex = 76;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = false;
            this.radMale.CheckedChanged += new System.EventHandler(this.radMale_CheckedChanged);
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.Location = new System.Drawing.Point(283, 542);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(269, 27);
            this.txtPhoneNum.TabIndex = 73;
            this.txtPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNum_KeyPress);
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAdd.Location = new System.Drawing.Point(284, 496);
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Size = new System.Drawing.Size(269, 27);
            this.txtEmailAdd.TabIndex = 72;
            // 
            // txtDiveInsuNum
            // 
            this.txtDiveInsuNum.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiveInsuNum.Location = new System.Drawing.Point(283, 404);
            this.txtDiveInsuNum.Name = "txtDiveInsuNum";
            this.txtDiveInsuNum.Size = new System.Drawing.Size(269, 27);
            this.txtDiveInsuNum.TabIndex = 70;
            this.txtDiveInsuNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiveInsuNum_KeyPress);
            // 
            // txtMedStatement
            // 
            this.txtMedStatement.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedStatement.Location = new System.Drawing.Point(283, 358);
            this.txtMedStatement.Name = "txtMedStatement";
            this.txtMedStatement.Size = new System.Drawing.Size(269, 27);
            this.txtMedStatement.TabIndex = 69;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustAddress.Location = new System.Drawing.Point(283, 312);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(269, 27);
            this.txtCustAddress.TabIndex = 68;
            // 
            // txtCustLname
            // 
            this.txtCustLname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustLname.Location = new System.Drawing.Point(283, 220);
            this.txtCustLname.Name = "txtCustLname";
            this.txtCustLname.Size = new System.Drawing.Size(269, 27);
            this.txtCustLname.TabIndex = 67;
            // 
            // txtCustFname
            // 
            this.txtCustFname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustFname.Location = new System.Drawing.Point(283, 174);
            this.txtCustFname.Name = "txtCustFname";
            this.txtCustFname.Size = new System.Drawing.Size(269, 27);
            this.txtCustFname.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(23, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 21);
            this.label9.TabIndex = 65;
            this.label9.Text = "Phone Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(23, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 21);
            this.label8.TabIndex = 64;
            this.label8.Text = "Email Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 21);
            this.label6.TabIndex = 62;
            this.label6.Text = "Dive Insurance Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 21);
            this.label5.TabIndex = 61;
            this.label5.Text = "Medical Statement:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 21);
            this.label4.TabIndex = 60;
            this.label4.Text = "Customer Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 21);
            this.label3.TabIndex = 59;
            this.label3.Text = "Customer Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 21);
            this.label2.TabIndex = 58;
            this.label2.Text = "Customer First Name:";
            // 
            // BtnNext
            // 
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNext.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.ForeColor = System.Drawing.Color.Navy;
            this.BtnNext.Image = global::AssignmentForms.Properties.Resources.icons8_next_page_40;
            this.BtnNext.Location = new System.Drawing.Point(680, 302);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(90, 50);
            this.BtnNext.TabIndex = 81;
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.Navy;
            this.BtnClear.Image = global::AssignmentForms.Properties.Resources.icons8_delete_40;
            this.BtnClear.Location = new System.Drawing.Point(680, 237);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(90, 50);
            this.BtnClear.TabIndex = 75;
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.Navy;
            this.BtnAdd.Image = global::AssignmentForms.Properties.Resources.icons8_add_user_group_man_man_45;
            this.BtnAdd.Location = new System.Drawing.Point(680, 176);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(90, 50);
            this.BtnAdd.TabIndex = 74;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cbDiverLevel
            // 
            this.cbDiverLevel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiverLevel.FormattingEnabled = true;
            this.cbDiverLevel.Items.AddRange(new object[] {
            "Beginner",
            "Advanced"});
            this.cbDiverLevel.Location = new System.Drawing.Point(283, 450);
            this.cbDiverLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cbDiverLevel.Name = "cbDiverLevel";
            this.cbDiverLevel.Size = new System.Drawing.Size(269, 27);
            this.cbDiverLevel.TabIndex = 113;
            this.cbDiverLevel.SelectedIndexChanged += new System.EventHandler(this.cbDiverLevel_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 21);
            this.label7.TabIndex = 112;
            this.label7.Text = "Diver Level:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 62, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(819, 62);
            this.textBox1.TabIndex = 114;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Customer";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.WordWrap = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(23, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 21);
            this.label11.TabIndex = 115;
            this.label11.Text = "Customer Gender:";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMenu.Image = global::AssignmentForms.Properties.Resources.icons8_menu_40;
            this.btnMenu.Location = new System.Drawing.Point(767, 10);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 40);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMenu.TabIndex = 116;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.Image = global::AssignmentForms.Properties.Resources.icons8_shutdown_40;
            this.btnClose.Location = new System.Drawing.Point(9, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 117;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // InsertCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AssignmentForms.Properties.Resources.abstract_blue_wave_background_vector_899469___Copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 856);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbDiverLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtEmailAdd);
            this.Controls.Add(this.txtDiveInsuNum);
            this.Controls.Add(this.txtMedStatement);
            this.Controls.Add(this.txtCustAddress);
            this.Controls.Add(this.txtCustLname);
            this.Controls.Add(this.txtCustFname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InsertCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalStatement;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiveInsuranceNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiverLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtEmailAdd;
        private System.Windows.Forms.TextBox txtDiveInsuNum;
        private System.Windows.Forms.TextBox txtMedStatement;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustLname;
        private System.Windows.Forms.TextBox txtCustFname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDiverLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox btnClose;
    }
}

