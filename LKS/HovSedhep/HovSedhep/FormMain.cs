using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HovSedhep
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void openForm(Form form)
        {
            panelContent.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelContent.Controls.Add(form);
            form.Show();
        }

        private void resetBtnColor()
        {
            buttonTableSeating.BackColor = SystemColors.Control;
            buttonMenu.BackColor = SystemColors.Control;
            buttonHistory.BackColor = SystemColors.Control;

            buttonTableSeating.ForeColor = Color.Black;
            buttonMenu.ForeColor = Color.Black;
            buttonHistory.ForeColor = Color.Black;
        }

        private void buttonTableSeating_Click(object sender, EventArgs e)
        {
            openForm(new FormTableSeating());
            resetBtnColor();
            buttonTableSeating.BackColor = Color.Blue;
            buttonTableSeating.ForeColor = Color.White;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            openForm(new FormMenu ());
            resetBtnColor ();
            buttonMenu.BackColor = Color.Blue;
            buttonMenu.ForeColor = Color.White;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            openForm (new FormHistory());
            resetBtnColor () ;
            buttonHistory.BackColor = Color.Blue;
            buttonHistory.ForeColor = Color.White;
        }
    }
}
