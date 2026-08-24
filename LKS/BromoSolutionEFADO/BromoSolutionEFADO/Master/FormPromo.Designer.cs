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
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBoxNama = new TextBox();
            buttonSimpan = new Button();
            buttonBatal = new Button();
            label6 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            numericUpDown2 = new NumericUpDown();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 4);
            label10.Name = "label10";
            label10.Size = new Size(216, 25);
            label10.TabIndex = 49;
            label10.Text = "MASTER KODE PROMO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(105, 246);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 47;
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(95, 217);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(161, 23);
            textBoxNama.TabIndex = 46;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Location = new Point(324, 306);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(84, 33);
            buttonSimpan.TabIndex = 39;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            // 
            // buttonBatal
            // 
            buttonBatal.Location = new Point(428, 306);
            buttonBatal.Name = "buttonBatal";
            buttonBatal.Size = new Size(78, 33);
            buttonBatal.TabIndex = 40;
            buttonBatal.Text = "Batal";
            buttonBatal.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 252);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 37;
            label6.Text = "Berlaku Sampai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 221);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 38;
            label3.Text = "Kode Promo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(586, 155);
            dataGridView1.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 29);
            label2.Name = "label2";
            label2.Size = new Size(242, 15);
            label2.TabIndex = 29;
            label2.Text = "Semua Kode Promo yang terdaftar ada disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 283);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 38;
            label1.Text = "Persentase Diskon";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(119, 281);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 314);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 38;
            label4.Text = "Maksimum Diskon";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(119, 312);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 221);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 38;
            label5.Text = "Deskripsi";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(324, 243);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(193, 61);
            richTextBox1.TabIndex = 51;
            richTextBox1.Text = "";
            // 
            // FormPromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 343);
            Controls.Add(richTextBox1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxNama);
            Controls.Add(buttonSimpan);
            Controls.Add(label4);
            Controls.Add(buttonBatal);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Name = "FormPromo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormPromo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxNama;
        private Button buttonSimpan;
        private Button buttonBatal;
        private Label label6;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private RichTextBox richTextBox1;
    }
}