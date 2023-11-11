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
    public partial class ExportManage : Form
    {
        public ExportManage()
        {
            InitializeComponent();
        }

        private void ExportManage_Load(object sender, EventArgs e)
        {
            loadData();
            
        }
        private void loadData()
        {
            using (var db = new Context())
            {
                List<ExportManageDataGridView> data = new List<ExportManageDataGridView>();
                data = db.ExportBills.Include(
                    import => import.Customer).Include(
                    import => import.Administrator).Select(
                    import => new ExportManageDataGridView { ExportBillID = import.ExportBillID, CreateDate = import.CreateDate, Description = import.Description, NameCustomer = import.Customer.Name, AddressCustomer = import.Customer.Address, Phone = import.Customer.Phone, Email = import.Customer.Email, AdministratorName = import.Administrator.Name }).ToList();
                dataGridView1.DataSource = data;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Utility.isOpeningForm("AddExportBill")) return;
            var form = new AddExportBill();
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
                List<ExportManageDataGridView> data = new List<ExportManageDataGridView>();
                data = db.ExportBills
                    .Where(ib => ib.CreateDate.Month == month && ib.CreateDate.Year == year).Include(
                    import => import.Customer).Include(
                    import => import.Administrator).Select(
                    import => new ExportManageDataGridView
                    {
                        ExportBillID = import.ExportBillID, 
                        CreateDate = import.CreateDate, 
                        Description = import.Description, 
                        NameCustomer = import.Customer.Name, 
                        AddressCustomer = import.Customer.Address, 
                        Phone = import.Customer.Phone, 
                        Email = import.Customer.Email,
                        AdministratorName = import.Administrator.Name }).ToList();
                dataGridView1.DataSource = data;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    int exportBIllID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ExportBillID"].Value);
                    using (var db = new Context())
                    {
                        var exportBill = db.ExportBills.Single(cell => cell.ExportBillID == exportBIllID);
                        if (MessageBox.Show("Bạn có muốn xóa đơn hàng " + Convert.ToString(exportBill.ExportBillID), "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.ExportBills.Remove(exportBill);
                            db.SaveChanges();
                            loadData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                int exportBill = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ExportBillID"].Value);
                EditExportBill form = new EditExportBill(exportBill);
                form.editBill += (sender, e) => {
                    loadData();
                };
                form.Show();
            }
        }
    }
}
