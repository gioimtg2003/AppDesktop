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
            //LoginForm loginForm= new LoginForm();
            //if (loginForm.ShowDialog() == DialogResult.OK)
            //{
            //}
            //else
            //{

            //}
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

        
    }
}
