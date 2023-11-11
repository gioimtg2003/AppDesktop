using Microsoft.EntityFrameworkCore;
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
    public partial class EditExportBill : Form
    {
        private int ExportBillID;
        public event EventHandler editBill;
        private Context db = new Context();
        public EditExportBill(int ExportBillID)
        {
            InitializeComponent();
            this.ExportBillID = ExportBillID;
        }

        private void EditExportBill_Load(object sender, EventArgs e)
        {
            this.Text = "Chỉnh sửa hóa đơn - " + ExportBillID.ToString();
            var editExportBill = db.ExportBills.Include(
                i => i.Customer).Include(
                i => i.Administrator).Single(
                i => i.ExportBillID == ExportBillID
                );
            maskedTextBoxSuplier.Text = editExportBill.Customer.Name;
            maskedTextBoxEmail.Text = editExportBill.Customer.Email;
            maskedTextBoxAddress.Text = editExportBill.Customer.Address;
            maskedTextBoxDescription.Text = editExportBill.Description;
            maskedTextBoxEmail.Text = editExportBill.Customer.Email;
            maskedTextBoxPhone.Text = editExportBill.Customer.Phone.ToString();
            dateTimePickerCreateBill.Text = editExportBill.CreateDate.ToShortDateString();
            maskedTextBoxNameAdmin.Text = editExportBill.Administrator.Name;
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
                var editExportBill = db.ExportBills.Include(
                i => i.Customer).Include(
                i => i.Administrator).Single(
                i => i.ExportBillID == ExportBillID);
                editExportBill.CreateDate = dateTimePickerCreateBill.Value.Date;
                editExportBill.Description = maskedTextBoxDescription.Text;
                editExportBill.Customer.Name = maskedTextBoxSuplier.Text;
                editExportBill.Customer.Email = maskedTextBoxEmail.Text;
                editExportBill.Customer.Phone = maskedTextBoxPhone.Text;
                editExportBill.Customer.Address = maskedTextBoxAddress.Text;
                db.SaveChanges();
                editBill?.Invoke(sender, EventArgs.Empty);
                toolTip1.Show("Chỉnh sửa thành công", button2, button2.Width, 0, 2000);

            }
            catch (Exception err)
            {
                toolTip1.Show("Error: " + err.Message, button2, button2.Width, 0, 2000);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void EditExportBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
