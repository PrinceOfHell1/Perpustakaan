using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using DGVPrinterHelper;
using Microsoft.SqlServer.Server;
using BarcodeLib;

namespace Perpustakaan
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HDDLAL19\SQLEXPRESS;Initial Catalog=db_latihan;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        string imgLocation = "";
        SqlCommand cmd;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_today.Text = DateTime.Now.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_code_buku.Clear();
            cb_namaBuku.Text = "";
            cb_tanggalP.Text = "";
            cb_bulanP.Text = "";
            cb_tahunP.Text = "";
            cbx_pinjam.Checked = false;
            cbx_kembali.Checked = false;
            pb_fotoBuku.Image.Tag = null;
            pb_barcode.Image.Tag = null;
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            string sirkulas = "";
            bool isChecked = cbx_pinjam.Checked;
            if (isChecked)
                sirkulas = cbx_pinjam.Text;
            else
                sirkulas = cbx_kembali.Text;

            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [tb_perpus] (code_buku,nama_buku,tanggal_pinjam,tanggal_kembali,status,foto_buku) values ('" + tb_code_buku.Text + "','" + cb_namaBuku.Text + "','" + tb_today.Text + "','" + cb_tanggalP.Text + "/" + cb_bulanP.Text + "/" + cb_tahunP.Text + "','" + sirkulas + "',@images)";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succes");

            tb_code_buku.Clear();
            cb_namaBuku.Text = "";
            cb_tanggalP.Text = "";
            cb_bulanP.Text = "";
            cb_tahunP.Text = "";
            cbx_pinjam.Checked = false;
            cbx_kembali.Checked = false;
            pb_fotoBuku.Image.Tag = null;
            pb_barcode.Image.Tag = null;
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pb_fotoBuku.ImageLocation = imgLocation;
                //pb_barcode.ImageLocation = imgLocation;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [tb_perpus] Where code_buku = '" + tb_code_buku.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            tb_code_buku.Text = "";
            display_data();
            MessageBox.Show("Data delete successfully");
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string sirkulas = "";
            bool isChecked = cbx_pinjam.Checked;
            if (isChecked)
                sirkulas = cbx_pinjam.Text;
            else
                sirkulas = cbx_kembali.Text;

            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [tb_perpus] set code_buku='" + this.tb_code_buku.Text + "', nama_buku='" + this.cb_namaBuku.Text + "',tanggal_pinjam='" +this.tb_today.Text+ "',tanggal_kembali='" +this.cb_tanggalP.Text+ "/" +this.cb_bulanP.Text+ "/" +this.cb_tahunP.Text+ "',status='" +sirkulas+ "', foto_buku=@images where code_buku='" + this.tb_code_buku.Text + "'";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();

            con.Close();
            tb_code_buku.Clear();
            cb_namaBuku.Text = "";
            cb_tanggalP.Text = "";
            cb_bulanP.Text = "";
            cb_tahunP.Text = "";
            cbx_pinjam.Checked = false;
            cbx_kembali.Checked = false;
            pb_fotoBuku.Image.Tag = null;
            pb_barcode.Image.Tag = null;
            display_data();
            MessageBox.Show("Data Berhasil Di Update");
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
            //dataGridView1.DataSource = dta;
            con.Close();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            tb_tanggal.Text = DateTime.Now.ToString();
        }

        private void btn_browse1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pb_barcode.ImageLocation = imgLocation;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rb_pinjam_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rb_kembalikan_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_end_Click(object sender, EventArgs e)
        {
        
        }

        private void cbx_Pinjam_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx_pinjam.Checked == true)
            {
                cbx_kembali.Checked = false;
            }
        }

        private void cbx_kembali_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_kembali.Checked == true)
            {
                cbx_pinjam.Checked = false;
            }
        }

        private void cb_jenisBuku_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_namaBuku_TextChanged(object sender, EventArgs e)
        {

        }

        private void pb_barcode3_Click(object sender, EventArgs e)
        {

        }

        private void cb_code_buku_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_encode_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            int width = (int)(pb_barcode.Width * 0.8);
            int height = (int)(pb_barcode.Height * 0.8);
            Image image = barcode.Encode(TYPE.CODE39, cb_namaBuku.Text, Color.Black, Color.Transparent, width, height);
            pb_barcode.Image = image;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Data dataform = new Data();
            dataform.Show();
            this.Visible = false;
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

        private void cb_namaBuku_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_namaBuku.Text == "SKI")
            {
                //cb_namaBuku.Items.Clear();
                Barcode barcode = new Barcode();
                int width = (int)(pb_barcode.Width * 0.8);
                int height = (int)(pb_barcode.Height * 0.8);
                Image image = barcode.Encode(TYPE.CODE128, cb_namaBuku.Text, Color.Black, Color.Transparent, width, height);
                pb_barcode.Image = image;
            }
            else if (cb_namaBuku.Text == "PJOK")
            {
                //cb_namaBuku.Items.Clear();
                Barcode barcode = new Barcode();
                int width = (int)(pb_barcode.Width * 0.8);
                int height = (int)(pb_barcode.Height * 0.8);
                Image image = barcode.Encode(TYPE.CODE128, cb_namaBuku.Text, Color.Black, Color.Transparent, width, height);
                pb_barcode.Image = image;
            }
            else if (cb_namaBuku.Text == "Informatika")
            {
                //cb_namaBuku.Items.Clear();
                Barcode barcode = new Barcode();
                int width = (int)(pb_barcode.Width * 0.8);
                int height = (int)(pb_barcode.Height * 0.8);
                Image image = barcode.Encode(TYPE.CODE128, cb_namaBuku.Text, Color.Black, Color.Transparent, width, height);
                pb_barcode.Image = image;
            }

        }

        private void cb_tanggalP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}