namespace QuanLyKho
{
    partial class StockManage
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemKho = new System.Windows.Forms.Button();
            this.cbStock = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbsoluongkho = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(454, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHO HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemKho
            // 
            this.btnThemKho.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemKho.Location = new System.Drawing.Point(703, 51);
            this.btnThemKho.Name = "btnThemKho";
            this.btnThemKho.Size = new System.Drawing.Size(91, 29);
            this.btnThemKho.TabIndex = 1;
            this.btnThemKho.Text = "Thêm kho hàng";
            this.btnThemKho.UseVisualStyleBackColor = true;
            this.btnThemKho.Click += new System.EventHandler(this.btnThemKho_Click);
            // 
            // cbStock
            // 
            this.cbStock.FormattingEnabled = true;
            this.cbStock.Location = new System.Drawing.Point(454, 52);
            this.cbStock.Name = "cbStock";
            this.cbStock.Size = new System.Drawing.Size(243, 28);
            this.cbStock.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn kho :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKho,
            this.StockName,
            this.StockAddress,
            this.Edit,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(0, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(611, 680);
            this.dataGridView1.TabIndex = 4;
            // 
            // IDKho
            // 
            this.IDKho.DataPropertyName = "StockID";
            this.IDKho.HeaderText = "Mã Kho";
            this.IDKho.MinimumWidth = 6;
            this.IDKho.Name = "IDKho";
            this.IDKho.Width = 89;
            // 
            // StockName
            // 
            this.StockName.DataPropertyName = "Name";
            this.StockName.HeaderText = "Tên Kho";
            this.StockName.MinimumWidth = 6;
            this.StockName.Name = "StockName";
            this.StockName.Width = 91;
            // 
            // StockAddress
            // 
            this.StockAddress.DataPropertyName = "Address";
            this.StockAddress.HeaderText = "Địa chỉ";
            this.StockAddress.MinimumWidth = 6;
            this.StockAddress.Name = "StockAddress";
            this.StockAddress.Width = 84;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 41;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 59;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKho,
            this.MaSP,
            this.TenSP,
            this.MoTaSP});
            this.dataGridView2.Location = new System.Drawing.Point(617, 81);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(833, 680);
            this.dataGridView2.TabIndex = 5;
            // 
            // MaKho
            // 
            this.MaKho.DataPropertyName = "StockID";
            this.MaKho.HeaderText = "Mã Kho";
            this.MaKho.MinimumWidth = 6;
            this.MaKho.Name = "MaKho";
            this.MaKho.Width = 125;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "ProductID";
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "Name";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 125;
            // 
            // MoTaSP
            // 
            this.MoTaSP.DataPropertyName = "Description";
            this.MoTaSP.HeaderText = "Mô Tả Sản Phẩm";
            this.MoTaSP.MinimumWidth = 6;
            this.MoTaSP.Name = "MoTaSP";
            this.MoTaSP.Width = 125;
            // 
            // lbsoluongkho
            // 
            this.lbsoluongkho.AutoSize = true;
            this.lbsoluongkho.Location = new System.Drawing.Point(12, 60);
            this.lbsoluongkho.Name = "lbsoluongkho";
            this.lbsoluongkho.Size = new System.Drawing.Size(108, 20);
            this.lbsoluongkho.TabIndex = 6;
            this.lbsoluongkho.Text = "Số lượng kho : ";
            // 
            // StockManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1462, 773);
            this.Controls.Add(this.lbsoluongkho);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStock);
            this.Controls.Add(this.btnThemKho);
            this.Controls.Add(this.label1);
            this.Name = "StockManage";
            this.Text = "Quản lý kho hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.fManageStock_Activated);
            this.Load += new System.EventHandler(this.fManageStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnThemKho;
        private ComboBox cbStock;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label lbsoluongkho;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn IDKho;
        private DataGridViewTextBoxColumn StockName;
        private DataGridViewTextBoxColumn StockAddress;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private DataGridViewTextBoxColumn MaKho;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn MoTaSP;
    }
}
