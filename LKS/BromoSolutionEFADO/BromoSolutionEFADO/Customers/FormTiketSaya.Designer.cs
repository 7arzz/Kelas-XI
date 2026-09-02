using System.Drawing;
using System.Windows.Forms;
using System;
using BromoSolutionEFADO.Properties;

namespace BromoSolutionEFADO.Customers
{
    partial class FormTiketSaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTiketSaya));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTiket = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaktuPenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusTerakhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTiket)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tiket Saya";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Semua tiket anda yang aktif ada disini";
            // 
            // dataGridViewTiket
            // 
            this.dataGridViewTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTiket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KodePenerbangan,
            this.Maskapai,
            this.BandaraKeberangkatan,
            this.BandaraTujuan,
            this.TanggalKeberangkatan,
            this.WaktuPenerbangan,
            this.StatusTerakhir});
            this.dataGridViewTiket.Location = new System.Drawing.Point(0, 49);
            this.dataGridViewTiket.Name = "dataGridViewTiket";
            this.dataGridViewTiket.Size = new System.Drawing.Size(845, 388);
            this.dataGridViewTiket.TabIndex = 13;
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
            // TanggalKeberangkatan
            // 
            this.TanggalKeberangkatan.DataPropertyName = "TanggalKeberangkatan";
            this.TanggalKeberangkatan.HeaderText = "Tanggal Keberangkatan";
            this.TanggalKeberangkatan.Name = "TanggalKeberangkatan";
            // 
            // WaktuPenerbangan
            // 
            this.WaktuPenerbangan.DataPropertyName = "WaktuPenerbangan";
            this.WaktuPenerbangan.HeaderText = "Waktu Penerbangan";
            this.WaktuPenerbangan.Name = "WaktuPenerbangan";
            // 
            // StatusTerakhir
            // 
            this.StatusTerakhir.DataPropertyName = "StatusTerakhir";
            this.StatusTerakhir.HeaderText = "Status Terakhir";
            this.StatusTerakhir.Name = "StatusTerakhir";
            // 
            // FormTiketSaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 448);
            this.Controls.Add(this.dataGridViewTiket);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "FormTiketSaya";
            this.Text = "FormTiketSaya";
            this.Load += new System.EventHandler(this.FormTiketSaya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTiket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private DataGridView dataGridViewTiket;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn KodePenerbangan;
        private DataGridViewTextBoxColumn Maskapai;
        private DataGridViewTextBoxColumn BandaraKeberangkatan;
        private DataGridViewTextBoxColumn BandaraTujuan;
        private DataGridViewTextBoxColumn TanggalKeberangkatan;
        private DataGridViewTextBoxColumn WaktuPenerbangan;
        private DataGridViewTextBoxColumn StatusTerakhir;
    }
}