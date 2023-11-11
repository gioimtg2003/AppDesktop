using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.Model;

namespace QuanLyKho
{
    public partial class EditProduct : Form
    {
        Product Product;
        long ProductID;
        Context ConnectDB = new Context();
        public EditProduct(long ProductID)
        {
            InitializeComponent();
            this.ProductID = ProductID;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sản phẩm ?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(rDescription.Text))
            {
                toolTip1.Show("Hãy nhập điện thoại?", rDescription, 0, 0, 1000);
                rDescription.Focus();
                return;
            }
            try
            {
                Product.Name = txtName.Text;
                Product.Description = rDescription.Text;


                ConnectDB.SaveChanges(); //Lưu các thay đổi vào csdl
                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
                //btClose.PerformClick();
                btClose.Focus();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên khách hàng?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên khách hàng <= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void rDescription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rDescription.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ?", rDescription, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (rDescription.Text.Length > 250)
            {
                toolTip1.Show("Địa chỉ <= 250 ký tự?", rDescription, 0, 0, 1000);
                e.Cancel = true;
            }
        }





        private void fEditProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void fEditProduct_Load(object sender, EventArgs e)
        {
            Product = ConnectDB.Products.Single(p => p.ProductID == ProductID);
            Text += " - Mã KH " + Product.ProductID.ToString();
            txtName.Text = Product.Name;
            rDescription.Text = Product.Description;

        }

        private void EditProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
