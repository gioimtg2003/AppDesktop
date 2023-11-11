using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class Product
    {
        public Product() {
            this.StockDetails = new HashSet<StockDetail>();
            this.ImportDetails= new HashSet<ImportDetail>();
        }
        public long ProductID { get; set; }
        [Column(TypeName = ("nvarchar(100)"))]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? Description { get; set; }
        
        public ICollection<StockDetail> StockDetails { get; set; }
        public ICollection<ImportDetail> ImportDetails { get; set; }
    }
}
