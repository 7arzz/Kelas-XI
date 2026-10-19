namespace HovSalad
{
    partial class FormOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonIngredients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddSalad = new System.Windows.Forms.Button();
            this.buttonProteinBowl = new System.Windows.Forms.Button();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelRupiah = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelOrderCode = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonProteinBowl);
            this.groupBox1.Controls.Add(this.buttonAddSalad);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 513);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "  ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelRupiah);
            this.groupBox3.Controls.Add(this.labelHarga);
            this.groupBox3.Controls.Add(this.buttonIngredients);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(731, 239);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "  Order Item";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(6, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(731, 239);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ingredients";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonIngredients
            // 
            this.buttonIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngredients.Location = new System.Drawing.Point(537, 185);
            this.buttonIngredients.Name = "buttonIngredients";
            this.buttonIngredients.Size = new System.Drawing.Size(188, 31);
            this.buttonIngredients.TabIndex = 1;
            this.buttonIngredients.Text = "Add Ingredients";
            this.buttonIngredients.UseVisualStyleBackColor = true;
            this.buttonIngredients.Click += new System.EventHandler(this.buttonIngredients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(24, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 26);
            this.textBox1.TabIndex = 1;
            // 
            // buttonAddSalad
            // 
            this.buttonAddSalad.Location = new System.Drawing.Point(333, 53);
            this.buttonAddSalad.Name = "buttonAddSalad";
            this.buttonAddSalad.Size = new System.Drawing.Size(174, 42);
            this.buttonAddSalad.TabIndex = 2;
            this.buttonAddSalad.Text = "Add Salad";
            this.buttonAddSalad.UseVisualStyleBackColor = true;
            // 
            // buttonProteinBowl
            // 
            this.buttonProteinBowl.Location = new System.Drawing.Point(544, 53);
            this.buttonProteinBowl.Name = "buttonProteinBowl";
            this.buttonProteinBowl.Size = new System.Drawing.Size(174, 42);
            this.buttonProteinBowl.TabIndex = 2;
            this.buttonProteinBowl.Text = "Add Protein Bowl";
            this.buttonProteinBowl.UseVisualStyleBackColor = true;
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(14, 203);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(84, 24);
            this.labelHarga.TabIndex = 2;
            this.labelHarga.Text = "Harga : ";
            // 
            // labelRupiah
            // 
            this.labelRupiah.AutoSize = true;
            this.labelRupiah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRupiah.Location = new System.Drawing.Point(104, 203);
            this.labelRupiah.Name = "labelRupiah";
            this.labelRupiah.Size = new System.Drawing.Size(98, 24);
            this.labelRupiah.TabIndex = 2;
            this.labelRupiah.Text = "xxxxxxxx";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(722, 189);
            this.dataGridView2.TabIndex = 0;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(466, 640);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(272, 38);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // labelOrderCode
            // 
            this.labelOrderCode.AutoSize = true;
            this.labelOrderCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderCode.Location = new System.Drawing.Point(14, 649);
            this.labelOrderCode.Name = "labelOrderCode";
            this.labelOrderCode.Size = new System.Drawing.Size(376, 20);
            this.labelOrderCode.TabIndex = 3;
            this.labelOrderCode.Text = "Order Code : YYMMDD - HHMMSS - XXXXXX";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 679);
            this.Controls.Add(this.labelOrderCode);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOrder";
            this.Text = "HovSalad - Order FOrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonIngredients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonProteinBowl;
        private System.Windows.Forms.Button buttonAddSalad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelRupiah;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelOrderCode;
    }
}