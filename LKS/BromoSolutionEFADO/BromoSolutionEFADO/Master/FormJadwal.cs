using BromoSolutionEFADO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BromoSolutionEFADO.Master
{
    public partial class FormJadwal : Form
    {
        public FormJadwal()
        {
            InitializeComponent();
        }

        BandaraEntities db = new BandaraEntities();
        private int idJadwal = -1;

        private void FormJadwal_Load(object sender, EventArgs e)
        {
            dataGridViewJadwal.AutoGenerateColumns = false;
            dataGridViewJadwal.AllowUserToAddRows = false;
            dataGridViewJadwal.ReadOnly = true;

            dateTimePickerWaktuKeberangkatan.Format = DateTimePickerFormat.Custom;
            dateTimePickerWaktuKeberangkatan.CustomFormat = "HH:mm";
            dateTimePickerWaktuKeberangkatan.ShowUpDown = true;

            loadBandara();
            loadMaskapai();
            loadJadwal();
        }

        private void loadBandara()
        {
            comboBoxAsal.DataSource = db.Bandaras.OrderBy(j => j.Nama).ToList();
            comboBoxAsal.DisplayMember = "Nama";
            comboBoxAsal.ValueMember = "ID";
            comboBoxAsal.SelectedIndex = -1;
                
            comboBoxTujuan.DataSource = db.Bandaras.OrderBy(j => j.Nama).ToList();
            comboBoxTujuan.DisplayMember = "Nama";
            comboBoxTujuan.ValueMember = "ID";
            comboBoxTujuan.SelectedIndex = -1;
        }
        private void loadMaskapai()
        {
            comboBoxMaskapai.DataSource = db.Maskapais.OrderBy(j => j.Nama).ToList();
            comboBoxMaskapai.DisplayMember = "Nama";
            comboBoxMaskapai.ValueMember = "ID";
            comboBoxMaskapai.SelectedIndex = -1;
            
        }
        private void loadJadwal()
        {
            var data = db.JadwalPenerbangans
                .OrderByDescending(j => j.TanggalKeberangkatan)
                .ThenByDescending(j => j.WaktuKeberangkatan)
                .ToList()
                .Select(j => new
                {
                    j.ID,
                    j.KodePenerbangan,
                    BandaraAsal = j.Bandara.Nama,
                    BandaraTujuan = j.Bandara1.Nama,
                    Maskapai = j.Maskapai.Nama,

                    Tanggal = j.TanggalKeberangkatan.ToString("dd/MM/yyyy"),

                    Waktu = j.WaktuKeberangkatan.ToString(),

                    DurasiPenerbangan =
                        (j.DurasiPenerbangan / 60) + " Jam " +
                        (j.DurasiPenerbangan % 60) + " Menit",

                    j.HargaPerTiket
                })
                .ToList();

            dataGridViewJadwal.DataSource = data;
        }

        private void clearForm()
        {
            textBoxKodePenerbangan.Clear();
            comboBoxAsal.SelectedIndex = -1;
            comboBoxTujuan.SelectedIndex = -1;
            comboBoxMaskapai.SelectedIndex = -1;
            dateTimePickerTanggal.Value = DateTime.Now;
            dateTimePickerWaktuKeberangkatan.Value = DateTime.Now;
            textBoxDurasi.Clear();
            numericUpDownHargaTicket.Value = 0;

            idJadwal = -1;

            buttonSimpan.Text = "Simpan";

            
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            var hasil = MessageBox.Show("Yakin lo batal??", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hasil == DialogResult.Yes)
            {
                clearForm();
                return;
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxKodePenerbangan.Text.Trim() == "" || comboBoxAsal.SelectedIndex == -1 || comboBoxTujuan.SelectedIndex == -1 || comboBoxMaskapai.SelectedIndex == -1 || numericUpDownHargaTicket.Value <= 0
                || dateTimePickerWaktuKeberangkatan.Value < DateTime.Today)
            {
                MessageBox.Show("benerin dan lengkapin dulu lah datanya wok");
                return;
            }

            if (textBoxKodePenerbangan.Text.Length != 7)
            {
                MessageBox.Show("Kode nya kurang panjang bosku, harusnya 7 karakter (AA-0000)");
                return;
            }

            if (!char.IsLetter(textBoxKodePenerbangan.Text[0]) || !char.IsLetter(textBoxKodePenerbangan.Text[1]))
            {
                MessageBox.Show("2 karakter pertama harus huruf yaa boskuuu (AA--0000)");
                return;
            }

            if (textBoxKodePenerbangan.Text[2] != '-')
            {
                MessageBox.Show("habis 2 huruf lanjut '-' ya boskuuu (AA-0000)");
                return;
            }

            if (!char.IsDigit(textBoxKodePenerbangan.Text[3]) || !char.IsDigit(textBoxKodePenerbangan.Text[4]) || !char.IsDigit(textBoxKodePenerbangan.Text[5]) || !char.IsDigit(textBoxKodePenerbangan.Text[6]))
            {
                MessageBox.Show("4 DIgit terakhir harus angka yaaaaaa (AA-0000)");
                return; 
            }

            if (comboBoxAsal.SelectedValue.Equals(comboBoxTujuan.SelectedValue))
            {
                MessageBox.Show("Klo asal sama tujuan sama ngapain ke sini bang??");
                return;
            }

            string[] durasi = textBoxDurasi.Text.Split(' ');

            if (durasi.Length != 4)
            {
                MessageBox.Show("Yang bener kasih durasi nyaa (xx Jam xx Menit)");
                return;
            }

            if (durasi[1] != "Jam" || durasi[3] != "Menit")
            {
                MessageBox.Show("udah dibilang formatnya xx Jam xx Menit");
                return;
            }

            if (!durasi[0].All(char.IsDigit) || !durasi[2].All(char.IsDigit))
            {
                MessageBox.Show("Jam dan menit harus angka bosss");
                return;
            }

            MessageBox.Show("OK, data udah masuk");
        }
    }
}
