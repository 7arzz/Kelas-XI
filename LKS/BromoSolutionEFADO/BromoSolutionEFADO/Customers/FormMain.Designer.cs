using System.Drawing;
using System.Windows.Forms;
using System;
using BromoSolutionEFADO.Properties;

namespace BromoSolutionEFADO.Customers
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxTiket = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelNamaAkun = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxMaskapai = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBerangkat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTujuan = new System.Windows.Forms.TextBox();
            this.pictureBoxJadwal = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerTanggalBerangkat = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownPenumpang = new System.Windows.Forms.NumericUpDown();
            this.buttonCariPenerbangan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTiket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaskapai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJadwal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPenumpang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.pictureBoxTiket);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 91);
            this.panel1.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.Location = new System.Drawing.Point(795, 32);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(28, 29);
            this.logoutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutButton.TabIndex = 24;
            this.logoutButton.TabStop = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // pictureBoxTiket
            // 
            this.pictureBoxTiket.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTiket.Image")));
            this.pictureBoxTiket.Location = new System.Drawing.Point(736, 32);
            this.pictureBoxTiket.Name = "pictureBoxTiket";
            this.pictureBoxTiket.Size = new System.Drawing.Size(28, 29);
            this.pictureBoxTiket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTiket.TabIndex = 20;
            this.pictureBoxTiket.TabStop = false;
            this.pictureBoxTiket.Click += new System.EventHandler(this.pictureBoxTiket_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "HALO!";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelWelcome.Location = new System.Drawing.Point(21, 145);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(193, 19);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Mau terbang kemana hari ini, ";
            // 
            // labelNamaAkun
            // 
            this.labelNamaAkun.AutoSize = true;
            this.labelNamaAkun.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelNamaAkun.Location = new System.Drawing.Point(211, 145);
            this.labelNamaAkun.Name = "labelNamaAkun";
            this.labelNamaAkun.Size = new System.Drawing.Size(89, 19);
            this.labelNamaAkun.TabIndex = 3;
            this.labelNamaAkun.Text = "[Nama Akun]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(315, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 3;
            // 
            // pictureBoxMaskapai
            // 
            this.pictureBoxMaskapai.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaskapai.Image")));
            this.pictureBoxMaskapai.Location = new System.Drawing.Point(47, 185);
            this.pictureBoxMaskapai.Name = "pictureBoxMaskapai";
            this.pictureBoxMaskapai.Size = new System.Drawing.Size(39, 36);
            this.pictureBoxMaskapai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaskapai.TabIndex = 16;
            this.pictureBoxMaskapai.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(91, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Berangkat Dari";
            // 
            // textBoxBerangkat
            // 
            this.textBoxBerangkat.Location = new System.Drawing.Point(94, 200);
            this.textBoxBerangkat.Name = "textBoxBerangkat";
            this.textBoxBerangkat.Size = new System.Drawing.Size(151, 20);
            this.textBoxBerangkat.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(374, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tujuan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(330, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxTujuan
            // 
            this.textBoxTujuan.Location = new System.Drawing.Point(377, 200);
            this.textBoxTujuan.Name = "textBoxTujuan";
            this.textBoxTujuan.Size = new System.Drawing.Size(151, 20);
            this.textBoxTujuan.TabIndex = 17;
            // 
            // pictureBoxJadwal
            // 
            this.pictureBoxJadwal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxJadwal.Image")));
            this.pictureBoxJadwal.Location = new System.Drawing.Point(47, 261);
            this.pictureBoxJadwal.Name = "pictureBoxJadwal";
            this.pictureBoxJadwal.Size = new System.Drawing.Size(39, 36);
            this.pictureBoxJadwal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxJadwal.TabIndex = 18;
            this.pictureBoxJadwal.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(91, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tanggal Berangkat";
            // 
            // dateTimePickerTanggalBerangkat
            // 
            this.dateTimePickerTanggalBerangkat.Location = new System.Drawing.Point(94, 280);
            this.dateTimePickerTanggalBerangkat.Name = "dateTimePickerTanggalBerangkat";
            this.dateTimePickerTanggalBerangkat.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerTanggalBerangkat.TabIndex = 19;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(330, 263);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(374, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Jumlah Penumpang";
            // 
            // numericUpDownPenumpang
            // 
            this.numericUpDownPenumpang.Location = new System.Drawing.Point(377, 280);
            this.numericUpDownPenumpang.Name = "numericUpDownPenumpang";
            this.numericUpDownPenumpang.Size = new System.Drawing.Size(151, 20);
            this.numericUpDownPenumpang.TabIndex = 20;
            // 
            // buttonCariPenerbangan
            // 
            this.buttonCariPenerbangan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCariPenerbangan.Location = new System.Drawing.Point(47, 341);
            this.buttonCariPenerbangan.Name = "buttonCariPenerbangan";
            this.buttonCariPenerbangan.Size = new System.Drawing.Size(243, 30);
            this.buttonCariPenerbangan.TabIndex = 21;
            this.buttonCariPenerbangan.Text = "CARI PENERBANGAN";
            this.buttonCariPenerbangan.UseVisualStyleBackColor = true;
            this.buttonCariPenerbangan.Click += new System.EventHandler(this.buttonCariPenerbangan_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 448);
            this.Controls.Add(this.buttonCariPenerbangan);
            this.Controls.Add(this.numericUpDownPenumpang);
            this.Controls.Add(this.dateTimePickerTanggalBerangkat);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBoxJadwal);
            this.Controls.Add(this.textBoxTujuan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxBerangkat);
            this.Controls.Add(this.pictureBoxMaskapai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNamaAkun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTiket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaskapai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJadwal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPenumpang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxTiket;
        private PictureBox logoutButton;
        private Label label1;
        private Label labelWelcome;
        private Label labelNamaAkun;
        private Label label4;
        private PictureBox pictureBoxMaskapai;
        private Label label3;
        private TextBox textBoxBerangkat;
        private Label label5;
        private PictureBox pictureBox1;
        private TextBox textBoxTujuan;
        private PictureBox pictureBoxJadwal;
        private Label label6;
        private DateTimePicker dateTimePickerTanggalBerangkat;
        private PictureBox pictureBox3;
        private Label label7;
        private NumericUpDown numericUpDownPenumpang;
        private Button buttonCariPenerbangan;
    }
}