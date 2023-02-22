using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weel02
{
    public class HocSinh
    {
        private string hoten;
        private string diachi;
        private string cmnd;

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        public HocSinh(string HoTen, string DiaChi, string CmNd)
        {
            hoten = HoTen;
            diachi = DiaChi;
            cmnd = CmNd;
        }
        ~HocSinh()
        { }
    }
}
