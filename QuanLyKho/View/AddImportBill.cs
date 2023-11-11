using System.Data;
using QuanLyKho.Model;


namespace QuanLyKho
{
    public partial class AddImportBill : Form
    {
        private Context db = new Context();
        public event EventHandler addBill;
        public AddImportBill()
        {
            InitializeComponent();
        }

        private void AddImportBill_Load(object sender, EventArgs e)
        {
            maskedTextBoxNameAdmin.Text = Utility.Employee.Name;
            // đổ dữ liệu cho combobox kho
            comboBoxStock.DisplayMember = "Name";
            comboBoxStock.ValueMember = "StockID";
            comboBoxStock.DataSource = db.Stocks.Select(stock => new { stock.Name, stock.StockID }).ToList();
            // đổ dữ liệu cho combobox sản phẩm
            comboBoxSupplier.DisplayMember= "Name";
            comboBoxSupplier.ValueMember = "CustomerID";
            comboBoxSupplier.DataSource = db.Customers.Select(
                customer => new { Name = customer.Name, CustomerID = customer.CustomerID }
                ).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxSupplier.Text))
            {
                toolTip1.Show("Vui lòng không để trống nhà cung cấp", comboBoxSupplier, comboBoxSupplier.Width, 0, 1000);
                comboBoxSupplier.Focus();
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
                int stockID = Convert.ToInt32(comboBoxStock.SelectedValue);

                ImportBill importBill = new ImportBill();
                importBill.Description = maskedTextBoxDescription.Text.ToString();
                importBill.AdministratorID = Utility.Employee.AdministratorID;
                importBill.StockID = stockID;
                importBill.CreateDate = dateTimePickerCreateBill.Value.Date;
                importBill.CustomerID = Convert.ToInt32(comboBoxSupplier.SelectedValue);
                db.ImportBills.Add(importBill);
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

        private void AddImportBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void comboBoxStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stockID = Convert.ToInt32(comboBoxStock.SelectedValue);
            maskedTextBoxStockAddress.Text = db.Stocks.Where(stock => stock.StockID == stockID).Select(stock => new { stock.Address }).SingleOrDefault().Address.ToString();
        }


        private void maskedTextBoxEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxEmail.Text))
            {
                toolTip1.Show("Vui lòng không để trống email", maskedTextBoxEmail, maskedTextBoxEmail.Width, 0, 1000);
                e.Cancel = true;
            }
        }

        private void maskedTextBoxAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxAddress.Text))
            {
                toolTip1.Show("Vui lòng không để trống địa chỉ", maskedTextBoxAddress, maskedTextBoxAddress.Width, 0, 1000);
                e.Cancel = true;
            }
        }

        private void maskedTextBoxPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxPhone.Text))
            {
                toolTip1.Show("Vui lòng không để trống số điện thoại", maskedTextBoxPhone, maskedTextBoxPhone.Width, 0, 1000);
                e.Cancel = true;
                return;
            }
            if(maskedTextBoxPhone.Text.Length != 10)
            {
                toolTip1.Show("Số điện thoại phải 10 ký tự", maskedTextBoxPhone, maskedTextBoxPhone.Width, 0, 1000);
                e.Cancel = true;
                return;
            }
        }

        private void maskedTextBoxDescription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxDescription.Text))
            {
                toolTip1.Show("Vui lòng không để trống mô tả", maskedTextBoxDescription, maskedTextBoxDescription.Width, 0, 1000);
                e.Cancel = true;
            }
        }

        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var Supplier = db.Customers.Single(
                i => i.CustomerID == Convert.ToInt32(comboBoxSupplier.SelectedValue));
                comboBoxSupplier.Text = Supplier.Name;
                maskedTextBoxAddress.Text = Supplier.Address;
                maskedTextBoxEmail.Text = Supplier.Email ;
                maskedTextBoxPhone.Text = Supplier.Phone;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
