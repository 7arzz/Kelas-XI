using System.Drawing;
using System.Windows.Forms;
using System;
using BromoSolutionEFADO.Properties;

namespace BromoSolutionEFADO.Master
{
    partial class FormMaskapai
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
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.richTextBoxDeskripsi = new System.Windows.Forms.RichTextBox();
            this.textBoxPerusahaan = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewMaskapai = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahKru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownJumlahKru = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaskapai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumlahKru)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(350, 267);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(64, 20);
            this.buttonSimpan.TabIndex = 26;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(274, 267);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(64, 20);
            this.buttonBatal.TabIndex = 25;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // richTextBoxDeskripsi
            // 
            this.richTextBoxDeskripsi.Location = new System.Drawing.Point(283, 192);
            this.richTextBoxDeskripsi.Name = "richTextBoxDeskripsi";
            this.richTextBoxDeskripsi.Size = new System.Drawing.Size(198, 65);
            this.richTextBoxDeskripsi.TabIndex = 22;
            this.richTextBoxDeskripsi.Text = "";
            // 
            // textBoxPerusahaan
            // 
            this.textBoxPerusahaan.Location = new System.Drawing.Point(81, 219);
            this.textBoxPerusahaan.Name = "textBoxPerusahaan";
            this.textBoxPerusahaan.Size = new System.Drawing.Size(139, 20);
            this.textBoxPerusahaan.TabIndex = 19;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(81, 192);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(139, 20);
            this.textBoxNama.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Jumlah Kru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "perusahaan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Deskripsi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nama";
            // 
            // dataGridViewMaskapai
            // 
            this.dataGridViewMaskapai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaskapai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nama,
            this.Perusahaan,
            this.JumlahKru,
            this.Deskripsi,
            this.Edit,
            this.Hapus});
            this.dataGridViewMaskapai.Location = new System.Drawing.Point(3, 44);
            this.dataGridViewMaskapai.Name = "dataGridViewMaskapai";
            this.dataGridViewMaskapai.Size = new System.Drawing.Size(502, 134);
            this.dataGridViewMaskapai.TabIndex = 12;
            this.dataGridViewMaskapai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaskapai_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Nama
            // 
            this.Nama.DataPropertyName = "Nama";
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            // 
            // Perusahaan
            // 
            this.Perusahaan.DataPropertyName = "Perusahaan";
            this.Perusahaan.HeaderText = "Perusahaan";
            this.Perusahaan.Name = "Perusahaan";
            // 
            // JumlahKru
            // 
            this.JumlahKru.DataPropertyName = "JumlahKru";
            this.JumlahKru.HeaderText = "Jumlah Kru";
            this.JumlahKru.Name = "JumlahKru";
            // 
            // Deskripsi
            // 
            this.Deskripsi.DataPropertyName = "Deskripsi";
            this.Deskripsi.HeaderText = "Deskripsi";
            this.Deskripsi.Name = "Deskripsi";
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            // 
            // Hapus
            // 
            this.Hapus.DataPropertyName = "Hapus";
            this.Hapus.HeaderText = "Hapus";
            this.Hapus.Name = "Hapus";
            this.Hapus.Text = "Hapus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Semua Maskapai yang terdaftar ada disini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "MASTER MASKAPAI";
            // 
            // numericUpDownJumlahKru
            // 
            this.numericUpDownJumlahKru.Location = new System.Drawing.Point(81, 248);
            this.numericUpDownJumlahKru.Name = "numericUpDownJumlahKru";
            this.numericUpDownJumlahKru.Size = new System.Drawing.Size(138, 20);
            this.numericUpDownJumlahKru.TabIndex = 27;
            // 
            // FormMaskapai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 297);
            this.Controls.Add(this.numericUpDownJumlahKru);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.richTextBoxDeskripsi);
            this.Controls.Add(this.textBoxPerusahaan);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewMaskapai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMaskapai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MaskapaiForm";
            this.Load += new System.EventHandler(this.FormMaskapai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaskapai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumlahKru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSimpan;
        private Button buttonBatal;
        private RichTextBox richTextBoxDeskripsi;
        private TextBox textBoxPerusahaan;
        private TextBox textBoxNama;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label3;
        private DataGridView dataGridViewMaskapai;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownJumlahKru;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Perusahaan;
        private DataGridViewTextBoxColumn JumlahKru;
        private DataGridViewTextBoxColumn Deskripsi;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Hapus;
    }
}