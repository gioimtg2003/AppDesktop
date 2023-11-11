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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKho
{
    public partial class EditImportBill : Form
    {
        private int ImportBillID { get; set; }
        public event EventHandler editBill;
        public EditImportBill(int ImportBillID)
        {
            InitializeComponent();
            this.ImportBillID = ImportBillID;
        }


        private void EditImportBill_Load(object sender, EventArgs e)
        {
            using(var db = new Context())
            {
                ImportGridViewData data = db.ImportBills.Include(
                    import => import.Customer).Include(
                    import => import.Administrator).Include(
                    import => import.Stock).Select(
                    import => new ImportGridViewData { ImportBillID = import.ImportBillID, CreateDate = import.CreateDate, Description = import.Description, NameCustomer = import.Customer.Name, AddressCustomer = import.Customer.Address, Phone = import.Customer.Phone, Email = import.Customer.Email, StockName = import.Stock.Name, StockAddress = import.Stock.Address, AdministratorName = import.Administrator.Name }).SingleOrDefault(import => import.ImportBillID == ImportBillID);
                this.Text = "Mã đơn hàng " + data.ImportBillID.ToString();
                maskedTextBoxSuplier.Text = data.NameCustomer;
                maskedTextBoxNameAdmin.Text = data.AdministratorName;
                maskedTextBoxEmail.Text = data.Email;
                maskedTextBoxPhone.Text = data.Phone;
                maskedTextBoxDescription.Text = data.Description;
                dateTimePickerCreateBill.Text = data.CreateDate.ToShortDateString();
                // combobox
                comboBoxStock.DisplayMember= "Name";
                comboBoxStock.ValueMember = "StockID";
                comboBoxStock.DataSource = db.Stocks.Select(stock => new { stock.Name, stock.StockID }).ToList();
                comboBoxStock.Text = data.StockName;
                maskedTextBoxStockAddress.Text = data.StockAddress;
            }
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
            using (var db = new Context())
            {
                try
                {
                    int stockID = Convert.ToInt32(comboBoxStock.SelectedValue);
                    var importBill= db.ImportBills.Include(ip => ip.Customer).SingleOrDefault(import => import.ImportBillID == ImportBillID);
                    importBill.Customer.Name = maskedTextBoxSuplier.Text;
                    importBill.Customer.Address = maskedTextBoxAddress.Text;
                    importBill.Customer.Email = maskedTextBoxEmail.Text;
                    importBill.Customer.Phone = maskedTextBoxPhone.Text;
                    importBill.StockID = stockID;
                    importBill.CreateDate = dateTimePickerCreateBill.Value.Date;
                    importBill.Description= maskedTextBoxDescription.Text;
                    //ID ADMIN
                    db.SaveChanges();
                    editBill?.Invoke(this, EventArgs.Empty);
                    toolTip1.Show("Chỉnh sửa thành công", button2, button2.Width, 0, 2000);

                }
                catch (Exception err)
                {
                    toolTip1.Show("Error: " + err.Message, button2, button2.Width, 0, 2000);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditImportBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
