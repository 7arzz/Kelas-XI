namespace ContohSoal1
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelRegister = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelMaskapai = new Label();
            pictureBox3 = new PictureBox();
            labelJadwal = new Label();
            pictureBox4 = new PictureBox();
            labelPromo = new Label();
            pictureBox5 = new PictureBox();
            labelStatus = new Label();
            pictureBox6 = new PictureBox();
            labelLogout = new Label();
            pictureBox7 = new PictureBox();
            labelBandara = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.MenuHighlight;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(labelRegister);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 65);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // labelRegister
            // 
            labelRegister.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            labelRegister.ForeColor = SystemColors.ControlLightLight;
            labelRegister.Location = new Point(71, 0);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(151, 50);
            labelRegister.TabIndex = 11;
            labelRegister.Text = "Dashboard";
            labelRegister.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelLogout);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(labelStatus);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(labelPromo);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(labelJadwal);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(labelMaskapai);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(labelBandara);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 382);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // labelMaskapai
            // 
            labelMaskapai.Font = new Font("Segoe UI", 12F);
            labelMaskapai.Location = new Point(51, 87);
            labelMaskapai.Name = "labelMaskapai";
            labelMaskapai.Size = new Size(135, 21);
            labelMaskapai.TabIndex = 16;
            labelMaskapai.Text = "Master Maskapai";
            labelMaskapai.Click += this.labelMaskapai_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 79);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // labelJadwal
            // 
            labelJadwal.Font = new Font("Segoe UI", 12F);
            labelJadwal.Location = new Point(51, 129);
            labelJadwal.Name = "labelJadwal";
            labelJadwal.Size = new Size(135, 47);
            labelJadwal.TabIndex = 18;
            labelJadwal.Text = "Master Penjadwalan Penerbangan";
            labelJadwal.Click += this.labelJadwal_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 134);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // labelPromo
            // 
            labelPromo.Font = new Font("Segoe UI", 12F);
            labelPromo.Location = new Point(51, 185);
            labelPromo.Name = "labelPromo";
            labelPromo.Size = new Size(119, 48);
            labelPromo.TabIndex = 20;
            labelPromo.Text = "Master Kode Promo";
            labelPromo.Click += labelPromo_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 188);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // labelStatus
            // 
            labelStatus.Font = new Font("Segoe UI", 12F);
            labelStatus.Location = new Point(51, 246);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(119, 48);
            labelStatus.TabIndex = 22;
            labelStatus.Text = "Ubah Status Penerbangan";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 249);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 34);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            // 
            // labelLogout
            // 
            labelLogout.AutoSize = true;
            labelLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelLogout.ForeColor = Color.Red;
            labelLogout.Location = new Point(51, 344);
            labelLogout.Name = "labelLogout";
            labelLogout.Size = new Size(64, 21);
            labelLogout.TabIndex = 24;
            labelLogout.Text = "Logout";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 336);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(33, 34);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // labelBandara
            // 
            labelBandara.Font = new Font("Segoe UI", 12F);
            labelBandara.Location = new Point(51, 35);
            labelBandara.Name = "labelBandara";
            labelBandara.Size = new Size(119, 21);
            labelBandara.TabIndex = 14;
            labelBandara.Text = "Master Bandara";
            labelBandara.Click += this.labelBandara_Click;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "FormDashboard";
            Text = "FormDashboard";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label labelRegister;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelLogout;
        private PictureBox pictureBox7;
        private Label labelStatus;
        private PictureBox pictureBox6;
        private Label labelPromo;
        private PictureBox pictureBox5;
        private Label labelJadwal;
        private PictureBox pictureBox4;
        private Label labelMaskapai;
        private PictureBox pictureBox3;
        private Label labelBandara;
    }
}