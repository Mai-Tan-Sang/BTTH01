using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace weel02
{
    class GiaoVienDao
    {
        DBConnection DBConn = new DBConnection();
        public void Them(GiaoVien giaovien)
        {
            string sqlStr = string.Format("INSERT INTO GiaoVien(Ten , Diachi , Cmnd) VALUES ('{0}', '{1}','{2}')", giaovien.Hoten, giaovien.Diachi, giaovien.Cmnd);
            DBConn.Thucthi(sqlStr);
        }

        public void Xoa(GiaoVien giaovien)
        {
            string sqlStr = string.Format("DELETE FROM GiaoVien WHERE Ten={0}", giaovien.Hoten);
            DBConn.Thucthi(sqlStr);
        }

        public void Sua(GiaoVien giaovien)
        {
            string sqlStr = string.Format("UPDATE GiaoVien SET Ten = '{0}', DiaChi ='{1}' WHERE Cmnd = {2}", giaovien.Hoten, giaovien.Diachi, giaovien.Cmnd);
            DBConn.Thucthi(sqlStr);
        }

        public DataTable DanhSachGV()
        {
            string sqlStr = string.Format("SELECT *FROM GiaoVien");
            return DBConn.DanhSach(sqlStr);
        }
    }
}
