using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class Unit
    {
        public Unit() {
            this.StockDetails = new HashSet<StockDetail>();
            this.ImportDetails= new HashSet<ImportDetail>();

        }
        public int UnitID { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }
        public ICollection<StockDetail> StockDetails { get; set; }
        public ICollection<ImportDetail> ImportDetails { get; set; }
    }
}
