namespace QuanLyKho
{
    partial class EditCustomer
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
            components = new System.ComponentModel.Container();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btClose = new Button();
            btSave = new Button();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 215);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 46;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 215);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 45;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 132);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 44;
            label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 69);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 43;
            label1.Text = "Tên Khách Hàng";
            // 
            // btClose
            // 
            btClose.Location = new Point(465, 297);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 42;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(243, 297);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 41;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(184, 125);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(527, 27);
            txtAddress.TabIndex = 38;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(184, 208);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(188, 27);
            txtPhone.TabIndex = 39;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(487, 208);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 40;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(184, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(320, 27);
            txtName.TabIndex = 37;
            txtName.Validating += txtName_Validating;
            // 
            // fEditCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "fEditCustomer";
            Text = "Sửa đổi khách hàng ";
            WindowState = FormWindowState.Maximized;
            FormClosing += fEditCustomer_FormClosing;
            Load += fEditCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btClose;
        private Button btSave;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtName;
        private ToolTip toolTip1;
    }
}