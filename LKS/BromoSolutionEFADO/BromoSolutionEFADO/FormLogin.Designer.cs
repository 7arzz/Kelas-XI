using System.Drawing;
using System.Windows.Forms;

namespace BromoSolutionEFADO
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            labelUsn = new Label();
            textBoxUsn = new TextBox();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            labelRegister = new Label();
            linkLabelDatar = new LinkLabel();
            pictureBox1 = new PictureBox();
            labelLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelUsn
            // 
            labelUsn.AutoSize = true;
            labelUsn.Font = new Font("Segoe UI", 12F);
            labelUsn.Location = new Point(239, 240);
            labelUsn.Name = "labelUsn";
            labelUsn.Size = new Size(88, 21);
            labelUsn.TabIndex = 0;
            labelUsn.Text = "Username :";
            // 
            // textBoxUsn
            // 
            textBoxUsn.Font = new Font("Segoe UI", 12F);
            textBoxUsn.Location = new Point(346, 238);
            textBoxUsn.Name = "textBoxUsn";
            textBoxUsn.Size = new Size(221, 29);
            textBoxUsn.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ActiveCaption;
            buttonLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.Cornsilk;
            buttonLogin.Location = new Point(233, 325);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(334, 36);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F);
            textBoxPassword.Location = new Point(346, 273);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(221, 29);
            textBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F);
            labelPassword.Location = new Point(239, 275);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(83, 21);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password :";
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Font = new Font("Segoe UI", 9F);
            labelRegister.Location = new Point(281, 377);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(118, 15);
            labelRegister.TabIndex = 5;
            labelRegister.Text = "Belum Punya Akun??";
            // 
            // linkLabelDatar
            // 
            linkLabelDatar.AutoSize = true;
            linkLabelDatar.LinkColor = Color.DarkTurquoise;
            linkLabelDatar.Location = new Point(405, 377);
            linkLabelDatar.Name = "linkLabelDatar";
            linkLabelDatar.Size = new Size(90, 15);
            linkLabelDatar.TabIndex = 7;
            linkLabelDatar.TabStop = true;
            linkLabelDatar.Text = "Daftar Sekarang";
            linkLabelDatar.LinkClicked += linkLabelDatar_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(313, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            labelLogin.Location = new Point(359, 9);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(83, 31);
            labelLogin.TabIndex = 9;
            labelLogin.Text = "LOGIN";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelLogin);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabelDatar);
            Controls.Add(labelRegister);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxUsn);
            Controls.Add(labelUsn);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsn;
        private TextBox textBoxUsn;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Label labelRegister;
        private LinkLabel linkLabelDatar;
        private PictureBox pictureBox1;
        private Label labelLogin;
    }
}
