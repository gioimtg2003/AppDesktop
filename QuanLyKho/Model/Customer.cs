using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class Customer
    {
        public Customer()
        {
            this.importBills = new HashSet<ImportBill>();
            this.exportBills = new HashSet<ExportBill>();
        }
        public int CustomerID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public String Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public String Address { get; set; }
        [DataType(DataType.EmailAddress)]
        [Column(TypeName = "varchar(50)")]
        public String Email { get; set; }
        [Column(TypeName = "char(10)")]
        public String Phone { get; set; }
        public ICollection<ImportBill> importBills { get; set; }
        public ICollection<ExportBill> exportBills { get; set; } 
    }
}
