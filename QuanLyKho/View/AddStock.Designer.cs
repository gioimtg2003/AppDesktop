namespace QuanLyKho
{
    partial class AddStock
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rStockAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStockname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lưu ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rStockAddress
            // 
            this.rStockAddress.Location = new System.Drawing.Point(128, 72);
            this.rStockAddress.Name = "rStockAddress";
            this.rStockAddress.Size = new System.Drawing.Size(411, 175);
            this.rStockAddress.TabIndex = 22;
            this.rStockAddress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Địa chỉ";
            // 
            // txtStockname
            // 
            this.txtStockname.Location = new System.Drawing.Point(128, 28);
            this.txtStockname.Name = "txtStockname";
            this.txtStockname.Size = new System.Drawing.Size(411, 27);
            this.txtStockname.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên Kho";
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 388);
            this.ControlBox = false;
            this.Controls.Add(this.rStockAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStockname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập thông tin kho";
            this.Load += new System.EventHandler(this.AddStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private RichTextBox rStockAddress;
        private Label label5;
        private TextBox txtStockname;
        private Label label1;
        private ToolTip toolTip1;
    }
}