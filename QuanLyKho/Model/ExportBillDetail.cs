﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class ExportBillDetail
    {
        public int ExportBillDetailID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int StockDetailID { get; set; }
        public int ExportBillID { get; set; }
        public ExportBill ExportBill { get; set; }
        public StockDetail StockDetail { get; set; }
    }
}
