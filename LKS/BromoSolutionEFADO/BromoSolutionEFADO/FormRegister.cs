using BromoSolutionEFADO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BromoSolutionEFADO
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        BandaraEntities db = new BandaraEntities();

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            if (textBoxUsn.Text.Trim() == "" || textBoxNama.Text.Trim() == "" || dateTimePickerTanggalLahir.Value.Date == DateTime.Today || textBoxTelp.Text.Trim() == "" || textBoxPassword.Text.Trim() == "")
            {
                MessageBox.Show("Tolong isi semua data lah, emang lu lupa sama data diri lu sendiri??");
                return;
            }

            bool usernameSudahAda = db.Akuns.Any(a => a.Username == textBoxUsn.Text);

            if (usernameSudahAda)
            {
                MessageBox.Show("username sudah digunakan, bikin yang lain dong :) ");
                return;
            }

            if (!textBoxTelp.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Nomor telepon bosss, emang nomor mu bukan angka?? yang bener ajaa");
                return;
            }

            if (textBoxTelp.Text.Length < 10 || textBoxTelp.Text.Length > 15)
            {
                MessageBox.Show("Nomerlu cacat (klo ga kurang ya lebih)");
                return;
            }

            if (textBoxPassword.Text.Length < 8)
            {
                MessageBox.Show("Kasih password minimal 8 karakter, jangan lah lu kasih 1-8");
                return;
            }

            int umur = DateTime.Now.Year - dateTimePickerTanggalLahir.Value.Date.Year;

            if (dateTimePickerTanggalLahir.Value.Date > DateTime.Today.AddYears(-umur ))
            {
                umur--;
            }

            if (umur < 17)
            {
                MessageBox.Show("Minimal 17 tahun yaaa, jangan lu palsuin itu umur");
                return;
            }

        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
