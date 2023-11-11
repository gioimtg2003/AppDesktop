using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class ExportBillDetail
    {
        public ExportBillDetail() { 
            this.exportProductDetails = new HashSet<ExportProductDetail>();
        }
        public int ExportBillDetailID { get; set; }
        public int ExportBillID { get; set; }
        public ExportBill ExportBill { get; set; }
        public ICollection<ExportProductDetail> exportProductDetails { get; set; }
    }
}
