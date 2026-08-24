using System.Drawing;
using System.Windows.Forms;

namespace BromoSolutionEFADO
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxBurger = new System.Windows.Forms.PictureBox();
            this.labelRegister = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLogout = new System.Windows.Forms.Label();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.labelPromo = new System.Windows.Forms.Label();
            this.pictureBoxPromo = new System.Windows.Forms.PictureBox();
            this.labelJadwal = new System.Windows.Forms.Label();
            this.pictureBoxJadwal = new System.Windows.Forms.PictureBox();
            this.labelMaskapai = new System.Windows.Forms.Label();
            this.pictureBoxMaskapai = new System.Windows.Forms.PictureBox();
            this.labelBandara = new System.Windows.Forms.Label();
            this.pictureBoxBandara = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBurger)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJadwal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaskapai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBandara)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxBurger);
            this.flowLayoutPanel1.Controls.Add(this.labelRegister);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(686, 56);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxBurger
            // 
            this.pictureBoxBurger.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBurger.Image")));
            this.pictureBoxBurger.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxBurger.Name = "pictureBoxBurger";
            this.pictureBoxBurger.Size = new System.Drawing.Size(53, 49);
            this.pictureBoxBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBurger.TabIndex = 2;
            this.pictureBoxBurger.TabStop = false;
            // 
            // labelRegister
            // 
            this.labelRegister.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.labelRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRegister.Location = new System.Drawing.Point(62, 0);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(159, 43);
            this.labelRegister.TabIndex = 11;
            this.labelRegister.Text = "Dashboard";
            this.labelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelLogout);
            this.panel1.Controls.Add(this.pictureBoxLogout);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.pictureBoxStatus);
            this.panel1.Controls.Add(this.labelPromo);
            this.panel1.Controls.Add(this.pictureBoxPromo);
            this.panel1.Controls.Add(this.labelJadwal);
            this.panel1.Controls.Add(this.pictureBoxJadwal);
            this.panel1.Controls.Add(this.labelMaskapai);
            this.panel1.Controls.Add(this.pictureBoxMaskapai);
            this.panel1.Controls.Add(this.labelBandara);
            this.panel1.Controls.Add(this.pictureBoxBandara);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 331);
            this.panel1.TabIndex = 1;
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelLogout.ForeColor = System.Drawing.Color.Red;
            this.labelLogout.Location = new System.Drawing.Point(44, 296);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(64, 21);
            this.labelLogout.TabIndex = 24;
            this.labelLogout.Text = "Logout";
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogout.Image")));
            this.pictureBoxLogout.Location = new System.Drawing.Point(10, 291);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(28, 29);
            this.pictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogout.TabIndex = 23;
            this.pictureBoxLogout.TabStop = false;
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelStatus.ForeColor = System.Drawing.Color.Gray;
            this.labelStatus.Location = new System.Drawing.Point(44, 213);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(102, 42);
            this.labelStatus.TabIndex = 22;
            this.labelStatus.Text = "Ubah Status Penerbangan";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click_1);
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStatus.Image")));
            this.pictureBoxStatus.Location = new System.Drawing.Point(10, 216);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(28, 29);
            this.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStatus.TabIndex = 21;
            this.pictureBoxStatus.TabStop = false;
            this.pictureBoxStatus.Click += new System.EventHandler(this.pictureBoxStatus_Click);
            // 
            // labelPromo
            // 
            this.labelPromo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPromo.ForeColor = System.Drawing.Color.Gray;
            this.labelPromo.Location = new System.Drawing.Point(44, 160);
            this.labelPromo.Name = "labelPromo";
            this.labelPromo.Size = new System.Drawing.Size(102, 42);
            this.labelPromo.TabIndex = 20;
            this.labelPromo.Text = "Master Kode Promo";
            this.labelPromo.Click += new System.EventHandler(this.labelPromo_Click_1);
            // 
            // pictureBoxPromo
            // 
            this.pictureBoxPromo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPromo.Image")));
            this.pictureBoxPromo.Location = new System.Drawing.Point(10, 163);
            this.pictureBoxPromo.Name = "pictureBoxPromo";
            this.pictureBoxPromo.Size = new System.Drawing.Size(28, 29);
            this.pictureBoxPromo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPromo.TabIndex = 19;
            this.pictureBoxPromo.TabStop = false;
            this.pictureBoxPromo.Click += new System.EventHandler(this.pictureBoxPromo_Click_1);
            // 
            // labelJadwal
            // 
            this.labelJadwal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelJadwal.ForeColor = System.Drawing.Color.Gray;
            this.labelJadwal.Location = new System.Drawing.Point(44, 112);
            this.labelJadwal.Name = "labelJadwal";
            this.labelJadwal.Size = new System.Drawing.Size(116, 48);
            this.labelJadwal.TabIndex = 18;
            this.labelJadwal.Text = "Master Penjadwalan Penerbangan";
            this.labelJadwal.Click += new System.EventHandler(this.labelJadwal_Click_1);
            // 
            // pictureBoxJadwal
            // 
            this.pictureBoxJadwal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxJadwal.Image")));
            this.pictureBoxJadwal.Location = new System.Drawing.Point(10, 116);
            this.pictureBoxJadwal.Name = "pictureBoxJadwal";
            this.pictureBoxJadwal.Size = new System.Drawing.Size(28, 29);
            this.pictureBoxJadwal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxJadwal.TabIndex = 17;
            this.pictureBoxJadwal.TabStop = false;
            this.pictureBoxJadwal.Click += new System.EventHandler(this.pictureBoxJadwal_Click_1);
            // 
            // labelMaskapai
            // 
            this.labelMaskapai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMaskapai.ForeColor = System.Drawing.Color.Gray;
            this.labelMaskapai.Location = new System.Drawing.Point(44, 68);
            this.labelMaskapai.Name = "labelMaskapai";
            this.labelMaskapai.Size = new System.Drawing.Size(116, 44);
            this.labelMaskapai.TabIndex = 16;
            this.labelMaskapai.Text = "Master Maskapai";
            this.labelMaskapai.Click += new System.EventHandler(this.labelMaskapai_Click_1);
            // 
            // pictureBoxMaskapai
            // 
            this.pictureBoxMaskapai.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaskapai.Image")));
            this.pictureBoxMaskapai.Location = new System.Drawing.Point(10, 68);
            this.pictureBoxMaskapai.Name = "pictureBoxMaskapai";
            this.pictureBoxMaskapai.Size = new System.Drawing.Size(28, 29);
            this.pictureBoxMaskapai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaskapai.TabIndex = 15;
            this.pictureBoxMaskapai.TabStop = false;
            this.pictureBoxMaskapai.Click += new System.EventHandler(this.pictureBoxMaskapai_Click_1);
            // 
            // labelBandara
            // 
            this.labelBandara.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelBandara.ForeColor = System.Drawing.Color.Gray;
            this.labelBandara.Location = new System.Drawing.Point(44, 7);
            this.labelBandara.Name = "labelBandara";
            this.labelBandara.Size = new System.Drawing.Size(102, 45);
            this.labelBandara.TabIndex = 14;
            this.labelBandara.Text = "Master Bandara";
            this.labelBandara.Click += new System.EventHandler(this.labelBandara_Click_1);
            // 
            // pictureBoxBandara
            // 
            this.pictureBoxBandara.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBandara.Image")));
            this.pictureBoxBandara.Location = new System.Drawing.Point(10, 23);
            this.pictureBoxBandara.Name = "pictureBoxBandara";
            this.pictureBoxBandara.Size = new System.Drawing.Size(28, 29);
            this.pictureBoxBandara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBandara.TabIndex = 12;
            this.pictureBoxBandara.TabStop = false;
            this.pictureBoxBandara.Click += new System.EventHandler(this.pictureBoxBandara_Click_1);
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(165, 57);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(521, 331);
            this.panelContent.TabIndex = 2;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBurger)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJadwal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaskapai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBandara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label labelRegister;
        private PictureBox pictureBoxBurger;
        private PictureBox pictureBoxBandara;
        private Label labelLogout;
        private PictureBox pictureBoxLogout;
        private Label labelStatus;
        private PictureBox pictureBoxStatus;
        private Label labelPromo;
        private PictureBox pictureBoxPromo;
        private Label labelJadwal;
        private PictureBox pictureBoxJadwal;
        private Label labelMaskapai;
        private PictureBox pictureBoxMaskapai;
        private Label labelBandara;
        private Panel panelContent;
    }
}