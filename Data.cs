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
using DGVPrinterHelper;

namespace Perpustakaan
{
    public partial class Data : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HDDLAL19\SQLEXPRESS;Initial Catalog=db_latihan;Integrated Security=True");
        public Data()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        private void Data_Load(object sender, EventArgs e)
        {
            display_data();
            tb_today.Text = DateTime.Now.ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [tb_perpus] where nama_buku like ('%" + tb_search.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            tb_search.Text = "";
        }

        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [tb_perpus]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            con.Close();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Laporan Data Peminjaman Buku";
            printer.SubTitle = string.Format("Tanggal {0}", DateTime.Now.Date.ToString("dddd-MMMM-yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "by POH";
            printer.PrintPreviewDataGridView(dataGridView1);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete this?";
            string title = "Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [tb_perpus] Where code_buku = '" + tb_delete.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                tb_search.Text = "";
                display_data();
            }
            else
            {
                //Do something
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit editform = new Edit();
            editform.Show();
            this.Visible = false;
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            Form1 form1form = new Form1();
            form1form.Show();
            this.Visible = false;
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bnt_logout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to leave?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                login loginform = new login();
                loginform.Show();
                this.Visible = false;
            }
            else
            {
                //Do something
            }
        }

        private void tb_today_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
