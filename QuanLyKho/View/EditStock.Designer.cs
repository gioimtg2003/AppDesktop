namespace QuanLyKho
{
    partial class EditStock
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
            this.rStockAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStockname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // rStockAddress
            // 
            this.rStockAddress.Location = new System.Drawing.Point(222, 119);
            this.rStockAddress.Name = "rStockAddress";
            this.rStockAddress.Size = new System.Drawing.Size(357, 169);
            this.rStockAddress.TabIndex = 29;
            this.rStockAddress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Địa chỉ";
            // 
            // txtStockname
            // 
            this.txtStockname.Location = new System.Drawing.Point(222, 75);
            this.txtStockname.Name = "txtStockname";
            this.txtStockname.Size = new System.Drawing.Size(357, 27);
            this.txtStockname.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tên Kho";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Lưu ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rStockAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStockname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "EditStock";
            this.Text = "Sửa đổi thông tin kho";
            this.Load += new System.EventHandler(this.fEditStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rStockAddress;
        private Label label5;
        private TextBox txtStockname;
        private Label label1;
        private Button button2;
        private Button button1;
        private ToolTip toolTip1;
    }
}