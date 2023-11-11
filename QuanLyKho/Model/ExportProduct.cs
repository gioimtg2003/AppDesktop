using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class ExportProduct
    {
        public int ExportProductDetailID { get; set; }
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int UnitID { get; set; }
        public int StockID { get; set; }
        public int TotalPrice { get { return Quantity * ProductPrice; } }
    }
}
