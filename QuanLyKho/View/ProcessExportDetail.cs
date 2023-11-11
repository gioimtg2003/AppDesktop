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
    public partial class ProcessExportDetail : Form
    {
        private Context db = new Context();
        private int stockID;
        private long productID;
        private int unitID;
        private int stockDetailID;
        private int exportBillID;
        public ProcessExportDetail()
        {
            InitializeComponent();
        }

        private void comboBoxImportBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            exportBillID = Convert.ToInt32(comboBoxExportBill.SelectedValue);
            var export = db.ExportBills.Include(
                    i => i.Customer).SingleOrDefault(i => i.ExportBillID == exportBillID);
            if (export != null)
            {
                // nhà cung cấp
                maskedTextBoxSuplier.Text = export.Customer.Name;
                maskedTextBoxEmail.Text = export.Customer.Email;
                maskedTextBoxAddress.Text = export.Customer.Address;
                maskedTextBoxPhone.Text = export.Customer.Phone;
                //
                maskedTextBoxDescription.Text = export.Description;
            }
            loadData();
        }
        private void ProcessExportDetail_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            comboBoxExportBill.DataSource = db.ExportBills.Select(ip => ip.ExportBillID).ToList();
            // đổ dữ liệu cho combobox kho
            comboBoxStock.DisplayMember = "Name";
            comboBoxStock.ValueMember = "StockID";
            comboBoxStock.DataSource = db.Stocks.Select(stock => new { stock.Name, stock.StockID }).ToList();
            // config cho combobox product
            comboBoxProduct.DisplayMember = "Name";
            comboBoxProduct.ValueMember = "ProductID";
            ///
            comboBoxUnit.DisplayMember = "Name";
            comboBoxUnit.ValueMember = "UnitID";
            maskedTextBoxNameAdmin.Text = Utility.Employee.Name;

        }

        private void comboBoxStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            stockID = Convert.ToInt32(comboBoxStock.SelectedValue);
            maskedTextBoxStockAddress.Text = db.Stocks.Where(
                stock => stock.StockID == stockID).Select(stock => new { stock.Address }).SingleOrDefault().Address.ToString();
            var dataStockDetail = db.StockDetails
                .Where(i => i.StockID == stockID)
                .Include(i => i.Product)
                .Select(i => new {i.Product.Name,i.Product.ProductID}).ToList();
            comboBoxProduct.DataSource = dataStockDetail;

        }
        private void comboBoxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            unitID = Convert.ToInt32(comboBoxUnit.SelectedValue);
            var quantity = db.StockDetails
                .Where(i => i.StockID == stockID && i.ProductID == productID && i.UnitID == unitID)
                .SingleOrDefault();
            maskedTextBox1.Text = quantity.Quantity.ToString();
            stockDetailID = Convert.ToInt32(quantity.StockDetailID);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {

                    int exportProductDetailID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ExportProductDetailID"].Value);
                    var remove = db.ExportProductDetails.Single(i => i.ExportProductDetailID == exportProductDetailID);
                    if (MessageBox.Show("Bạn muốn xóa " + remove.ExportProductDetailID, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var addQuantity = db.StockDetails.Single(i => i.StockDetailID == remove.StockDetailID);
                        addQuantity.Quantity += remove.Quantity;
                        db.SaveChanges();
                        db.ExportProductDetails.Remove(remove);
                        db.SaveChanges();
                        loadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message , "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            productID = Convert.ToInt64(comboBoxProduct.SelectedValue);
            var Unit = db.StockDetails
                .Where(i => i.StockID == stockID && i.ProductID == productID)
                .Include(i => i.Unit)
                .Select(i => new {Name = i.Unit.Name, UnitID = i.Unit.UnitID})
                .ToList();
            comboBoxUnit.DataSource = Unit;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBoxQuantity.Text))
            {
                toolTip1.Show("Vui lòng không để trống", maskedTextBoxQuantity, maskedTextBoxQuantity.Width, 0, 1000);
                maskedTextBoxQuantity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(maskedTextBoxPrice.Text))
            {
                toolTip1.Show("Vui lòng không để trống", maskedTextBoxPrice, maskedTextBoxPrice.Width, 0, 1000);
                maskedTextBoxPrice.Focus();
                return;
            }
           try
            {
                ExportBillDetail exportBillDetail = new ExportBillDetail();
                exportBillDetail.ExportBillID = exportBillID;
                db.ExportBillDetails.Add(exportBillDetail);
                db.SaveChanges();
                ExportProductDetail exportProductDetail = new ExportProductDetail();
                exportProductDetail.ExportBillDetailID = exportBillDetail.ExportBillDetailID;
                exportProductDetail.Quantity = Convert.ToInt32(maskedTextBoxQuantity.Text);
                exportProductDetail.StockDetailID = stockDetailID;
                exportProductDetail.Price = Convert.ToInt32(maskedTextBoxPrice.Text);
                db.ExportProductDetails.Add(exportProductDetail);
                db.SaveChanges();
                var handleQUantity = db.StockDetails
                    .Where(i => i.StockDetailID == stockDetailID)
                    .SingleOrDefault();
                if (handleQUantity != null)
                {
                    handleQUantity.Quantity -= Convert.ToInt32(maskedTextBoxQuantity.Text);
                    db.SaveChanges();
                }
                loadData();
                toolTip1.Show("Thêm thành công", button1, button1.Width, 0, 1000);
                maskedTextBoxQuantity.Text = null;
                maskedTextBoxPrice.Text = null;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskedTextBoxQuantity_Validating(object sender, CancelEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                if (string.IsNullOrWhiteSpace(maskedTextBoxQuantity.Text))
                {
                    toolTip1.Show("Vui lòng không để trống", maskedTextBoxQuantity, maskedTextBoxQuantity.Width, 0, 1000);
                    e.Cancel = true;
                    return;
                }
                if (Convert.ToInt32(maskedTextBoxQuantity.Text) > Convert.ToInt32(maskedTextBox1.Text))
                {
                    toolTip1.Show("Số lượng phải nhỏ hơn số lượng trong kho", maskedTextBoxQuantity, maskedTextBoxQuantity.Width, 0, 1000);
                    e.Cancel = true;
                    return;
                }
                if (Convert.ToInt32(maskedTextBoxQuantity.Text) < 0)
                {
                    toolTip1.Show("Số lượng phải lớn hơn 0", maskedTextBoxQuantity, maskedTextBoxQuantity.Width, 0, 1000);
                    e.Cancel = true;
                    return;
                }
            }
        }
        private void loadData()
        {
            var data = db.ExportProductDetails
                .Include(i => i.ExportBillDetail)
                .Where(i => i.ExportBillDetail.ExportBillID == exportBillID)
                .Include(i => i.StockDetail)
                .Include(i => i.StockDetail.Product)
                .Include(i => i.StockDetail.Unit)
                .Include(i => i.StockDetail.Stock)
                .Select(i => new { ExportProductDetailID = i.ExportProductDetailID, ProductName = i.StockDetail.Product.Name, StockName = i.StockDetail.Stock.Name, UnitName = i.StockDetail.Unit.Name, Price  = i.Price, Quantity = i.Quantity,   Total = i.Quantity * i.Price})
                .ToList();
            dataGridView1.DataSource = data;

            int total = 0;
            foreach (var i in data)
            {
                total+= i.Total;
            }
            TotalPrice.Text = total.ToString() +"đ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProcessExportDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void maskedTextBoxPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBoxPrice.Text))
            {
                toolTip1.Show("Vui lòng không để trống", maskedTextBoxPrice, maskedTextBoxPrice.Width, 0, 1000);
                e.Cancel = true;
                return;
            }
            if (Convert.ToInt32(maskedTextBoxPrice.Text) <= 0)
            {
                toolTip1.Show("Số tiền phải lớn hơn 0", maskedTextBoxPrice, maskedTextBoxPrice.Width, 0, 1000);
                e.Cancel = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolTip1.Show("Lưu thành công", button2, button2.Width, 0, 1000);
        }
    }
}
