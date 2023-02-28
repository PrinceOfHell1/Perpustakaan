using BarcodeLib;
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

namespace Perpustakaan
{
    public partial class Edit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HDDLAL19\SQLEXPRESS;Initial Catalog=db_latihan;Integrated Security=True");
        public Edit()
        {
            InitializeComponent();
        }
        string imgLocation = "";
        SqlCommand cmd;

        private void Edit_Load(object sender, EventArgs e)
        {
            tb_today.Text = DateTime.Now.ToString();
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            Data dataform = new Data();
            dataform.Show();
            this.Visible = false;
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
            cmd.CommandText = "update [tb_perpus] set code_buku='" + this.tb_code_buku.Text + "', nama_buku='" + this.cb_namaBuku.Text + "',tanggal_pinjam='" + this.tb_today.Text + "',tanggal_kembali='" + this.cb_tanggalP.Text + "/" + this.cb_bulanP.Text + "/" + this.cb_tahunP.Text + "',status='" + sirkulas + "', foto_buku=@images where code_buku='" + this.tb_code_buku.Text + "'";
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
            MessageBox.Show("Data Berhasil Di Update");
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

        private void cbx_pinjam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_pinjam.Checked == true)
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

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
