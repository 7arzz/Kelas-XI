using System.Drawing;
using System.Windows.Forms;
using System;
using BromoSolutionEFADO.Properties;

namespace ContohSoal1.Customer
{
    partial class FormListPenerbangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListPenerbangan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxWaktu3 = new System.Windows.Forms.CheckBox();
            this.checkBoxWaktu4 = new System.Windows.Forms.CheckBox();
            this.checkBoxWaktu2 = new System.Windows.Forms.CheckBox();
            this.checkBoxWaktu1 = new System.Windows.Forms.CheckBox();
            this.dataGridViewListPenerbangan = new System.Windows.Forms.DataGridView();
            this.labelKeberangkatan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTujuan = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelPenumpang = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JamBerangkat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeliTiket = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPenerbangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(57, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(0, 0);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = " LIST PENERBANGAN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFilter);
            this.groupBox2.Controls.Add(this.comboBoxSort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkBoxWaktu3);
            this.groupBox2.Controls.Add(this.checkBoxWaktu4);
            this.groupBox2.Controls.Add(this.checkBoxWaktu2);
            this.groupBox2.Controls.Add(this.checkBoxWaktu1);
            this.groupBox2.Location = new System.Drawing.Point(6, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 151);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(600, 108);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(192, 26);
            this.buttonFilter.TabIndex = 3;
            this.buttonFilter.Text = "Terapkan Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Harga terendah",
            "Keberangakatan paling awal ",
            "Keberangkatan paling akhir",
            "Kedatangan paling awal",
            "Kedatangan paling akhir",
            "Durasi tercepat"});
            this.comboBoxSort.Location = new System.Drawing.Point(18, 124);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(160, 21);
            this.comboBoxSort.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Urutkan Berdasarkan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Waktu Penerbangan";
            // 
            // checkBoxWaktu3
            // 
            this.checkBoxWaktu3.AutoSize = true;
            this.checkBoxWaktu3.Location = new System.Drawing.Point(213, 40);
            this.checkBoxWaktu3.Name = "checkBoxWaktu3";
            this.checkBoxWaktu3.Size = new System.Drawing.Size(89, 17);
            this.checkBoxWaktu3.TabIndex = 0;
            this.checkBoxWaktu3.Text = "12.00 - 18.00";
            this.checkBoxWaktu3.UseVisualStyleBackColor = true;
            // 
            // checkBoxWaktu4
            // 
            this.checkBoxWaktu4.AutoSize = true;
            this.checkBoxWaktu4.Location = new System.Drawing.Point(309, 40);
            this.checkBoxWaktu4.Name = "checkBoxWaktu4";
            this.checkBoxWaktu4.Size = new System.Drawing.Size(89, 17);
            this.checkBoxWaktu4.TabIndex = 0;
            this.checkBoxWaktu4.Text = "18.00 - 00.00";
            this.checkBoxWaktu4.UseVisualStyleBackColor = true;
            // 
            // checkBoxWaktu2
            // 
            this.checkBoxWaktu2.AutoSize = true;
            this.checkBoxWaktu2.Location = new System.Drawing.Point(121, 40);
            this.checkBoxWaktu2.Name = "checkBoxWaktu2";
            this.checkBoxWaktu2.Size = new System.Drawing.Size(89, 17);
            this.checkBoxWaktu2.TabIndex = 0;
            this.checkBoxWaktu2.Text = "06.00 - 12.00";
            this.checkBoxWaktu2.UseVisualStyleBackColor = true;
            // 
            // checkBoxWaktu1
            // 
            this.checkBoxWaktu1.AutoSize = true;
            this.checkBoxWaktu1.Location = new System.Drawing.Point(29, 40);
            this.checkBoxWaktu1.Name = "checkBoxWaktu1";
            this.checkBoxWaktu1.Size = new System.Drawing.Size(89, 17);
            this.checkBoxWaktu1.TabIndex = 0;
            this.checkBoxWaktu1.Text = "00.00 - 06.00";
            this.checkBoxWaktu1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListPenerbangan
            // 
            this.dataGridViewListPenerbangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListPenerbangan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KodePenerbangan,
            this.Maskapai,
            this.BandaraKeberangkatan,
            this.BandaraTujuan,
            this.Harga,
            this.Tanggal,
            this.JamBerangkat,
            this.BeliTiket});
            this.dataGridViewListPenerbangan.Location = new System.Drawing.Point(-3, 217);
            this.dataGridViewListPenerbangan.Name = "dataGridViewListPenerbangan";
            this.dataGridViewListPenerbangan.Size = new System.Drawing.Size(851, 237);
            this.dataGridViewListPenerbangan.TabIndex = 5;
            this.dataGridViewListPenerbangan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelKeberangkatan
            // 
            this.labelKeberangkatan.AutoSize = true;
            this.labelKeberangkatan.Location = new System.Drawing.Point(57, 35);
            this.labelKeberangkatan.Name = "labelKeberangkatan";
            this.labelKeberangkatan.Size = new System.Drawing.Size(86, 13);
            this.labelKeberangkatan.TabIndex = 1;
            this.labelKeberangkatan.Text = "bandara A (BAA)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(157, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // labelTujuan
            // 
            this.labelTujuan.AutoSize = true;
            this.labelTujuan.Location = new System.Drawing.Point(204, 35);
            this.labelTujuan.Name = "labelTujuan";
            this.labelTujuan.Size = new System.Drawing.Size(86, 13);
            this.labelTujuan.TabIndex = 1;
            this.labelTujuan.Text = "bandara A (BAA)";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Location = new System.Drawing.Point(322, 35);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(94, 13);
            this.labelTanggal.TabIndex = 1;
            this.labelTanggal.Text = "Wed, 20 mei 2026";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = " ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(297, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(437, 35);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // labelPenumpang
            // 
            this.labelPenumpang.AutoSize = true;
            this.labelPenumpang.Location = new System.Drawing.Point(479, 36);
            this.labelPenumpang.Name = "labelPenumpang";
            this.labelPenumpang.Size = new System.Drawing.Size(72, 13);
            this.labelPenumpang.TabIndex = 1;
            this.labelPenumpang.Text = "0 penumpang";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // KodePenerbangan
            // 
            this.KodePenerbangan.DataPropertyName = "KodePenerbangan";
            this.KodePenerbangan.HeaderText = "Kode Penerbangan";
            this.KodePenerbangan.Name = "KodePenerbangan";
            // 
            // Maskapai
            // 
            this.Maskapai.DataPropertyName = "Maskapai";
            this.Maskapai.HeaderText = "Maskapai";
            this.Maskapai.Name = "Maskapai";
            // 
            // BandaraKeberangkatan
            // 
            this.BandaraKeberangkatan.DataPropertyName = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.HeaderText = "Bandara Keberangkatan";
            this.BandaraKeberangkatan.Name = "BandaraKeberangkatan";
            // 
            // BandaraTujuan
            // 
            this.BandaraTujuan.DataPropertyName = "BandaraTujuan";
            this.BandaraTujuan.HeaderText = "Bandara Tujuan";
            this.BandaraTujuan.Name = "BandaraTujuan";
            // 
            // Harga
            // 
            this.Harga.DataPropertyName = "HargaPerTiket";
            this.Harga.HeaderText = "Harga";
            this.Harga.Name = "Harga";
            // 
            // Tanggal
            // 
            this.Tanggal.DataPropertyName = "Tanggal";
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.Name = "Tanggal";
            // 
            // JamBerangkat
            // 
            this.JamBerangkat.DataPropertyName = "JamBerangkat";
            this.JamBerangkat.HeaderText = "Jam Keberangaktan";
            this.JamBerangkat.Name = "JamBerangkat";
            // 
            // BeliTiket
            // 
            this.BeliTiket.HeaderText = "Beli Tiket";
            this.BeliTiket.Name = "BeliTiket";
            this.BeliTiket.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BeliTiket.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BeliTiket.Text = "Beli Tiket";
            // 
            // FormListPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 448);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewListPenerbangan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPenumpang);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.labelTujuan);
            this.Controls.Add(this.labelKeberangkatan);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormListPenerbangan";
            this.Text = "FormListPenerbangan";
            this.Load += new System.EventHandler(this.FormListPenerbangan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPenerbangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewListPenerbangan;
        private Label label2;
        private CheckBox checkBoxWaktu1;
        private Button buttonFilter;
        private ComboBox comboBoxSort;
        private Label label3;
        private CheckBox checkBoxWaktu3;
        private CheckBox checkBoxWaktu4;
        private CheckBox checkBoxWaktu2;
        private Label labelKeberangkatan;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelTujuan;
        private Label labelTanggal;
        private Label label7;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label labelPenumpang;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn KodePenerbangan;
        private DataGridViewTextBoxColumn Maskapai;
        private DataGridViewTextBoxColumn BandaraKeberangkatan;
        private DataGridViewTextBoxColumn BandaraTujuan;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Tanggal;
        private DataGridViewTextBoxColumn JamBerangkat;
        private DataGridViewButtonColumn BeliTiket;
    }
}