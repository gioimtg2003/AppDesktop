using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class Stock
    {
        public Stock() {
            this.StockDetails = new HashSet<StockDetail>();
            this.ImportBill = new HashSet<ImportBill>();
        }
        public int StockID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }
        public ICollection<StockDetail> StockDetails { get; set; }
        public ICollection<ImportBill> ImportBill { get; set; }
    }
}
