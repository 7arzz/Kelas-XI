using System.Drawing;
using System.Windows.Forms;
using System;
using BromoSolutionEFADO.Properties;

namespace ContohSoal1.Customer
{
    partial class UserControlPenumpang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNomor = new System.Windows.Forms.Label();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNamaLengkap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNomor
            // 
            this.labelNomor.AutoSize = true;
            this.labelNomor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomor.Location = new System.Drawing.Point(3, 2);
            this.labelNomor.Name = "labelNomor";
            this.labelNomor.Size = new System.Drawing.Size(147, 25);
            this.labelNomor.TabIndex = 9;
            this.labelNomor.Text = "Penumpang #$";
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Items.AddRange(new object[] {
            "Tuan",
            "Nyonya"});
            this.comboBoxTitle.Location = new System.Drawing.Point(138, 36);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(104, 21);
            this.comboBoxTitle.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Title";
            // 
            // textBoxNamaLengkap
            // 
            this.textBoxNamaLengkap.Location = new System.Drawing.Point(138, 68);
            this.textBoxNamaLengkap.Name = "textBoxNamaLengkap";
            this.textBoxNamaLengkap.Size = new System.Drawing.Size(306, 20);
            this.textBoxNamaLengkap.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nama Lengkap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(138, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "pastikan nama sama dengan KTP/SIM/Kartu tanda pengenal";
            // 
            // UserControlPenumpang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxNamaLengkap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTitle);
            this.Controls.Add(this.labelNomor);
            this.Name = "UserControlPenumpang";
            this.Size = new System.Drawing.Size(549, 130);
            this.Load += new System.EventHandler(this.UserControlPenumpang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNomor;
        private ComboBox comboBoxTitle;
        private Label label2;
        private TextBox textBoxNamaLengkap;
        private Label label3;
        private Label label4;
    }
}
