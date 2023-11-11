using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class StockDetail
    {
        public StockDetail() { 
            this.ExportProducts = new HashSet <ExportProductDetail>();
        }
        public int StockDetailID { get; set; }
        public long ProductID { get; set; }
        public int StockID { get; set; }
        public int Quantity { get; set; }
        public int UnitID { get; set; }
        public Unit Unit { get; set; }
        public Product Product { get; set; }
        public Stock Stock { get; set; }
        public ICollection<ExportProductDetail> ExportProducts { get; set; }
    }
}
