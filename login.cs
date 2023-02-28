using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Perpustakaan
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HDDLAL19\SQLEXPRESS;Initial Catalog=db_latihan;Integrated Security=True");
        public login()
        {
            InitializeComponent();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_out_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bnt_sign_In_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tb_login where username=@username and paswword=@password", con);
            cmd.Parameters.AddWithValue("@username", tb_email.Text);
            cmd.Parameters.AddWithValue("@password", tb_password.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form1 form1form = new Form1();
                form1form.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
            con.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
