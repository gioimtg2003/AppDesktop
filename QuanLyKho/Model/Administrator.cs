using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class Administrator
    {
        public Administrator() { 
            this.ImportBills = new HashSet<ImportBill>();
            this.exportBills= new HashSet<ExportBill>();
        }
        public int AdministratorID { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }
        [Column(TypeName = "char(20)")]
        public string UserName { get; set; }
        [Column(TypeName = "char(16)")]
        public string Password { get; set; }
        [DataType(DataType.EmailAddress)]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
        [Column(TypeName = "char(10)")]
        public string Phone { get; set; }
        public byte Role { get; set; }
        public ICollection<ImportBill> ImportBills { get; set; }
        public ICollection<ExportBill> exportBills { get; set; }

    }
}
