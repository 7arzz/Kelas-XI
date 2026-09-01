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
            this.labelUsn = new System.Windows.Forms.Label();
            this.textBoxUsn = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.linkLabelDatar = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsn
            // 
            this.labelUsn.AutoSize = true;
            this.labelUsn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelUsn.Location = new System.Drawing.Point(205, 208);
            this.labelUsn.Name = "labelUsn";
            this.labelUsn.Size = new System.Drawing.Size(88, 21);
            this.labelUsn.TabIndex = 0;
            this.labelUsn.Text = "Username :";
            // 
            // textBoxUsn
            // 
            this.textBoxUsn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxUsn.Location = new System.Drawing.Point(297, 206);
            this.textBoxUsn.Name = "textBoxUsn";
            this.textBoxUsn.Size = new System.Drawing.Size(190, 29);
            this.textBoxUsn.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonLogin.Location = new System.Drawing.Point(200, 282);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(286, 42);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(297, 237);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(190, 29);
            this.textBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPassword.Location = new System.Drawing.Point(205, 238);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(83, 21);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password :";
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelRegister.Location = new System.Drawing.Point(241, 327);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(118, 15);
            this.labelRegister.TabIndex = 5;
            this.labelRegister.Text = "Belum Punya Akun??";
            // 
            // linkLabelDatar
            // 
            this.linkLabelDatar.AutoSize = true;
            this.linkLabelDatar.LinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkLabelDatar.Location = new System.Drawing.Point(347, 327);
            this.linkLabelDatar.Name = "linkLabelDatar";
            this.linkLabelDatar.Size = new System.Drawing.Size(85, 13);
            this.linkLabelDatar.TabIndex = 7;
            this.linkLabelDatar.TabStop = true;
            this.linkLabelDatar.Text = "Daftar Sekarang";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.labelLogin.Location = new System.Drawing.Point(308, 8);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(83, 31);
            this.labelLogin.TabIndex = 9;
            this.labelLogin.Text = "LOGIN";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelDatar);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxUsn);
            this.Controls.Add(this.labelUsn);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
