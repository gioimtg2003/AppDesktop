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
            if (string.IsNullOrEmpty(maskedTextBoxSuplier.Text))
            {
                toolTip1.Show("Vui lòng không để trống nhà cung cấp", maskedTextBoxSuplier, maskedTextBoxSuplier.Width, 0, 1000);
                maskedTextBoxSuplier.Focus();
                return;
            }
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
                Customer customer = new Customer();
                customer.Name = maskedTextBoxSuplier.Text;
                customer.Address = maskedTextBoxAddress.Text;
                customer.Email = maskedTextBoxEmail.Text;
                customer.Phone = maskedTextBoxPhone.Text;
                db.Customers.Add(customer);
                db.SaveChanges();
                var exportBill = new ExportBill();
                exportBill.Description = maskedTextBoxDescription.Text.ToString();
                exportBill.AdministratorID = 1;
                exportBill.CreateDate = dateTimePickerCreateBill.Value.Date;
                exportBill.CustomerID = customer.CustomerID;
                db.ExportBills.Add(exportBill);
                db.SaveChanges();
                addBill?.Invoke(this, EventArgs.Empty);
                toolTip1.Show("Tạo thành công", button2, button2.Width, 0, 2000);
                maskedTextBoxSuplier.Text = null;
                maskedTextBoxAddress.Text = null;
                maskedTextBoxEmail.Text = null;
                maskedTextBoxPhone.Text = null;
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
    }
}
