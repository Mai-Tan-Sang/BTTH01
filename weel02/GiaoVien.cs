using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weel02
{
    public class GiaoVien
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

        public GiaoVien(string HoTen, string DiaChi, string CmNd)
        {
            hoten = HoTen;
            diachi = DiaChi;
            cmnd = CmNd;
        }
        ~GiaoVien()
        { }
    }
}
