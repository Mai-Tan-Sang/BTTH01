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
    public partial class Form3 : Form
    {
        GiaoVienDao gvd = new GiaoVienDao();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiaoVien giaovien = new GiaoVien(textBox1.Text, textBox2.Text, textBox3.Text);
            gvd.Them(giaovien);
            HienDSGV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GiaoVien giaovien = new GiaoVien(textBox1.Text, textBox2.Text, textBox3.Text);
            gvd.Xoa(giaovien);
            HienDSGV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GiaoVien giaovien = new GiaoVien(textBox1.Text, textBox2.Text, textBox3.Text);
            gvd.Sua(giaovien);
            HienDSGV();
        }

        private void HienDSGV()
        {
            this.gvHsinh.DataSource = gvd.DanhSachGV();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            HienDSGV();
        }
    }
}
