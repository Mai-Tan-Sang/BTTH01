using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace weel02
{
    class HocSinhDAO
    {
        DBConnection DBConn = new DBConnection();
        public void Them(HocSinh hocsinh)
        {
            string sqlStr = string.Format("INSERT INTO Hocsinh(Ten , Diachi , Cmnd) VALUES ('{0}', '{1}','{2}')", hocsinh.Hoten, hocsinh.Diachi, hocsinh.Cmnd);
            DBConn.Thucthi(sqlStr);
        }

        public void Xoa(HocSinh hocsinh)
        {
            string sqlStr = string.Format("DELETE FROM HocSinh WHERE Ten={0}", hocsinh.Hoten);
            DBConn.Thucthi(sqlStr);
        }

        public void Sua(HocSinh hocsinh)
        {
            string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi ='{1}' WHERE Cmnd = {2}", hocsinh.Hoten, hocsinh.Diachi, hocsinh.Cmnd);
            DBConn.Thucthi(sqlStr);
        }

        public DataTable DanhSachSV()
        {
            string sqlStr = string.Format("SELECT *FROM HocSinh");
            return DBConn.DanhSach(sqlStr);
        }
    }
}
