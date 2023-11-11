namespace QuanLyKho
{
    partial class AddExportBill
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePickerCreateBill = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxNameAdmin = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maskedTextBoxDescription = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxAddress = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxEmail = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(616, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 36);
            this.button3.TabIndex = 46;
            this.button3.Text = "Đóng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePickerCreateBill
            // 
            this.dateTimePickerCreateBill.CustomFormat = "dd/MM/yy";
            this.dateTimePickerCreateBill.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCreateBill.Location = new System.Drawing.Point(417, 16);
            this.dateTimePickerCreateBill.Name = "dateTimePickerCreateBill";
            this.dateTimePickerCreateBill.Size = new System.Drawing.Size(143, 27);
            this.dateTimePickerCreateBill.TabIndex = 17;
            // 
            // maskedTextBoxNameAdmin
            // 
            this.maskedTextBoxNameAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxNameAdmin.Enabled = false;
            this.maskedTextBoxNameAdmin.Location = new System.Drawing.Point(122, 14);
            this.maskedTextBoxNameAdmin.Name = "maskedTextBoxNameAdmin";
            this.maskedTextBoxNameAdmin.Size = new System.Drawing.Size(196, 27);
            this.maskedTextBoxNameAdmin.TabIndex = 16;
            this.maskedTextBoxNameAdmin.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxNameAdmin_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(324, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên nhân viên";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(616, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 36);
            this.button2.TabIndex = 45;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateTimePickerCreateBill);
            this.panel2.Controls.Add(this.maskedTextBoxNameAdmin);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(29, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 68);
            this.panel2.TabIndex = 44;
            // 
            // maskedTextBoxDescription
            // 
            this.maskedTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxDescription.Location = new System.Drawing.Point(149, 112);
            this.maskedTextBoxDescription.Name = "maskedTextBoxDescription";
            this.maskedTextBoxDescription.Size = new System.Drawing.Size(670, 27);
            this.maskedTextBoxDescription.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mô tả";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxPhone.Enabled = false;
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(622, 64);
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(197, 27);
            this.maskedTextBoxPhone.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(513, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số điện thoại";
            // 
            // maskedTextBoxAddress
            // 
            this.maskedTextBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxAddress.Enabled = false;
            this.maskedTextBoxAddress.Location = new System.Drawing.Point(149, 64);
            this.maskedTextBoxAddress.Name = "maskedTextBoxAddress";
            this.maskedTextBoxAddress.Size = new System.Drawing.Size(358, 27);
            this.maskedTextBoxAddress.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Địa chỉ";
            // 
            // maskedTextBoxEmail
            // 
            this.maskedTextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxEmail.Enabled = false;
            this.maskedTextBoxEmail.Location = new System.Drawing.Point(513, 14);
            this.maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            this.maskedTextBoxEmail.Size = new System.Drawing.Size(306, 27);
            this.maskedTextBoxEmail.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(457, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên khách hàng";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxCustomer);
            this.panel1.Controls.Add(this.maskedTextBoxDescription);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.maskedTextBoxPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.maskedTextBoxAddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.maskedTextBoxEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 157);
            this.panel1.TabIndex = 43;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(149, 14);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(302, 28);
            this.comboBoxCustomer.TabIndex = 18;
            this.comboBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomer_SelectedIndexChanged);
            // 
            // AddExportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 295);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddExportBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn xuất kho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddExportBill_FormClosing);
            this.Load += new System.EventHandler(this.AddExportBill_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolTip toolTip1;
        private Button button3;
        private DateTimePicker dateTimePickerCreateBill;
        private MaskedTextBox maskedTextBoxNameAdmin;
        private Label label7;
        private Label label6;
        private Button button2;
        private Panel panel2;
        private MaskedTextBox maskedTextBoxDescription;
        private Label label5;
        private MaskedTextBox maskedTextBoxPhone;
        private Label label4;
        private MaskedTextBox maskedTextBoxAddress;
        private Label label3;
        private MaskedTextBox maskedTextBoxEmail;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private ComboBox comboBoxCustomer;
    }
}