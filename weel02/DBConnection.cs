using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace weel02
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection((string)Properties.Settings.Default.cnnStr);
        public DataTable DanhSach(string sqlStr)
        {
            DataTable dtSinhVien = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtSinhVien);
                //gvHsinh.DataSource = dtSinhVien; /// gvHsinh = name cua data gridview
                return dtSinhVien;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
            finally
            {
                conn.Close();

            }
        }

        public void Thucthi(string sqlStr)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thuc Thi thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
