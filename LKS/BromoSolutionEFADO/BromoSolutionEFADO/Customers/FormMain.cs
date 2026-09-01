using BromoSolutionEFADO.Model;
using ContohSoal1.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BromoSolutionEFADO.Customers
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        BandaraEntities db = new BandaraEntities();

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelNamaAkun.Text = Session.loggedIn.Nama + " ???";

            dateTimePickerTanggalBerangkat.MinDate = DateTime.Today;
            dateTimePickerTanggalBerangkat.Value = DateTime.Today;

            bandaraAutoComplete();
        }


        private void bandaraAutoComplete()
        {
            var semuaBandara = db.Bandaras.ToList();

            AutoCompleteStringCollection daftarSaran = new AutoCompleteStringCollection();

            foreach (var bandara in semuaBandara)
            {
                string text = $"{bandara.Nama}, {bandara.Kota} ({bandara.KodeIATA })";
                daftarSaran.Add(text);
            }

            foreach (TextBox txt in new[] {textBoxBerangkat, textBoxTujuan})
            {
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt.AutoCompleteCustomSource = daftarSaran;
            }
        }

        private string ambilIATA(string textInput)
        {
            if (string.IsNullOrWhiteSpace(textInput))
            {
                return null;
            }

            int posisiBukaKurung = textInput.LastIndexOf("(");
            int posisiTutupKurung = textInput.LastIndexOf(")");

            if (posisiBukaKurung == -1 || posisiTutupKurung == -1 || posisiTutupKurung < posisiBukaKurung)
            {
                return null;
            }

            int panjangKode = posisiTutupKurung - posisiBukaKurung - 1;

            string kodeIATA = textInput.Substring(posisiBukaKurung + 1, panjangKode);

            return kodeIATA.Trim();
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            Session.loggedIn = null;

            MessageBox.Show("Bye wokk :p");

            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void buttonCariPenerbangan_Click(object sender, EventArgs e)
        {
            string kodeAsal = ambilIATA(textBoxBerangkat.Text);
            string kodeTujuan = ambilIATA(textBoxTujuan.Text);

            if (kodeAsal == null)
            {
                MessageBox.Show("Ga ada wok bandara keberangkatannya", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (kodeTujuan == null)
            {
                MessageBox.Show("Ga ada wok bandara tujuannya", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericUpDownPenumpang.Value <= 0)
            {
                MessageBox.Show("Minimal 1 penumpang lah yaaa, klo ga ada mah ngapain beli tiket kocakkk");
                return;
            }

            var daftarBandara = db.Bandaras.Where(b => b.KodeIATA == kodeAsal || b.KodeIATA == kodeTujuan).ToList();

            var bandaraAsal = daftarBandara.FirstOrDefault(b => b.KodeIATA == kodeAsal);
            var bandaraTujuan = daftarBandara.FirstOrDefault(b => b.KodeIATA == kodeTujuan);

            if (bandaraAsal == null || bandaraTujuan == null)
            {
                MessageBox.Show("bandaranya ga ada di database wok", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            labelWelcome.Text = "Kode asal : " + kodeAsal + ". Kode tujuan : " + kodeTujuan;
            labelNamaAkun.Text = "";
            Hide();

            new FormListPenerbangan(this, bandaraAsal.ID, bandaraTujuan.ID, dateTimePickerTanggalBerangkat.Value, Convert.ToInt32(numericUpDownPenumpang.Value)).Show();
        }

        private void pictureBoxTiket_Click(object sender, EventArgs e)
        {
            FormTiketSaya tiketSaya = new FormTiketSaya();
            tiketSaya.Show();

            this.Hide();
        }
    }
}
