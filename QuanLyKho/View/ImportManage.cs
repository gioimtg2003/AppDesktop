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
    public partial class ImportManage : Form
    {
     
        public ImportManage()
        {
            InitializeComponent();
        }

        private void ImportManage_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {

            using (var db = new Context())
            {
                List<ImportGridViewData> data = new List<ImportGridViewData>();
                data = db.ImportBills.Include(
                    import => import.Customer).Include(
                    import => import.Administrator).Include(
                    import => import.Stock).Select(
                    import => new ImportGridViewData { ImportBillID = import.ImportBillID, CreateDate = import.CreateDate, Description = import.Description, NameCustomer = import.Customer.Name, AddressCustomer = import.Customer.Address, Phone = import.Customer.Phone, Email = import.Customer.Email, StockName = import.Stock.Name, StockAddress = import.Stock.Address, AdministratorName = import.Administrator.Name}).ToList();
                dataGridView1.DataSource = data;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Utility.isOpeningForm("AddImportBill")) return;
            AddImportBill form = new AddImportBill();
            form.addBill += (sender, e) =>
            {
                loadData();
            };
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxMonth.Text))
            {
                toolTip1.Show("Vui lòng chọn tháng", comboBoxMonth, comboBoxMonth.Width, 0, 1000);
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxYear.Text))
            {
                toolTip1.Show("Vui lòng chọn năm", comboBoxYear, comboBoxYear.Width, 0, 1000);
                return;
            }
            int month = Convert.ToInt32(comboBoxMonth.Text);
            int year = Convert.ToInt32(comboBoxYear.Text);
            using (var db = new Context())
            {
                List<ImportGridViewData> data = new List<ImportGridViewData>();
                data = db.ImportBills
                    .Where(ib => ib.CreateDate.Month == month && ib.CreateDate.Year == year).Include(
                    import => import.Customer).Include(
                    import => import.Administrator).Include(
                    import => import.Stock).Select(
                    import => new ImportGridViewData { ImportBillID = import.ImportBillID, CreateDate = import.CreateDate, Description = import.Description, NameCustomer = import.Customer.Name, AddressCustomer = import.Customer.Address, Phone = import.Customer.Phone, Email = import.Customer.Email, StockName = import.Stock.Name, StockAddress = import.Stock.Address, AdministratorName = import.Administrator.Name }).ToList();
                dataGridView1.DataSource = data;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    int importBillID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ImportBillID"].Value);
                    using (var db = new Context())
                    {
                        ImportBill importBill = db.ImportBills.Single(cell => cell.ImportBillID == importBillID);
                        if (MessageBox.Show("Bạn có muốn xóa đơn hàng " + Convert.ToString(importBill.ImportBillID), "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.ImportBills.Remove(importBill);
                            db.SaveChanges();
                            loadData();
                        }
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                int importBillID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ImportBillID"].Value);
                EditImportBill form = new EditImportBill(importBillID);
                form.editBill += (sender, e) => { 
                    loadData();
                };
                form.Show();
            }
        }
    }
}
