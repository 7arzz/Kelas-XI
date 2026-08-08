namespace ContohSoal1
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
            labelRegister = new Label();
            labelUsn = new Label();
            pictureBox1 = new PictureBox();
            linkLabelDatar = new LinkLabel();
            label1 = new Label();
            textBoxNama = new TextBox();
            labelPassword = new Label();
            buttonLogin = new Button();
            textBoxUsn = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBoxTelp = new TextBox();
            textBoxPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            labelRegister.Location = new Point(23, 23);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(145, 31);
            labelRegister.TabIndex = 10;
            labelRegister.Text = "Daftar Akun";
            // 
            // labelUsn
            // 
            labelUsn.AutoSize = true;
            labelUsn.Font = new Font("Segoe UI", 9F);
            labelUsn.Location = new Point(23, 64);
            labelUsn.Name = "labelUsn";
            labelUsn.Size = new Size(307, 15);
            labelUsn.TabIndex = 11;
            labelUsn.Text = "Daftarkan diri anda untuk menggunakan Bromo Solution";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(463, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // linkLabelDatar
            // 
            linkLabelDatar.AutoSize = true;
            linkLabelDatar.LinkColor = Color.DarkTurquoise;
            linkLabelDatar.Location = new Point(207, 402);
            linkLabelDatar.Name = "linkLabelDatar";
            linkLabelDatar.Size = new Size(37, 15);
            linkLabelDatar.TabIndex = 19;
            linkLabelDatar.TabStop = true;
            linkLabelDatar.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(83, 402);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 18;
            label1.Text = "Sudah Punya Akun??";
            // 
            // textBoxNama
            // 
            textBoxNama.Font = new Font("Segoe UI", 12F);
            textBoxNama.Location = new Point(151, 138);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(221, 29);
            textBoxNama.TabIndex = 17;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F);
            labelPassword.Location = new Point(21, 291);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(83, 21);
            labelPassword.TabIndex = 16;
            labelPassword.Text = "Password :";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ActiveCaption;
            buttonLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.Cornsilk;
            buttonLogin.Location = new Point(23, 352);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(334, 36);
            buttonLogin.TabIndex = 15;
            buttonLogin.Text = "Daftar";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxUsn
            // 
            textBoxUsn.Font = new Font("Segoe UI", 12F);
            textBoxUsn.Location = new Point(153, 94);
            textBoxUsn.Name = "textBoxUsn";
            textBoxUsn.Size = new Size(221, 29);
            textBoxUsn.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(21, 96);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 13;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(20, 191);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 20;
            label3.Text = "Tanggal Lahir :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(26, 140);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 21;
            label4.Text = "Nama :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(19, 236);
            label5.Name = "label5";
            label5.Size = new Size(124, 21);
            label5.TabIndex = 22;
            label5.Text = "Nomor Telepon :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(153, 191);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 23);
            dateTimePicker1.TabIndex = 23;
            // 
            // textBoxTelp
            // 
            textBoxTelp.Font = new Font("Segoe UI", 12F);
            textBoxTelp.Location = new Point(153, 236);
            textBoxTelp.Name = "textBoxTelp";
            textBoxTelp.Size = new Size(221, 29);
            textBoxTelp.TabIndex = 24;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F);
            textBoxPassword.Location = new Point(151, 287);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(221, 29);
            textBoxPassword.TabIndex = 25;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxTelp);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabelDatar);
            Controls.Add(label1);
            Controls.Add(textBoxNama);
            Controls.Add(labelPassword);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxUsn);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(labelUsn);
            Controls.Add(labelRegister);
            Name = "FormRegister";
            Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRegister;
        private Label labelUsn;
        private PictureBox pictureBox1;
        private LinkLabel linkLabelDatar;
        private Label label1;
        private TextBox textBoxNama;
        private Label labelPassword;
        private Button buttonLogin;
        private TextBox textBoxUsn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxTelp;
        private TextBox textBoxPassword;
    }
}