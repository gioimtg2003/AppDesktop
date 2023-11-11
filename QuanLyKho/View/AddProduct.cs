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
    public partial class AddProduct : Form
    {
        Product Product;
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fNewProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
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
                toolTip1.Show("Hãy nhập địa chỉ khách hàng?", rDescription, 0, 0,
               1000);
                rDescription.Focus();
                return;
            }

            try
            {
                //Tạo sp mới
                Product = new Product(); //Tạo một thể hiện cho spg mới
                Product.Name = txtName.Text;
                Product.Description = rDescription.Text;



                using (var connectDB = new Context())
                {
                    connectDB.Products.Add(Product); //Thêm khách hàng vào csdl
                    connectDB.SaveChanges(); //Lưu các thay đổi vào csdl
                }
                //Xóa trống và thiết lập lại các điều khiển
                txtName.Text = null;
                rDescription.Text = null;


                //dateTimePicker1.Text = null;//Không tác dụng

                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0,
               1000);
            }
            txtName.Focus();
        }
        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sản phẩm ?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Địa chỉ <= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }

        }
        private void rDescription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(rDescription.Text))
            {
                toolTip1.Show("Hãy nhập mô tả ?", rDescription, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (rDescription.Text.Length > 250)
            {
                toolTip1.Show("Địa chỉ <= 250 ký tự?", rDescription, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }

}
