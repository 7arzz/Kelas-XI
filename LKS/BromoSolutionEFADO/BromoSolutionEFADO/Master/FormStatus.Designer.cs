using System.Drawing;
using System.Windows.Forms;
using System;
using BromoSolutionEFADO.Properties;

namespace BromoSolutionEFADO.Master
{
    partial class FormStatus
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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            numericUpDown2 = new NumericUpDown();
            buttonBatal = new Button();
            buttonSimpan = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(161, 25);
            label10.TabIndex = 51;
            label10.Text = "MASTER STATUS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 25);
            label2.Name = "label2";
            label2.Size = new Size(176, 15);
            label2.TabIndex = 50;
            label2.Text = "Ubah status penerbangan di sini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(593, 271);
            dataGridView1.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(8, 277);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 53;
            label1.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(62, 277);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(260, 281);
            label3.Name = "label3";
            label3.Size = new Size(103, 19);
            label3.TabIndex = 53;
            label3.Text = "Perkiraan Delay";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(369, 278);
            numericUpDown1.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(48, 23);
            numericUpDown1.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(423, 281);
            label4.Name = "label4";
            label4.Size = new Size(33, 19);
            label4.TabIndex = 53;
            label4.Text = "Jam";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(516, 281);
            label5.Name = "label5";
            label5.Size = new Size(45, 19);
            label5.TabIndex = 53;
            label5.Text = "Menit";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(462, 278);
            numericUpDown2.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(48, 23);
            numericUpDown2.TabIndex = 55;
            // 
            // buttonBatal
            // 
            buttonBatal.Location = new Point(297, 307);
            buttonBatal.Name = "buttonBatal";
            buttonBatal.Size = new Size(75, 23);
            buttonBatal.TabIndex = 56;
            buttonBatal.Text = "Batal";
            buttonBatal.UseVisualStyleBackColor = true;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Location = new Point(396, 307);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(75, 23);
            buttonSimpan.TabIndex = 56;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            // 
            // FormStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 343);
            Controls.Add(buttonSimpan);
            Controls.Add(buttonBatal);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Controls.Add(label2);
            Name = "FormStatus";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormStatus";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown2;
        private Button buttonBatal;
        private Button buttonSimpan;
    }
}