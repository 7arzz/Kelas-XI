using System.Drawing;
using System.Windows.Forms;
using System;
using BromoSolutionEFADO.Properties;

namespace BromoSolutionEFADO.Master
{
    partial class FormBandara
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewBandara = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxIATA = new System.Windows.Forms.TextBox();
            this.richTextBoxAlamat = new System.Windows.Forms.RichTextBox();
            this.textBoxKota = new System.Windows.Forms.TextBox();
            this.comboBoxNegara = new System.Windows.Forms.ComboBox();
            this.numericUpDownTerminal = new System.Windows.Forms.NumericUpDown();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodeIATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Negara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBandara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MASTER BANDARA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semua Bandara yang terdaftar ada disini";
            // 
            // dataGridViewBandara
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBandara.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBandara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBandara.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nama,
            this.KodeIATA,
            this.Kota,
            this.Negara,
            this.JumlahTerminal,
            this.Alamat,
            this.hapus,
            this.edit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBandara.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBandara.Location = new System.Drawing.Point(3, 48);
            this.dataGridViewBandara.Name = "dataGridViewBandara";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBandara.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBandara.Size = new System.Drawing.Size(502, 134);
            this.dataGridViewBandara.TabIndex = 2;
            this.dataGridViewBandara.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBandara_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kode IATA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Negara";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Jumlah Terminal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Alamat";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(82, 196);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(139, 20);
            this.textBoxNama.TabIndex = 4;
            // 
            // textBoxIATA
            // 
            this.textBoxIATA.Location = new System.Drawing.Point(82, 223);
            this.textBoxIATA.Name = "textBoxIATA";
            this.textBoxIATA.Size = new System.Drawing.Size(139, 20);
            this.textBoxIATA.TabIndex = 4;
            // 
            // richTextBoxAlamat
            // 
            this.richTextBoxAlamat.Location = new System.Drawing.Point(286, 223);
            this.richTextBoxAlamat.Name = "richTextBoxAlamat";
            this.richTextBoxAlamat.Size = new System.Drawing.Size(140, 65);
            this.richTextBoxAlamat.TabIndex = 6;
            this.richTextBoxAlamat.Text = "";
            // 
            // textBoxKota
            // 
            this.textBoxKota.Location = new System.Drawing.Point(82, 249);
            this.textBoxKota.Name = "textBoxKota";
            this.textBoxKota.Size = new System.Drawing.Size(139, 20);
            this.textBoxKota.TabIndex = 4;
            // 
            // comboBoxNegara
            // 
            this.comboBoxNegara.FormattingEnabled = true;
            this.comboBoxNegara.Location = new System.Drawing.Point(82, 276);
            this.comboBoxNegara.Name = "comboBoxNegara";
            this.comboBoxNegara.Size = new System.Drawing.Size(139, 21);
            this.comboBoxNegara.TabIndex = 7;
            // 
            // numericUpDownTerminal
            // 
            this.numericUpDownTerminal.Location = new System.Drawing.Point(328, 192);
            this.numericUpDownTerminal.Name = "numericUpDownTerminal";
            this.numericUpDownTerminal.Size = new System.Drawing.Size(98, 20);
            this.numericUpDownTerminal.TabIndex = 8;
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(433, 212);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(64, 26);
            this.buttonBatal.TabIndex = 9;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(431, 244);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(64, 25);
            this.buttonSimpan.TabIndex = 9;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
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
            // KodeIATA
            // 
            this.KodeIATA.DataPropertyName = "KodeIATA";
            this.KodeIATA.HeaderText = "Kode IATA";
            this.KodeIATA.Name = "KodeIATA";
            // 
            // Kota
            // 
            this.Kota.DataPropertyName = "Kota";
            this.Kota.HeaderText = "Kota";
            this.Kota.Name = "Kota";
            // 
            // Negara
            // 
            this.Negara.DataPropertyName = "Negara";
            this.Negara.HeaderText = "Negara";
            this.Negara.Name = "Negara";
            // 
            // JumlahTerminal
            // 
            this.JumlahTerminal.DataPropertyName = "JumlahTerminal";
            this.JumlahTerminal.HeaderText = "Jumlah Terminal";
            this.JumlahTerminal.Name = "JumlahTerminal";
            // 
            // Alamat
            // 
            this.Alamat.DataPropertyName = "Alamat";
            this.Alamat.HeaderText = "Alamat";
            this.Alamat.Name = "Alamat";
            // 
            // hapus
            // 
            this.hapus.DataPropertyName = "hapus";
            this.hapus.HeaderText = "";
            this.hapus.Name = "hapus";
            this.hapus.Text = "Hapus";
            // 
            // edit
            // 
            this.edit.DataPropertyName = "edit";
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Text = "Edit";
            // 
            // FormBandara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 297);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.numericUpDownTerminal);
            this.Controls.Add(this.comboBoxNegara);
            this.Controls.Add(this.richTextBoxAlamat);
            this.Controls.Add(this.textBoxKota);
            this.Controls.Add(this.textBoxIATA);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewBandara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBandara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BandaraForm";
            this.Load += new System.EventHandler(this.FormBandara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBandara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTerminal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridViewBandara;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxNama;
        private TextBox textBoxIATA;
        private RichTextBox richTextBoxAlamat;
        private TextBox textBoxKota;
        private ComboBox comboBoxNegara;
        private NumericUpDown numericUpDownTerminal;
        private Button buttonBatal;
        private Button buttonSimpan;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn KodeIATA;
        private DataGridViewTextBoxColumn Kota;
        private DataGridViewTextBoxColumn Negara;
        private DataGridViewTextBoxColumn JumlahTerminal;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewButtonColumn hapus;
        private DataGridViewButtonColumn edit;
    }
}