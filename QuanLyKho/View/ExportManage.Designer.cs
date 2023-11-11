namespace QuanLyKho
{
    partial class ExportManage
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ExportBillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdministratorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExportBillID,
            this.CreateDate,
            this.Description,
            this.CustomerName,
            this.CustomerAddress,
            this.CustomerPhone,
            this.CustomerEmail,
            this.AdministratorName,
            this.Delete,
            this.Edit});
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1412, 657);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1062, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 38);
            this.button2.TabIndex = 14;
            this.button2.Text = "Lọc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2023",
            "2022",
            "2021",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013"});
            this.comboBoxYear.Location = new System.Drawing.Point(943, 43);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(94, 28);
            this.comboBoxYear.TabIndex = 13;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(783, 42);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(94, 28);
            this.comboBoxMonth.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(883, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(711, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(318, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quản lý xuất kho";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tạo mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExportBillID
            // 
            this.ExportBillID.DataPropertyName = "ExportBillID";
            this.ExportBillID.HeaderText = "Mã đơn";
            this.ExportBillID.MinimumWidth = 6;
            this.ExportBillID.Name = "ExportBillID";
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "Ngày nhập";
            this.CreateDate.MinimumWidth = 6;
            this.CreateDate.Name = "CreateDate";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Mô tả";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "NameCustomer";
            this.CustomerName.HeaderText = "Tên khách hàng";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.DataPropertyName = "AddressCustomer";
            this.CustomerAddress.HeaderText = "Địa chỉ";
            this.CustomerAddress.MinimumWidth = 6;
            this.CustomerAddress.Name = "CustomerAddress";
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.DataPropertyName = "Phone";
            this.CustomerPhone.HeaderText = "Số điện thoại";
            this.CustomerPhone.MinimumWidth = 6;
            this.CustomerPhone.Name = "CustomerPhone";
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.DataPropertyName = "Email";
            this.CustomerEmail.HeaderText = "Email";
            this.CustomerEmail.MinimumWidth = 6;
            this.CustomerEmail.Name = "CustomerEmail";
            // 
            // AdministratorName
            // 
            this.AdministratorName.DataPropertyName = "AdministratorName";
            this.AdministratorName.HeaderText = "Người tạo đơn";
            this.AdministratorName.MinimumWidth = 6;
            this.AdministratorName.Name = "AdministratorName";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // ExportManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 773);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ExportManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExportManage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExportManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private Button button2;
        private ComboBox comboBoxYear;
        private ComboBox comboBoxMonth;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn ExportBillID;
        private DataGridViewTextBoxColumn CreateDate;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CustomerAddress;
        private DataGridViewTextBoxColumn CustomerPhone;
        private DataGridViewTextBoxColumn CustomerEmail;
        private DataGridViewTextBoxColumn AdministratorName;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn Edit;
    }
}