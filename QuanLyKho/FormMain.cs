﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            if (Utility.isOpeningForm("ImportManage")) return;
            ImportManage form = new ImportManage();
            form.MdiParent = this;

            form.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                if(Utility.Employee.Role != 1)
                {
                    foreach(ToolStripMenuItem item in menuStrip1.Items)
                    {
                        foreach (ToolStripItem i in item.DropDownItems)
                        {
                            if(i.Name.Contains("Add") && Utility.Employee.Role == 2)
                            {
                                break;
                            }
                            i.Enabled = false;
                        }
                    }
                }
            }
            else
            {

            }
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            if (Utility.isOpeningForm("ProcessImportDetail")) return;
            ProcessImportDetail form = new ProcessImportDetail();
            form.MdiParent = this;
            form.Show();
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            if (Utility.isOpeningForm("ExportManage")) return;
            var form = new ExportManage();
            form.MdiParent = this;
            form.Show();
        }

        private void chiTiếtXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            if (Utility.isOpeningForm("ProcessExportDetail")) return;
            var form = new ProcessExportDetail();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            if (Utility.isOpeningForm("CustomerManage")) return;
            var form = new CustomerManage();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            if (Utility.isOpeningForm("ProductManage")) return;
            var form = new ProductManage();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            if (Utility.isOpeningForm("StockManage")) return;
            var form = new StockManage();
            form.MdiParent = this;
            form.Show();
        }

        private void AddImportStock_Click(object sender, EventArgs e)
        {
            if (Utility.isOpeningForm("AddImportBill")) return;
            var form = new AddImportBill();
            form.Show();
        }

        private void AddExportStock_Click(object sender, EventArgs e)
        {
            if (Utility.isOpeningForm("AddExportBill")) return;
            var form = new AddExportBill();
            form.Show();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            if (Utility.isOpeningForm("AddCustomer")) return;
            var form = new AddCustomer();
            form.Show();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            if (Utility.isOpeningForm("AddProduct")) return;
            var form = new AddProduct();
            form.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {

        }
    }
}
