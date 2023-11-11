﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class ImportGridViewData
    {
        public int ImportBillID { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public string NameCustomer { get; set; }
        public string AddressCustomer { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string StockName { get; set; }
        public string StockAddress { get; set;}
        public string AdministratorName { get; set; }
    }
}
