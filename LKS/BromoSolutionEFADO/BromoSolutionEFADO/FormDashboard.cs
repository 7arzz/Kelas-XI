using BromoSolutionEFADO;
using BromoSolutionEFADO.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BromoSolutionEFADO
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void OpenForm(Form form)
        {
            panelContent.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelContent.Controls.Add(form);
            form.Show();
        }

        private void resetForeColor()
        {
            labelBandara.ForeColor = Color.Gray;
            labelMaskapai.ForeColor = Color.Gray;
            labelJadwal.ForeColor = Color.Gray;
            labelPromo.ForeColor = Color.Gray;
            labelStatus.ForeColor = Color.Gray;
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Close();
            login.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Close();
            login.Show();
        }

        // LABEL
        private void labelBandara_Click_1(object sender, EventArgs e)
        {
            resetForeColor();
            labelBandara.ForeColor = Color.Black;
            OpenForm(new FormBandara());
        }

        private void labelMaskapai_Click_1(object sender, EventArgs e)
        {
            resetForeColor();
            labelMaskapai.ForeColor = Color.Black;
            OpenForm(new FormMaskapai());
        }

        private void labelJadwal_Click_1(object sender, EventArgs e)
        {
            resetForeColor();
            labelJadwal.ForeColor = Color.Black;
            OpenForm(new FormJadwal());
        }

        private void labelPromo_Click_1(object sender, EventArgs e)
        {
            resetForeColor();
            labelPromo.ForeColor = Color.Black;
            OpenForm(new FormPromo());
        }

        private void labelStatus_Click_1(object sender, EventArgs e)
        {
            resetForeColor();
            labelStatus.ForeColor = Color.Black;
            OpenForm(new FormStatus());
        }

        // PICTURE
        private void pictureBoxBandara_Click_1(object sender, EventArgs e)
        {
            resetForeColor();
            labelBandara.ForeColor = Color.Black;
            OpenForm(new FormBandara());
        }

        private void pictureBoxMaskapai_Click_1(object sender, EventArgs e)
        {
            resetForeColor();
            labelMaskapai.ForeColor = Color.Black;
            OpenForm(new FormMaskapai());
        }

        private void pictureBoxJadwal_Click_1(object sender, EventArgs e)
        {
            resetForeColor();
            labelJadwal.ForeColor = Color.Black;
            OpenForm(new FormJadwal());
        }

        private void pictureBoxPromo_Click_1(object sender, EventArgs e)
        {
            resetForeColor();
            labelPromo.ForeColor = Color.Black;
            OpenForm(new FormPromo());
        }

        private void pictureBoxStatus_Click(object sender, EventArgs e)
        {
            resetForeColor();
            labelStatus.ForeColor = Color.Black;
            OpenForm(new FormStatus());
        }

    }
}
