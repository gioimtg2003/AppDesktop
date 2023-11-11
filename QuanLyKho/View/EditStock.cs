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
using System.Xml.Linq;
using QuanLyKho.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKho
{
    public partial class EditStock : Form
    {
        private Stock stock;
        private long StockID;
        private Context db = new Context();
        Context ConnectDB = new Context();
        public EditStock(long StockID)
        {
            InitializeComponent();
            this.StockID = StockID;
        }

        //Nút lưu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                stock.Name = txtStockname.Text;
                stock.Address = rStockAddress.Text;
                using (var db = new Context())
                {
                    ConnectDB.SaveChanges();
                }
                txtStockname.Text = null;
                rStockAddress.Text = null;
                toolTip1.Show("Lưu thành công.", button1, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, button1, 0, 0, 1000);
            }
            txtStockname.Focus();
        }

        private void fEditStock_Load(object sender, EventArgs e)
        {
            stock = db.Stocks.Single(p => p.StockID == StockID);
            txtStockname.Text = stock.Name;
            rStockAddress.Text = stock.Address;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fEditStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
