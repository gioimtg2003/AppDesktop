using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.Model;

namespace QuanLyKho
{
    public partial class AddExportBill : Form
    {
        public event EventHandler addBill;
        private Context db = new Context();
        public AddExportBill()
        {
            InitializeComponent();
        }

        private void AddExportBill_Load(object sender, EventArgs e)
        {
            comboBoxCustomer.DisplayMember = "Name";
            comboBoxCustomer.ValueMember = "CustomerID";
            comboBoxCustomer.DataSource = db.Customers.Select(
                customer => new { Name = customer.Name, CustomerID = customer.CustomerID }
                ).ToList();
            maskedTextBoxNameAdmin.Text = Utility.Employee.Name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddExportBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(maskedTextBoxEmail.Text))
            {
                toolTip1.Show("Vui lòng không để trống email", maskedTextBoxEmail, maskedTextBoxEmail.Width, 0, 1000);
                maskedTextBoxEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxAddress.Text))
            {
                toolTip1.Show("Vui lòng không để trống địa chỉ", maskedTextBoxAddress, maskedTextBoxAddress.Width, 0, 1000);
                maskedTextBoxAddress.Focus();
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxPhone.Text))
            {
                toolTip1.Show("Vui lòng không để trống số điện thoại", maskedTextBoxPhone, maskedTextBoxPhone.Width, 0, 1000);
                maskedTextBoxPhone.Focus();
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxDescription.Text))
            {
                toolTip1.Show("Vui lòng không để trống mô tả", maskedTextBoxDescription, maskedTextBoxDescription.Width, 0, 1000);
                maskedTextBoxDescription.Focus();
                return;
            }
            try
            {
               
                var exportBill = new ExportBill();
                exportBill.Description = maskedTextBoxDescription.Text.ToString();
                exportBill.AdministratorID = Utility.Employee.AdministratorID;
                exportBill.CreateDate = dateTimePickerCreateBill.Value.Date;
                exportBill.CustomerID = Convert.ToInt32(comboBoxCustomer.SelectedValue);
                db.ExportBills.Add(exportBill);
                db.SaveChanges();
                addBill?.Invoke(this, EventArgs.Empty);
                toolTip1.Show("Tạo thành công", button2, button2.Width, 0, 2000);
                maskedTextBoxDescription.Text = null;


            }
            catch (Exception err)
            {
                toolTip1.Show("Error: " + err.Message, button2, button2.Width, 0, 2000);
            }
        }

        private void maskedTextBoxNameAdmin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var Customer = db.Customers.Single(
                i => i.CustomerID == Convert.ToInt32(comboBoxCustomer.SelectedValue));
                comboBoxCustomer.Text = Customer.Name;
                maskedTextBoxAddress.Text = Customer.Address;
                maskedTextBoxEmail.Text = Customer.Email;
                maskedTextBoxPhone.Text = Customer.Phone;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
