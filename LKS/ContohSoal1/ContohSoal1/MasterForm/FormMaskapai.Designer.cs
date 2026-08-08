namespace ContohSoal1.MasterForm
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
            buttonSimpan = new Button();
            buttonBatal = new Button();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // buttonSimpan
            // 
            buttonSimpan.Location = new Point(408, 308);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(75, 23);
            buttonSimpan.TabIndex = 26;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            // 
            // buttonBatal
            // 
            buttonBatal.Location = new Point(320, 308);
            buttonBatal.Name = "buttonBatal";
            buttonBatal.Size = new Size(75, 23);
            buttonBatal.TabIndex = 25;
            buttonBatal.Text = "Batal";
            buttonBatal.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(320, 222);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(230, 74);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(95, 253);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 23);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 286);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 17;
            label5.Text = "Jumlah Kru";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 257);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 16;
            label4.Text = "perusahaan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(269, 225);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 15;
            label8.Text = "Deskripsi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 226);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 13;
            label3.Text = "Nama";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(586, 155);
            dataGridView1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 30);
            label2.Name = "label2";
            label2.Size = new Size(226, 15);
            label2.TabIndex = 11;
            label2.Text = "Semua Maskapai yang terdaftar ada disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 5);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 10;
            label1.Text = "MASTER MASKAPAI";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(95, 286);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(161, 23);
            numericUpDown1.TabIndex = 27;
            // 
            // FormMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 343);
            Controls.Add(numericUpDown1);
            Controls.Add(buttonSimpan);
            Controls.Add(buttonBatal);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMaskapai";
            Text = "MaskapaiForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSimpan;
        private Button buttonBatal;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDown1;
    }
}