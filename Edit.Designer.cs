namespace Perpustakaan
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.cb_namaBuku = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.bnt_logout = new System.Windows.Forms.Button();
            this.cb_tanggalP = new System.Windows.Forms.ComboBox();
            this.tb_code_buku = new System.Windows.Forms.TextBox();
            this.cbx_kembali = new System.Windows.Forms.CheckBox();
            this.cbx_pinjam = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_bulanP = new System.Windows.Forms.ComboBox();
            this.cb_tahunP = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_today = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pb_barcode = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.pb_fotoBuku = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_out = new System.Windows.Forms.Button();
            this.tb_tanggal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoBuku)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_namaBuku
            // 
            this.cb_namaBuku.FormattingEnabled = true;
            this.cb_namaBuku.Items.AddRange(new object[] {
            "SKI",
            "PJOK",
            "Informatika"});
            this.cb_namaBuku.Location = new System.Drawing.Point(238, 234);
            this.cb_namaBuku.Name = "cb_namaBuku";
            this.cb_namaBuku.Size = new System.Drawing.Size(151, 28);
            this.cb_namaBuku.TabIndex = 89;
            this.cb_namaBuku.SelectedIndexChanged += new System.EventHandler(this.cb_namaBuku_SelectedIndexChanged);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(216)))), ((int)(((byte)(164)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(364, 91);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(78, 29);
            this.btn_back.TabIndex = 88;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // bnt_logout
            // 
            this.bnt_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(216)))), ((int)(((byte)(164)))));
            this.bnt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_logout.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnt_logout.ForeColor = System.Drawing.Color.White;
            this.bnt_logout.Location = new System.Drawing.Point(448, 91);
            this.bnt_logout.Name = "bnt_logout";
            this.bnt_logout.Size = new System.Drawing.Size(78, 29);
            this.bnt_logout.TabIndex = 87;
            this.bnt_logout.Text = "LOGOUT";
            this.bnt_logout.UseVisualStyleBackColor = false;
            this.bnt_logout.Click += new System.EventHandler(this.bnt_logout_Click);
            // 
            // cb_tanggalP
            // 
            this.cb_tanggalP.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_tanggalP.FormattingEnabled = true;
            this.cb_tanggalP.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.cb_tanggalP.Location = new System.Drawing.Point(240, 282);
            this.cb_tanggalP.Name = "cb_tanggalP";
            this.cb_tanggalP.Size = new System.Drawing.Size(57, 26);
            this.cb_tanggalP.TabIndex = 86;
            // 
            // tb_code_buku
            // 
            this.tb_code_buku.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_code_buku.Location = new System.Drawing.Point(238, 191);
            this.tb_code_buku.Name = "tb_code_buku";
            this.tb_code_buku.PlaceholderText = "...";
            this.tb_code_buku.Size = new System.Drawing.Size(125, 26);
            this.tb_code_buku.TabIndex = 85;
            // 
            // cbx_kembali
            // 
            this.cbx_kembali.AutoSize = true;
            this.cbx_kembali.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_kembali.Location = new System.Drawing.Point(335, 327);
            this.cbx_kembali.Name = "cbx_kembali";
            this.cbx_kembali.Size = new System.Drawing.Size(81, 22);
            this.cbx_kembali.TabIndex = 84;
            this.cbx_kembali.Text = "Kembali";
            this.cbx_kembali.UseVisualStyleBackColor = true;
            this.cbx_kembali.CheckedChanged += new System.EventHandler(this.cbx_kembali_CheckedChanged);
            // 
            // cbx_pinjam
            // 
            this.cbx_pinjam.AutoSize = true;
            this.cbx_pinjam.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_pinjam.Location = new System.Drawing.Point(240, 327);
            this.cbx_pinjam.Name = "cbx_pinjam";
            this.cbx_pinjam.Size = new System.Drawing.Size(75, 22);
            this.cbx_pinjam.TabIndex = 83;
            this.cbx_pinjam.Text = "Pinjam";
            this.cbx_pinjam.UseVisualStyleBackColor = true;
            this.cbx_pinjam.CheckedChanged += new System.EventHandler(this.cbx_pinjam_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(200, 331);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 18);
            this.label15.TabIndex = 82;
            this.label15.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(200, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 18);
            this.label14.TabIndex = 81;
            this.label14.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(34, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 18);
            this.label13.TabIndex = 80;
            this.label13.Text = "Status";
            // 
            // cb_bulanP
            // 
            this.cb_bulanP.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_bulanP.FormattingEnabled = true;
            this.cb_bulanP.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.cb_bulanP.Location = new System.Drawing.Point(303, 282);
            this.cb_bulanP.Name = "cb_bulanP";
            this.cb_bulanP.Size = new System.Drawing.Size(118, 26);
            this.cb_bulanP.TabIndex = 79;
            // 
            // cb_tahunP
            // 
            this.cb_tahunP.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_tahunP.FormattingEnabled = true;
            this.cb_tahunP.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024"});
            this.cb_tahunP.Location = new System.Drawing.Point(427, 282);
            this.cb_tahunP.Name = "cb_tahunP";
            this.cb_tahunP.Size = new System.Drawing.Size(88, 26);
            this.cb_tahunP.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(34, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 18);
            this.label11.TabIndex = 77;
            this.label11.Text = "Tanggal Pengembalian";
            // 
            // tb_today
            // 
            this.tb_today.Font = new System.Drawing.Font("Verdana Pro Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_today.Location = new System.Drawing.Point(329, 58);
            this.tb_today.Name = "tb_today";
            this.tb_today.ReadOnly = true;
            this.tb_today.Size = new System.Drawing.Size(197, 26);
            this.tb_today.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(86, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 75;
            this.label10.Text = "Barcode Buku";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(340, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 74;
            this.label9.Text = "Foto Buku";
            // 
            // pb_barcode
            // 
            this.pb_barcode.Image = ((System.Drawing.Image)(resources.GetObject("pb_barcode.Image")));
            this.pb_barcode.Location = new System.Drawing.Point(30, 428);
            this.pb_barcode.Name = "pb_barcode";
            this.pb_barcode.Size = new System.Drawing.Size(216, 150);
            this.pb_barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_barcode.TabIndex = 73;
            this.pb_barcode.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(216)))), ((int)(((byte)(164)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Verdana Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(34, 141);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(61, 29);
            this.btn_clear.TabIndex = 71;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(216)))), ((int)(((byte)(164)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Verdana Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(34, 714);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(479, 58);
            this.btn_edit.TabIndex = 70;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(198, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 20);
            this.label8.TabIndex = 69;
            this.label8.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(197, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 18);
            this.label5.TabIndex = 68;
            this.label5.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 67;
            this.label3.Text = "Nama Buku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Code Buku";
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(216)))), ((int)(((byte)(164)))));
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_browse.ForeColor = System.Drawing.Color.White;
            this.btn_browse.Location = new System.Drawing.Point(340, 651);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(76, 29);
            this.btn_browse.TabIndex = 65;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // pb_fotoBuku
            // 
            this.pb_fotoBuku.Image = ((System.Drawing.Image)(resources.GetObject("pb_fotoBuku.Image")));
            this.pb_fotoBuku.Location = new System.Drawing.Point(303, 428);
            this.pb_fotoBuku.Name = "pb_fotoBuku";
            this.pb_fotoBuku.Size = new System.Drawing.Size(151, 217);
            this.pb_fotoBuku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_fotoBuku.TabIndex = 64;
            this.pb_fotoBuku.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_out);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 51);
            this.panel1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana Pro Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edit Data";
            // 
            // btn_out
            // 
            this.btn_out.BackColor = System.Drawing.Color.Red;
            this.btn_out.ForeColor = System.Drawing.Color.White;
            this.btn_out.Location = new System.Drawing.Point(507, 10);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(29, 29);
            this.btn_out.TabIndex = 0;
            this.btn_out.Text = "X";
            this.btn_out.UseVisualStyleBackColor = false;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // tb_tanggal
            // 
            this.tb_tanggal.Location = new System.Drawing.Point(10, 13);
            this.tb_tanggal.Name = "tb_tanggal";
            this.tb_tanggal.Size = new System.Drawing.Size(200, 27);
            this.tb_tanggal.TabIndex = 62;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 809);
            this.Controls.Add(this.cb_namaBuku);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.bnt_logout);
            this.Controls.Add(this.cb_tanggalP);
            this.Controls.Add(this.tb_code_buku);
            this.Controls.Add(this.cbx_kembali);
            this.Controls.Add(this.cbx_pinjam);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_bulanP);
            this.Controls.Add(this.cb_tahunP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_today);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pb_barcode);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.pb_fotoBuku);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_tanggal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoBuku)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cb_namaBuku;
        private Button btn_back;
        private Button bnt_logout;
        private ComboBox cb_tanggalP;
        private TextBox tb_code_buku;
        private CheckBox cbx_kembali;
        private CheckBox cbx_pinjam;
        private Label label15;
        private Label label14;
        private Label label13;
        private ComboBox cb_bulanP;
        private ComboBox cb_tahunP;
        private Label label11;
        private TextBox tb_today;
        private Label label10;
        private Label label9;
        private PictureBox pb_barcode;
        private Button btn_clear;
        private Button btn_edit;
        private Label label8;
        private Label label5;
        private Label label3;
        private Label label1;
        private Button btn_browse;
        private PictureBox pb_fotoBuku;
        private Panel panel1;
        private Button btn_out;
        private TextBox tb_tanggal;
        private Label label2;
    }
}