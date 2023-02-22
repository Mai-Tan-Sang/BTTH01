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
    public partial class Form1 : Form
    {

        HocSinhDAO hsd = new HocSinhDAO();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            HienDSSV();
        }

        private void HienDSSV()
        {
            this.gvHsinh.DataSource = hsd.DanhSachSV();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            HocSinh hocsinh = new HocSinh(textBox1.Text, textBox2.Text, textBox3.Text);
            hsd.Them(hocsinh);
            HienDSSV();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            HocSinh hocsinh = new HocSinh(textBox1.Text, textBox2.Text, textBox3.Text);
            hsd.Xoa (hocsinh);
            HienDSSV();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            HocSinh hocsinh = new HocSinh(textBox1.Text, textBox2.Text, textBox3.Text);
            hsd.Sua(hocsinh);
            HienDSSV();
        }

        private void GvHsinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    
