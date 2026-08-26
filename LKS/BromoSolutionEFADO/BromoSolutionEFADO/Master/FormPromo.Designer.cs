using System.Drawing;
using System.Windows.Forms;
using System;
using BromoSolutionEFADO.Properties;

namespace BromoSolutionEFADO.Master
{
    partial class FormPromo
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
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerBerlaku = new System.Windows.Forms.DateTimePicker();
            this.textBoxKode = new System.Windows.Forms.TextBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewPromo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPersentaseDiskon = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMaxDiskon = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxDeskripsi = new System.Windows.Forms.RichTextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersentaseDiskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxDiskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BerlakuSampai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPersentaseDiskon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxDiskon)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 25);
            this.label10.TabIndex = 49;
            this.label10.Text = "MASTER KODE PROMO";
            // 
            // dateTimePickerBerlaku
            // 
            this.dateTimePickerBerlaku.Location = new System.Drawing.Point(94, 213);
            this.dateTimePickerBerlaku.Name = "dateTimePickerBerlaku";
            this.dateTimePickerBerlaku.Size = new System.Drawing.Size(186, 20);
            this.dateTimePickerBerlaku.TabIndex = 47;
            // 
            // textBoxKode
            // 
            this.textBoxKode.Location = new System.Drawing.Point(81, 188);
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(139, 20);
            this.textBoxKode.TabIndex = 46;
            this.textBoxKode.TextChanged += new System.EventHandler(this.textBoxKode_TextChanged);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(310, 265);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(72, 29);
            this.buttonSimpan.TabIndex = 39;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(399, 265);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(67, 29);
            this.buttonBatal.TabIndex = 40;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Berlaku Sampai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Kode Promo";
            // 
            // dataGridViewPromo
            // 
            this.dataGridViewPromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPromo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Kode,
            this.PersentaseDiskon,
            this.MaxDiskon,
            this.BerlakuSampai,
            this.Deskripsi,
            this.Edit,
            this.Hapus});
            this.dataGridViewPromo.Location = new System.Drawing.Point(3, 43);
            this.dataGridViewPromo.Name = "dataGridViewPromo";
            this.dataGridViewPromo.Size = new System.Drawing.Size(502, 134);
            this.dataGridViewPromo.TabIndex = 30;
            this.dataGridViewPromo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPromo_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Semua Kode Promo yang terdaftar ada disini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Persentase Diskon";
            // 
            // numericUpDownPersentaseDiskon
            // 
            this.numericUpDownPersentaseDiskon.Location = new System.Drawing.Point(109, 244);
            this.numericUpDownPersentaseDiskon.Name = "numericUpDownPersentaseDiskon";
            this.numericUpDownPersentaseDiskon.Size = new System.Drawing.Size(103, 20);
            this.numericUpDownPersentaseDiskon.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Maksimum Diskon";
            // 
            // numericUpDownMaxDiskon
            // 
            this.numericUpDownMaxDiskon.Location = new System.Drawing.Point(109, 270);
            this.numericUpDownMaxDiskon.Maximum = new decimal(new int[] {
            -402653185,
            -1613725636,
            54210108,
            0});
            this.numericUpDownMaxDiskon.Name = "numericUpDownMaxDiskon";
            this.numericUpDownMaxDiskon.Size = new System.Drawing.Size(103, 20);
            this.numericUpDownMaxDiskon.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Deskripsi";
            // 
            // richTextBoxDeskripsi
            // 
            this.richTextBoxDeskripsi.Location = new System.Drawing.Point(310, 211);
            this.richTextBoxDeskripsi.Name = "richTextBoxDeskripsi";
            this.richTextBoxDeskripsi.Size = new System.Drawing.Size(166, 53);
            this.richTextBoxDeskripsi.TabIndex = 51;
            this.richTextBoxDeskripsi.Text = "";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Kode
            // 
            this.Kode.DataPropertyName = "Kode";
            this.Kode.HeaderText = "Kode";
            this.Kode.Name = "Kode";
            // 
            // PersentaseDiskon
            // 
            this.PersentaseDiskon.DataPropertyName = "PersentaseDiskon";
            this.PersentaseDiskon.HeaderText = "Persentase Diskon";
            this.PersentaseDiskon.Name = "PersentaseDiskon";
            // 
            // MaxDiskon
            // 
            this.MaxDiskon.DataPropertyName = "MaksimumDiskon";
            this.MaxDiskon.HeaderText = "Max Diskon";
            this.MaxDiskon.Name = "MaxDiskon";
            // 
            // BerlakuSampai
            // 
            this.BerlakuSampai.DataPropertyName = "BerlakuSampai";
            this.BerlakuSampai.HeaderText = "Berlaku Sampai";
            this.BerlakuSampai.Name = "BerlakuSampai";
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
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Edit";
            // 
            // Hapus
            // 
            this.Hapus.HeaderText = "Hapus";
            this.Hapus.Name = "Hapus";
            // 
            // FormPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 297);
            this.Controls.Add(this.richTextBoxDeskripsi);
            this.Controls.Add(this.numericUpDownMaxDiskon);
            this.Controls.Add(this.numericUpDownPersentaseDiskon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePickerBerlaku);
            this.Controls.Add(this.textBoxKode);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewPromo);
            this.Controls.Add(this.label2);
            this.Name = "FormPromo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPromo";
            this.Load += new System.EventHandler(this.FormPromo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPersentaseDiskon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxDiskon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private DateTimePicker dateTimePickerBerlaku;
        private TextBox textBoxKode;
        private Button buttonSimpan;
        private Button buttonBatal;
        private Label label6;
        private Label label3;
        private DataGridView dataGridViewPromo;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownPersentaseDiskon;
        private Label label4;
        private NumericUpDown numericUpDownMaxDiskon;
        private Label label5;
        private RichTextBox richTextBoxDeskripsi;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Kode;
        private DataGridViewTextBoxColumn PersentaseDiskon;
        private DataGridViewTextBoxColumn MaxDiskon;
        private DataGridViewTextBoxColumn BerlakuSampai;
        private DataGridViewTextBoxColumn Deskripsi;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Hapus;
    }
}