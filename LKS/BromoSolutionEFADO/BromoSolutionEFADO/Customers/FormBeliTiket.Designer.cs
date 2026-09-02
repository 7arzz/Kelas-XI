using System.Drawing;
using System.Windows.Forms;
using System;
using BromoSolutionEFADO.Properties;

namespace BromoSolutionEFADO.Customers
{
    partial class FormBeliTiket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBeliTiket));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTujuan = new System.Windows.Forms.Label();
            this.labelJumlahPenumpang = new System.Windows.Forms.Label();
            this.labelJam = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelMaskapai = new System.Windows.Forms.Label();
            this.labelAsal = new System.Windows.Forms.Label();
            this.textBoxReedem = new System.Windows.Forms.TextBox();
            this.buttonReedem = new System.Windows.Forms.Button();
            this.buttonPembayaran = new System.Windows.Forms.Button();
            this.labelTotalPembayaran = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flpPenumpang = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "DETAIL PENUMPANG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mohon di isi data semua penumpang";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelTujuan);
            this.panel1.Controls.Add(this.labelJumlahPenumpang);
            this.panel1.Controls.Add(this.labelJam);
            this.panel1.Controls.Add(this.labelTanggal);
            this.panel1.Controls.Add(this.labelMaskapai);
            this.panel1.Controls.Add(this.labelAsal);
            this.panel1.Controls.Add(this.textBoxReedem);
            this.panel1.Controls.Add(this.buttonReedem);
            this.panel1.Controls.Add(this.buttonPembayaran);
            this.panel1.Controls.Add(this.labelTotalPembayaran);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(544, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 462);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(21, 218);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(21, 179);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 141);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(187, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // labelTujuan
            // 
            this.labelTujuan.AutoSize = true;
            this.labelTujuan.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelTujuan.Location = new System.Drawing.Point(291, 44);
            this.labelTujuan.Name = "labelTujuan";
            this.labelTujuan.Size = new System.Drawing.Size(87, 13);
            this.labelTujuan.TabIndex = 11;
            this.labelTujuan.Text = "Bandara A (BAA)";
            // 
            // labelJumlahPenumpang
            // 
            this.labelJumlahPenumpang.AutoSize = true;
            this.labelJumlahPenumpang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelJumlahPenumpang.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelJumlahPenumpang.Location = new System.Drawing.Point(56, 222);
            this.labelJumlahPenumpang.Name = "labelJumlahPenumpang";
            this.labelJumlahPenumpang.Size = new System.Drawing.Size(128, 19);
            this.labelJumlahPenumpang.TabIndex = 11;
            this.labelJumlahPenumpang.Text = "jumlah penumpang";
            // 
            // labelJam
            // 
            this.labelJam.AutoSize = true;
            this.labelJam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelJam.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelJam.Location = new System.Drawing.Point(56, 182);
            this.labelJam.Name = "labelJam";
            this.labelJam.Size = new System.Drawing.Size(31, 19);
            this.labelJam.TabIndex = 11;
            this.labelJam.Text = "jam";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTanggal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelTanggal.Location = new System.Drawing.Point(56, 148);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(145, 19);
            this.labelTanggal.TabIndex = 11;
            this.labelTanggal.Text = "Monday, 22 mei 2023";
            // 
            // labelMaskapai
            // 
            this.labelMaskapai.AutoSize = true;
            this.labelMaskapai.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelMaskapai.Location = new System.Drawing.Point(11, 77);
            this.labelMaskapai.Name = "labelMaskapai";
            this.labelMaskapai.Size = new System.Drawing.Size(87, 13);
            this.labelMaskapai.TabIndex = 11;
            this.labelMaskapai.Text = "Pelita Air Service";
            // 
            // labelAsal
            // 
            this.labelAsal.AutoSize = true;
            this.labelAsal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelAsal.Location = new System.Drawing.Point(10, 44);
            this.labelAsal.Name = "labelAsal";
            this.labelAsal.Size = new System.Drawing.Size(86, 13);
            this.labelAsal.TabIndex = 12;
            this.labelAsal.Text = "bandara A (BAA)";
            // 
            // textBoxReedem
            // 
            this.textBoxReedem.Location = new System.Drawing.Point(14, 298);
            this.textBoxReedem.Name = "textBoxReedem";
            this.textBoxReedem.Size = new System.Drawing.Size(184, 20);
            this.textBoxReedem.TabIndex = 10;
            // 
            // buttonReedem
            // 
            this.buttonReedem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonReedem.Location = new System.Drawing.Point(217, 297);
            this.buttonReedem.Name = "buttonReedem";
            this.buttonReedem.Size = new System.Drawing.Size(81, 24);
            this.buttonReedem.TabIndex = 9;
            this.buttonReedem.Text = "Pakai";
            this.buttonReedem.UseVisualStyleBackColor = true;
            this.buttonReedem.Click += new System.EventHandler(this.buttonReedem_Click);
            // 
            // buttonPembayaran
            // 
            this.buttonPembayaran.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPembayaran.Location = new System.Drawing.Point(38, 422);
            this.buttonPembayaran.Name = "buttonPembayaran";
            this.buttonPembayaran.Size = new System.Drawing.Size(274, 33);
            this.buttonPembayaran.TabIndex = 9;
            this.buttonPembayaran.Text = "Konfirmasi Pembayaran";
            this.buttonPembayaran.UseVisualStyleBackColor = true;
            this.buttonPembayaran.Click += new System.EventHandler(this.buttonPembayaran_Click);
            // 
            // labelTotalPembayaran
            // 
            this.labelTotalPembayaran.AutoSize = true;
            this.labelTotalPembayaran.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPembayaran.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTotalPembayaran.Location = new System.Drawing.Point(167, 390);
            this.labelTotalPembayaran.Name = "labelTotalPembayaran";
            this.labelTotalPembayaran.Size = new System.Drawing.Size(131, 25);
            this.labelTotalPembayaran.TabIndex = 8;
            this.labelTotalPembayaran.Text = "IDR xxx.xxxx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Pembayaran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kode Promo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Detail Penerbangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Penerbangan";
            // 
            // flpPenumpang
            // 
            this.flpPenumpang.AutoScroll = true;
            this.flpPenumpang.Location = new System.Drawing.Point(-4, 68);
            this.flpPenumpang.Name = "flpPenumpang";
            this.flpPenumpang.Size = new System.Drawing.Size(549, 383);
            this.flpPenumpang.TabIndex = 11;
            this.flpPenumpang.WrapContents = false;
            // 
            // FormBeliTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 448);
            this.Controls.Add(this.flpPenumpang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "FormBeliTiket";
            this.Text = "FormTiketSaya";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBeliTiket_FormClosing);
            this.Load += new System.EventHandler(this.FormBeliTiket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Panel panel1;
        private FlowLayoutPanel flpPenumpang;
        private Button buttonReedem;
        private Button buttonPembayaran;
        private Label labelTotalPembayaran;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox textBoxReedem;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label labelTujuan;
        private Label labelMaskapai;
        private Label labelAsal;
        private Label labelTanggal;
        private PictureBox pictureBox4;
        private Label labelJam;
        private PictureBox pictureBox5;
        private Label labelJumlahPenumpang;
    }
}