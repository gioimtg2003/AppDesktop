using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class ExportBill
    {
        public int ExportBillID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Description { get; set; }
        public int CustomerID { get; set; }
        public int AdministratorID { get; set; }
        [Column(TypeName = "Date")]
        public DateTime CreateDate { get; set; }
        public Customer Customer { get; set; }
        public Administrator Administrator { get; set; }

    }
}
