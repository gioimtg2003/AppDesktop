using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Model;

namespace QuanLyKho
{
    internal class Utility
    {
        static public string ImagePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Images\";
        public static Administrator Employee { get; set; }
        public static bool isOpeningForm(string nameForm)
        {
            foreach (Form f in Application.OpenForms)
            {
                if ((string)f.Name == nameForm) return true;
            }
            return false;
        }
    }
}
