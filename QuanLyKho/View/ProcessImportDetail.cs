using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.Model;

namespace QuanLyKho
{
    public partial class ProcessImportDetail : Form
    {
        private int stockID;
        public ProcessImportDetail()
        {
            InitializeComponent();
        }

        private void ProcessImportDetail_Load(object sender, EventArgs e)
        {
            maskedTextBoxNameAdmin.Text = Utility.Employee.Name;
            using (var db = new Context())
            {
                comboBoxImportBill.DataSource = db.ImportBills.Select(ip => ip.ImportBillID).ToList();
                comboBoxProduct.DisplayMember = "Name";
                comboBoxProduct.ValueMember = "ProductID";
                comboBoxProduct.DataSource = db.Products.Select(product => new { product.Name, product.ProductID }).ToList();

                comboBoxUnit.DisplayMember = "Name";
                comboBoxUnit.ValueMember = "UnitID";
                comboBoxUnit.DataSource = db.Units.Select(unit => new { unit.Name, unit.UnitID }).ToList();
            }
        }

        private void comboBoxImportBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ImportBillID = Convert.ToInt32(comboBoxImportBill.SelectedValue);
            using(var db = new Context())
            {
                var import = db.ImportBills.Include(
                    i => i.Customer).Include(i => i.Stock).SingleOrDefault(i => i.ImportBillID == ImportBillID);
                if (import != null)
                {
                    // nhà cung cấp
                    maskedTextBoxSuplier.Text = import.Customer.Name;
                    maskedTextBoxEmail.Text = import.Customer.Email;
                    maskedTextBoxAddress.Text = import.Customer.Address;
                    maskedTextBoxPhone.Text = import.Customer.Phone;
                    //
                    maskedTextBoxDescription.Text = import.Description;
                    comboBoxStock.Text = import.Stock.Name;
                    stockID = import.Stock.StockID;
                    maskedTextBoxStockAddress.Text = import.Stock.Address;
                }
            }
            loadDataDetail();
        }

        
        private void loadDataDetail()
        {
            using(var db = new Context())
            {
                int total = 0;
                var details = db.ImportDetail.Where(i => i.ImportBillID == Convert.ToInt32(comboBoxImportBill.SelectedValue)).Include(
                    i => i.Product).Select(i => new ImportProduct { ImportDetailID = i.ImportDetailID , ProductID = i.ProductID, ProductName = i.Product.Name, ProductPrice = i.Price, Quantity = i.Quantity, UnitID = i.UnitID}).ToList();
                foreach(var item in details)
                {
                    total += Convert.ToInt32(item.TotalPrice);
                }
                textBox1.Text = total.ToString() + "đ";
                dataGridView1.DataSource = details;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using(var db = new Context())
                {
                    int importBillID = Convert.ToInt32(comboBoxImportBill.SelectedValue);
                    ImportDetail importDetail = new ImportDetail();
                    importDetail.ImportBillID = importBillID;
                    importDetail.ProductID = Convert.ToInt32(comboBoxProduct.SelectedValue);
                    importDetail.Price = Convert.ToInt32(maskedTextBoxPrice.Text);
                    importDetail.Quantity = Convert.ToInt32(maskedTextBoxQuantity.Text);
                    importDetail.UnitID = Convert.ToInt32(comboBoxUnit.SelectedValue);
                    db.ImportDetail.Add(importDetail);
                    db.SaveChanges();
                    var stockDetail = db.StockDetails.SingleOrDefault(stock => stock.StockID == stockID && stock.ProductID == Convert.ToInt32(comboBoxProduct.SelectedValue) && stock.UnitID == Convert.ToInt32(comboBoxUnit.SelectedValue));
                    if (stockDetail == null)
                    {
                        var stock = new StockDetail();
                        stock.StockID = stockID;
                        stock.ProductID = Convert.ToInt32(comboBoxProduct.SelectedValue);
                        stock.UnitID = Convert.ToInt32(comboBoxUnit.SelectedValue);
                        stock.Quantity = Convert.ToInt32(maskedTextBoxQuantity.Text);
                        db.StockDetails.Add(stock);
                        db.SaveChanges();
                }
                else
                    {
                    stockDetail.Quantity += Convert.ToInt32(maskedTextBoxQuantity.Text);
                        db.SaveChanges();
                    }
                    loadDataDetail();
                    maskedTextBoxQuantity.Text = null;
                    maskedTextBoxPrice.Text = null;
                    
                    toolTip1.Show("Thêm thành công", button1, button1.Width, 0, 1000);
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show("Erorr: " + ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImportDetail importDetail;
            for(int i = 0; i< dataGridView1.RowCount -1 ; i++)
            {
                importDetail = new ImportDetail();
                long productID = Convert.ToInt64(dataGridView1.Rows[i].Cells["ProductID"].Value);
            }
            toolTip1.Show("Lưu thành công", button2, button2.Width, 0, 1000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProcessImportDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {

                    int importDetailID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ImportDetaliID"].Value);
                    long productID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value);
                    int importDetailUnitID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["UnitID"].Value);
                    int importDetailQuantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);
                    using (var db = new Context())
                    {
                        var importDetail = db.ImportDetail.Single(import => import.ImportDetailID == importDetailID);
                        if (MessageBox.Show("Bạn muốn xóa " + importDetail.ImportDetailID, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var stockDetail = db.StockDetails.Single(i => i.StockID == stockID && i.ProductID == productID && i.UnitID == importDetailUnitID);
                            if (Convert.ToInt32(stockDetail.Quantity) > 0)
                            {
                                stockDetail.Quantity -= importDetailQuantity;
                                db.SaveChanges();
                                if (stockDetail.Quantity <= 0)
                                {
                                    db.Remove(stockDetail);
                                    db.SaveChanges();
                                }
                            }
                            db.Remove(importDetail);
                            db.SaveChanges();
                            loadDataDetail();
                        }
                        
                    }
                    
                }catch(Exception ex)
                {
                    MessageBox.Show("Error: " +ex.Message);
                }
            }
        }
    }
}
