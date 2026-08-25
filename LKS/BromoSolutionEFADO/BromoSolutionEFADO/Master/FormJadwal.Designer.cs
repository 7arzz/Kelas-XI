using System.Drawing;
using System.Windows.Forms;
using System;
using BromoSolutionEFADO.Properties;

namespace BromoSolutionEFADO.Master
{
    partial class FormJadwal
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
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewJadwal = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraAsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaskapaiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaPerTiket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurasiPenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaktuKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAsal = new System.Windows.Forms.ComboBox();
            this.comboBoxTujuan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMaskapai = new System.Windows.Forms.ComboBox();
            this.textBoxKodePenerbangan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownHargaTicket = new System.Windows.Forms.NumericUpDown();
            this.textBoxDurasi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerWaktuKeberangkatan = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJadwal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHargaTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(448, 217);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(54, 35);
            this.buttonSimpan.TabIndex = 22;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(448, 262);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(57, 31);
            this.buttonBatal.TabIndex = 23;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tujuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Asal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kode";
            // 
            // dataGridViewJadwal
            // 
            this.dataGridViewJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJadwal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KodePenerbangan,
            this.BandaraAsal,
            this.BandaraTujuan,
            this.MaskapaiID,
            this.TanggalKeberangkatan,
            this.HargaPerTiket,
            this.DurasiPenerbangan,
            this.WaktuKeberangkatan,
            this.Edit,
            this.Hapus});
            this.dataGridViewJadwal.Location = new System.Drawing.Point(3, 38);
            this.dataGridViewJadwal.Name = "dataGridViewJadwal";
            this.dataGridViewJadwal.Size = new System.Drawing.Size(502, 134);
            this.dataGridViewJadwal.TabIndex = 11;
            this.dataGridViewJadwal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJadwal_CellClick);
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
            // BandaraAsal
            // 
            this.BandaraAsal.DataPropertyName = "BandaraAsal";
            this.BandaraAsal.HeaderText = "Bandara Keberangkatan";
            this.BandaraAsal.Name = "BandaraAsal";
            // 
            // BandaraTujuan
            // 
            this.BandaraTujuan.DataPropertyName = "BandaraTujuan";
            this.BandaraTujuan.HeaderText = "Bandara Tujuan";
            this.BandaraTujuan.Name = "BandaraTujuan";
            // 
            // MaskapaiID
            // 
            this.MaskapaiID.DataPropertyName = "Maskapai";
            this.MaskapaiID.HeaderText = "Maskapai";
            this.MaskapaiID.Name = "MaskapaiID";
            // 
            // TanggalKeberangkatan
            // 
            this.TanggalKeberangkatan.DataPropertyName = "Tanggal";
            this.TanggalKeberangkatan.HeaderText = "Tanggal Keberangkatan";
            this.TanggalKeberangkatan.Name = "TanggalKeberangkatan";
            // 
            // HargaPerTiket
            // 
            this.HargaPerTiket.DataPropertyName = "HargaPerTiket";
            this.HargaPerTiket.HeaderText = "Harga Per Tiket";
            this.HargaPerTiket.Name = "HargaPerTiket";
            // 
            // DurasiPenerbangan
            // 
            this.DurasiPenerbangan.DataPropertyName = "DurasiPenerbangan";
            this.DurasiPenerbangan.HeaderText = "Durasi Penerbangan";
            this.DurasiPenerbangan.Name = "DurasiPenerbangan";
            // 
            // WaktuKeberangkatan
            // 
            this.WaktuKeberangkatan.DataPropertyName = "Waktu";
            this.WaktuKeberangkatan.HeaderText = "Waktu Keberangkatan";
            this.WaktuKeberangkatan.Name = "WaktuKeberangkatan";
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            // 
            // Hapus
            // 
            this.Hapus.DataPropertyName = "Hapus";
            this.Hapus.HeaderText = "Hapus";
            this.Hapus.Name = "Hapus";
            this.Hapus.Text = "Hapus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Semua Jadwal Penerbangan yang terdaftar ada disini";
            // 
            // comboBoxAsal
            // 
            this.comboBoxAsal.FormattingEnabled = true;
            this.comboBoxAsal.Location = new System.Drawing.Point(57, 214);
            this.comboBoxAsal.Name = "comboBoxAsal";
            this.comboBoxAsal.Size = new System.Drawing.Size(139, 21);
            this.comboBoxAsal.TabIndex = 24;
            // 
            // comboBoxTujuan
            // 
            this.comboBoxTujuan.FormattingEnabled = true;
            this.comboBoxTujuan.Location = new System.Drawing.Point(57, 239);
            this.comboBoxTujuan.Name = "comboBoxTujuan";
            this.comboBoxTujuan.Size = new System.Drawing.Size(139, 21);
            this.comboBoxTujuan.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Maskapai";
            // 
            // comboBoxMaskapai
            // 
            this.comboBoxMaskapai.FormattingEnabled = true;
            this.comboBoxMaskapai.Location = new System.Drawing.Point(57, 264);
            this.comboBoxMaskapai.Name = "comboBoxMaskapai";
            this.comboBoxMaskapai.Size = new System.Drawing.Size(139, 21);
            this.comboBoxMaskapai.TabIndex = 24;
            // 
            // textBoxKodePenerbangan
            // 
            this.textBoxKodePenerbangan.Location = new System.Drawing.Point(57, 183);
            this.textBoxKodePenerbangan.Name = "textBoxKodePenerbangan";
            this.textBoxKodePenerbangan.Size = new System.Drawing.Size(139, 20);
            this.textBoxKodePenerbangan.TabIndex = 25;
            this.textBoxKodePenerbangan.Text = "AA-0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tanggal";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(204, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Waktu Keberangkatan";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(206, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 38);
            this.label8.TabIndex = 12;
            this.label8.Text = "Durasi Penerbangan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Harga /tiket";
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(281, 185);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(172, 20);
            this.dateTimePickerTanggal.TabIndex = 26;
            // 
            // numericUpDownHargaTicket
            // 
            this.numericUpDownHargaTicket.Location = new System.Drawing.Point(282, 269);
            this.numericUpDownHargaTicket.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericUpDownHargaTicket.Name = "numericUpDownHargaTicket";
            this.numericUpDownHargaTicket.Size = new System.Drawing.Size(103, 20);
            this.numericUpDownHargaTicket.TabIndex = 27;
            // 
            // textBoxDurasi
            // 
            this.textBoxDurasi.Location = new System.Drawing.Point(281, 239);
            this.textBoxDurasi.Name = "textBoxDurasi";
            this.textBoxDurasi.Size = new System.Drawing.Size(139, 20);
            this.textBoxDurasi.TabIndex = 25;
            this.textBoxDurasi.Text = "__ Jam __ Menit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, -2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(313, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "MASTER JADWAL PENERBANGAN";
            // 
            // dateTimePickerWaktuKeberangkatan
            // 
            this.dateTimePickerWaktuKeberangkatan.Location = new System.Drawing.Point(282, 211);
            this.dateTimePickerWaktuKeberangkatan.Name = "dateTimePickerWaktuKeberangkatan";
            this.dateTimePickerWaktuKeberangkatan.Size = new System.Drawing.Size(171, 20);
            this.dateTimePickerWaktuKeberangkatan.TabIndex = 26;
            // 
            // FormJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 297);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownHargaTicket);
            this.Controls.Add(this.dateTimePickerWaktuKeberangkatan);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.textBoxDurasi);
            this.Controls.Add(this.textBoxKodePenerbangan);
            this.Controls.Add(this.comboBoxMaskapai);
            this.Controls.Add(this.comboBoxTujuan);
            this.Controls.Add(this.comboBoxAsal);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewJadwal);
            this.Controls.Add(this.label2);
            this.Name = "FormJadwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormJadwal";
            this.Load += new System.EventHandler(this.FormJadwal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJadwal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHargaTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSimpan;
        private Button buttonBatal;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridViewJadwal;
        private Label label2;
        private ComboBox comboBoxAsal;
        private ComboBox comboBoxTujuan;
        private Label label1;
        private ComboBox comboBoxMaskapai;
        private TextBox textBoxKodePenerbangan;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePickerTanggal;
        private NumericUpDown numericUpDownHargaTicket;
        private TextBox textBoxDurasi;
        private Label label10;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn KodePenerbangan;
        private DataGridViewTextBoxColumn BandaraAsal;
        private DataGridViewTextBoxColumn BandaraTujuan;
        private DataGridViewTextBoxColumn MaskapaiID;
        private DataGridViewTextBoxColumn TanggalKeberangkatan;
        private DataGridViewTextBoxColumn HargaPerTiket;
        private DataGridViewTextBoxColumn DurasiPenerbangan;
        private DataGridViewTextBoxColumn WaktuKeberangkatan;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Hapus;
        private DateTimePicker dateTimePickerWaktuKeberangkatan;
    }
}