using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class ImportBill
    {
        public ImportBill() {
            this.ImportDetails = new HashSet<ImportDetail>();  
        }
        public int ImportBillID { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? Description { get; set;}
        [Column(TypeName = "Date")]
        public DateTime CreateDate { get; set; }
        public int AdministratorID { get; set; }
        public int StockID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public Administrator Administrator { get; set; }
        public Stock Stock { get; set; }
        public ICollection<ImportDetail> ImportDetails { get; set; }
    }
}
