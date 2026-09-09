namespace HovSedhep
{
    partial class FormMain
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
            this.buttonTableSeating = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonTableSeating
            // 
            this.buttonTableSeating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTableSeating.Location = new System.Drawing.Point(12, 41);
            this.buttonTableSeating.Name = "buttonTableSeating";
            this.buttonTableSeating.Size = new System.Drawing.Size(112, 83);
            this.buttonTableSeating.TabIndex = 0;
            this.buttonTableSeating.Text = "Table Seating";
            this.buttonTableSeating.UseVisualStyleBackColor = true;
            this.buttonTableSeating.Click += new System.EventHandler(this.buttonTableSeating_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(12, 197);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(112, 83);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistory.Location = new System.Drawing.Point(12, 366);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(112, 83);
            this.buttonHistory.TabIndex = 1;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(141, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(881, 549);
            this.panelContent.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 551);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonTableSeating);
            this.Name = "FormMain";
            this.Text = "POS System HovSedhep";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTableSeating;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Panel panelContent;
    }
}

