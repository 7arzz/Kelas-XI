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
            pictureBox1 = new PictureBox();
            labelRegister = new Label();
            panel1 = new Panel();
            labelLogout = new Label();
            pictureBox7 = new PictureBox();
            labelStatus = new Label();
            pictureBoxStatus = new PictureBox();
            labelPromo = new Label();
            pictureBoxPromo = new PictureBox();
            labelJadwal = new Label();
            pictureBoxJadwal = new PictureBox();
            labelMaskapai = new Label();
            pictureBoxMaskapai = new PictureBox();
            labelBandara = new Label();
            pictureBoxBandara = new PictureBox();
            panelContent = new Panel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPromo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJadwal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaskapai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBandara).BeginInit();
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
            panel1.Controls.Add(pictureBoxStatus);
            panel1.Controls.Add(labelPromo);
            panel1.Controls.Add(pictureBoxPromo);
            panel1.Controls.Add(labelJadwal);
            panel1.Controls.Add(pictureBoxJadwal);
            panel1.Controls.Add(labelMaskapai);
            panel1.Controls.Add(pictureBoxMaskapai);
            panel1.Controls.Add(labelBandara);
            panel1.Controls.Add(pictureBoxBandara);
            panel1.Location = new Point(0, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 382);
            panel1.TabIndex = 1;
            // 
            // labelLogout
            // 
            labelLogout.AutoSize = true;
            labelLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelLogout.ForeColor = Color.Red;
            labelLogout.Location = new Point(51, 342);
            labelLogout.Name = "labelLogout";
            labelLogout.Size = new Size(64, 21);
            labelLogout.TabIndex = 24;
            labelLogout.Text = "Logout";
            labelLogout.Click += labelLogout_Click;
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
            pictureBox7.Click += pictureBox7_Click;
            // 
            // labelStatus
            // 
            labelStatus.Font = new Font("Segoe UI", 12F);
            labelStatus.ForeColor = Color.Gray;
            labelStatus.Location = new Point(51, 246);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(119, 48);
            labelStatus.TabIndex = 22;
            labelStatus.Text = "Ubah Status Penerbangan";
            labelStatus.Click += labelStatus_Click;
            // 
            // pictureBoxStatus
            // 
            pictureBoxStatus.Image = (Image)resources.GetObject("pictureBoxStatus.Image");
            pictureBoxStatus.Location = new Point(12, 249);
            pictureBoxStatus.Name = "pictureBoxStatus";
            pictureBoxStatus.Size = new Size(33, 34);
            pictureBoxStatus.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxStatus.TabIndex = 21;
            pictureBoxStatus.TabStop = false;
            pictureBoxStatus.Click += pictureBoxStatus_Click_1;
            // 
            // labelPromo
            // 
            labelPromo.Font = new Font("Segoe UI", 12F);
            labelPromo.ForeColor = Color.Gray;
            labelPromo.Location = new Point(51, 185);
            labelPromo.Name = "labelPromo";
            labelPromo.Size = new Size(119, 48);
            labelPromo.TabIndex = 20;
            labelPromo.Text = "Master Kode Promo";
            labelPromo.Click += labelPromo_Click;
            // 
            // pictureBoxPromo
            // 
            pictureBoxPromo.Image = (Image)resources.GetObject("pictureBoxPromo.Image");
            pictureBoxPromo.Location = new Point(12, 188);
            pictureBoxPromo.Name = "pictureBoxPromo";
            pictureBoxPromo.Size = new Size(33, 34);
            pictureBoxPromo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPromo.TabIndex = 19;
            pictureBoxPromo.TabStop = false;
            pictureBoxPromo.Click += pictureBoxPromo_Click;
            // 
            // labelJadwal
            // 
            labelJadwal.Font = new Font("Segoe UI", 12F);
            labelJadwal.ForeColor = Color.Gray;
            labelJadwal.Location = new Point(51, 129);
            labelJadwal.Name = "labelJadwal";
            labelJadwal.Size = new Size(135, 47);
            labelJadwal.TabIndex = 18;
            labelJadwal.Text = "Master Penjadwalan Penerbangan";
            labelJadwal.Click += labelJadwal_Click;
            // 
            // pictureBoxJadwal
            // 
            pictureBoxJadwal.Image = (Image)resources.GetObject("pictureBoxJadwal.Image");
            pictureBoxJadwal.Location = new Point(12, 134);
            pictureBoxJadwal.Name = "pictureBoxJadwal";
            pictureBoxJadwal.Size = new Size(33, 34);
            pictureBoxJadwal.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxJadwal.TabIndex = 17;
            pictureBoxJadwal.TabStop = false;
            pictureBoxJadwal.Click += pictureBoxJadwal_Click;
            // 
            // labelMaskapai
            // 
            labelMaskapai.Font = new Font("Segoe UI", 12F);
            labelMaskapai.ForeColor = Color.Gray;
            labelMaskapai.Location = new Point(51, 87);
            labelMaskapai.Name = "labelMaskapai";
            labelMaskapai.Size = new Size(135, 21);
            labelMaskapai.TabIndex = 16;
            labelMaskapai.Text = "Master Maskapai";
            labelMaskapai.Click += labelMaskapai_Click;
            // 
            // pictureBoxMaskapai
            // 
            pictureBoxMaskapai.Image = (Image)resources.GetObject("pictureBoxMaskapai.Image");
            pictureBoxMaskapai.Location = new Point(12, 79);
            pictureBoxMaskapai.Name = "pictureBoxMaskapai";
            pictureBoxMaskapai.Size = new Size(33, 34);
            pictureBoxMaskapai.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMaskapai.TabIndex = 15;
            pictureBoxMaskapai.TabStop = false;
            pictureBoxMaskapai.Click += pictureBoxMaskapai_Click;
            // 
            // labelBandara
            // 
            labelBandara.Font = new Font("Segoe UI", 12F);
            labelBandara.ForeColor = Color.Gray;
            labelBandara.Location = new Point(51, 35);
            labelBandara.Name = "labelBandara";
            labelBandara.Size = new Size(119, 21);
            labelBandara.TabIndex = 14;
            labelBandara.Text = "Master Bandara";
            labelBandara.Click += labelBandara_Click;
            // 
            // pictureBoxBandara
            // 
            pictureBoxBandara.Image = (Image)resources.GetObject("pictureBoxBandara.Image");
            pictureBoxBandara.Location = new Point(12, 27);
            pictureBoxBandara.Name = "pictureBoxBandara";
            pictureBoxBandara.Size = new Size(33, 34);
            pictureBoxBandara.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBandara.TabIndex = 12;
            pictureBoxBandara.TabStop = false;
            pictureBoxBandara.Click += pictureBoxBandara_Click;
            // 
            // panelContent
            // 
            panelContent.Location = new Point(192, 66);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(608, 382);
            panelContent.TabIndex = 2;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboard";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPromo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJadwal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaskapai).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBandara).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label labelRegister;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxBandara;
        private Label labelLogout;
        private PictureBox pictureBox7;
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