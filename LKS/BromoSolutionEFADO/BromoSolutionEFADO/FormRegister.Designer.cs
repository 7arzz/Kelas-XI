using System;
using System.Drawing;
using System.Windows.Forms;

namespace BromoSolutionEFADO
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.labelRegister = new System.Windows.Forms.Label();
            this.labelUsn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonDaftar = new System.Windows.Forms.Button();
            this.textBoxUsn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.textBoxTelp = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.labelRegister.Location = new System.Drawing.Point(20, 20);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(145, 31);
            this.labelRegister.TabIndex = 10;
            this.labelRegister.Text = "Daftar Akun";
            // 
            // labelUsn
            // 
            this.labelUsn.AutoSize = true;
            this.labelUsn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelUsn.Location = new System.Drawing.Point(20, 55);
            this.labelUsn.Name = "labelUsn";
            this.labelUsn.Size = new System.Drawing.Size(307, 15);
            this.labelUsn.TabIndex = 11;
            this.labelUsn.Text = "Daftarkan diri anda untuk menggunakan Bromo Solution";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(397, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.LinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkLabelLogin.Location = new System.Drawing.Point(177, 348);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(33, 13);
            this.linkLabelLogin.TabIndex = 19;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Login";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(71, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sudah Punya Akun??";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxNama.Location = new System.Drawing.Point(129, 120);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(190, 29);
            this.textBoxNama.TabIndex = 17;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPassword.Location = new System.Drawing.Point(18, 252);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(83, 21);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Password :";
            // 
            // buttonDaftar
            // 
            this.buttonDaftar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDaftar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.buttonDaftar.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonDaftar.Location = new System.Drawing.Point(20, 305);
            this.buttonDaftar.Name = "buttonDaftar";
            this.buttonDaftar.Size = new System.Drawing.Size(286, 40);
            this.buttonDaftar.TabIndex = 15;
            this.buttonDaftar.Text = "Daftar";
            this.buttonDaftar.UseVisualStyleBackColor = false;
            this.buttonDaftar.Click += new System.EventHandler(this.buttonDaftar_Click);
            // 
            // textBoxUsn
            // 
            this.textBoxUsn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxUsn.Location = new System.Drawing.Point(131, 81);
            this.textBoxUsn.Name = "textBoxUsn";
            this.textBoxUsn.Size = new System.Drawing.Size(190, 29);
            this.textBoxUsn.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(17, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tanggal Lahir :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(22, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nama :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(16, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nomor Telepon :";
            // 
            // dateTimePickerTanggalLahir
            // 
            this.dateTimePickerTanggalLahir.Location = new System.Drawing.Point(131, 166);
            this.dateTimePickerTanggalLahir.Name = "dateTimePickerTanggalLahir";
            this.dateTimePickerTanggalLahir.Size = new System.Drawing.Size(185, 20);
            this.dateTimePickerTanggalLahir.TabIndex = 23;
            // 
            // textBoxTelp
            // 
            this.textBoxTelp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxTelp.Location = new System.Drawing.Point(131, 205);
            this.textBoxTelp.Name = "textBoxTelp";
            this.textBoxTelp.Size = new System.Drawing.Size(190, 29);
            this.textBoxTelp.TabIndex = 24;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(129, 249);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(190, 29);
            this.textBoxPassword.TabIndex = 25;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxTelp);
            this.Controls.Add(this.dateTimePickerTanggalLahir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.buttonDaftar);
            this.Controls.Add(this.textBoxUsn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelUsn);
            this.Controls.Add(this.labelRegister);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelRegister;
        private Label labelUsn;
        private PictureBox pictureBox1;
        private LinkLabel linkLabelLogin;
        private Label label1;
        private TextBox textBoxNama;
        private Label labelPassword;
        private Button buttonDaftar;
        private TextBox textBoxUsn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePickerTanggalLahir;
        private TextBox textBoxTelp;
        private TextBox textBoxPassword;
    }
}