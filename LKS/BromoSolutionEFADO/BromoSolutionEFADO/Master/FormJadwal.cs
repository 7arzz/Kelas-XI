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
                .OrderByDescending(j => j.TanggalWaktuKeberangkatan)
                .ToList()
                .Select(j => new
                {
                    j.ID,
                    j.KodePenerbangan,
                    BandaraAsal = j.Bandara.Nama,
                    BandaraTujuan = j.Bandara1.Nama,
                    Maskapai = j.Maskapai.Nama,

                    Tanggal = j.TanggalWaktuKeberangkatan.ToString("dd/MM/yyyy"),

                    Waktu = j.TanggalWaktuKeberangkatan.ToString("HH:mm"),

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
            var hasil = MessageBox.Show(
                "Yakin lo batal??",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (hasil == DialogResult.Yes)
            {
                clearForm();
                return;
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (
                textBoxKodePenerbangan.Text.Trim() == "" ||
                comboBoxAsal.SelectedIndex == -1 ||
                comboBoxTujuan.SelectedIndex == -1 ||
                comboBoxMaskapai.SelectedIndex == -1 ||
                numericUpDownHargaTicket.Value <= 0 ||
                dateTimePickerTanggal.Value.Date < DateTime.Today
            )
            {
                MessageBox.Show("benerin dan lengkapin dulu lah datanya wok");
                return;
            }

            if (textBoxKodePenerbangan.Text.Length != 7)
            {
                MessageBox.Show("Kode nya kurang panjang bosku, harusnya 7 karakter (AA-0000)");
                return;
            }

            if (
                !char.IsLetter(textBoxKodePenerbangan.Text[0]) ||
                !char.IsLetter(textBoxKodePenerbangan.Text[1])
            )
            {
                MessageBox.Show("2 karakter pertama harus huruf yaa boskuuu (AA-0000)");
                return;
            }

            if (textBoxKodePenerbangan.Text[2] != '-')
            {
                MessageBox.Show("habis 2 huruf lanjut '-' ya boskuuu (AA-0000)");
                return;
            }

            if (
                !char.IsDigit(textBoxKodePenerbangan.Text[3]) ||
                !char.IsDigit(textBoxKodePenerbangan.Text[4]) ||
                !char.IsDigit(textBoxKodePenerbangan.Text[5]) ||
                !char.IsDigit(textBoxKodePenerbangan.Text[6])
            )
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

            int jam = Convert.ToInt32(durasi[0]);
            int menit = Convert.ToInt32(durasi[2]);

            if (menit >= 60)
            {
                MessageBox.Show("Menit harus kurang dari 60.");
                return;
            }

            int totalMenit = (jam * 60) + menit;

            if (idJadwal == -1)
            {
                JadwalPenerbangan jadwalBaru = new JadwalPenerbangan();

                jadwalBaru.KodePenerbangan = textBoxKodePenerbangan.Text;
                jadwalBaru.BandaraKeberangkatanID = Convert.ToInt32(comboBoxAsal.SelectedValue);
                jadwalBaru.BandaraTujuanID = Convert.ToInt32(comboBoxTujuan.SelectedValue);
                jadwalBaru.MaskapaiID = Convert.ToInt32(comboBoxMaskapai.SelectedValue);

                jadwalBaru.TanggalWaktuKeberangkatan =
                    dateTimePickerTanggal.Value.Date +
                    dateTimePickerWaktuKeberangkatan.Value.TimeOfDay;

                jadwalBaru.DurasiPenerbangan = totalMenit;
                jadwalBaru.HargaPerTiket = Convert.ToDouble(numericUpDownHargaTicket.Value);

                db.JadwalPenerbangans.Add(jadwalBaru);

                MessageBox.Show("Data udah di simpan wok");
              
            }
            else
            {
                JadwalPenerbangan editJadwal =
                    db.JadwalPenerbangans.Find(idJadwal);

                if (editJadwal == null)
                {
                    MessageBox.Show("Data jadwal tidak ditemukan");
                    return;
                }

                editJadwal.KodePenerbangan = textBoxKodePenerbangan.Text;
                editJadwal.BandaraKeberangkatanID = Convert.ToInt32(comboBoxAsal.SelectedValue);
                editJadwal.BandaraTujuanID = Convert.ToInt32(comboBoxTujuan.SelectedValue);
                editJadwal.MaskapaiID = Convert.ToInt32(comboBoxMaskapai.SelectedValue);

                editJadwal.TanggalWaktuKeberangkatan =
                    dateTimePickerTanggal.Value.Date +
                    dateTimePickerWaktuKeberangkatan.Value.TimeOfDay;

                editJadwal.DurasiPenerbangan = totalMenit;
                editJadwal.HargaPerTiket = Convert.ToDouble(numericUpDownHargaTicket.Value);


                MessageBox.Show("Oke, data udah di ubah");
                
            }

            db.SaveChanges();
            clearForm();
            loadJadwal();
        }

        private void dataGridViewJadwal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridViewJadwal.Columns[e.ColumnIndex].Name == "Edit")
            {
                idJadwal = Convert.ToInt32(
                    dataGridViewJadwal.Rows[e.RowIndex].Cells["ID"].Value
                );

                JadwalPenerbangan editJadwal =
                    db.JadwalPenerbangans.Find(idJadwal);

                if (editJadwal == null)
                {
                    MessageBox.Show("Data jadwal tidak ditemukan");
                    return;
                }

                int jam = editJadwal.DurasiPenerbangan / 60;
                int menit = editJadwal.DurasiPenerbangan % 60;

                string menitKeDurasi =
                    jam + " Jam " + menit + " Menit";

                textBoxKodePenerbangan.Text =
                    editJadwal.KodePenerbangan;

                comboBoxAsal.SelectedValue =
                    editJadwal.BandaraKeberangkatanID;

                comboBoxTujuan.SelectedValue =
                    editJadwal.BandaraTujuanID;

                comboBoxMaskapai.SelectedValue =
                    editJadwal.MaskapaiID;

                dateTimePickerTanggal.Value =
                    editJadwal.TanggalWaktuKeberangkatan.Date;

                dateTimePickerWaktuKeberangkatan.Value =
                    DateTime.Today +
                    editJadwal.TanggalWaktuKeberangkatan.TimeOfDay;

                textBoxDurasi.Text =
                    menitKeDurasi;

                numericUpDownHargaTicket.Value =
                    Convert.ToDecimal(editJadwal.HargaPerTiket);

                buttonSimpan.Text = "Update";
            }
            else if (dataGridViewJadwal.Columns[e.ColumnIndex].Name == "Hapus")
            {
                int id = Convert.ToInt32(
                    dataGridViewJadwal.Rows[e.RowIndex].Cells["ID"].Value
                );

                var hasil = MessageBox.Show(
                    "Yakin di hapus wok?? ga bisa di balikin lhoo",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (hasil == DialogResult.Yes)
                {
                    JadwalPenerbangan hapusJadwal =
                        db.JadwalPenerbangans.Find(id);

                    if (hapusJadwal != null)
                    {
                        db.JadwalPenerbangans.Remove(hapusJadwal);
                        db.SaveChanges();

                        loadJadwal();
                        clearForm();

                        MessageBox.Show("OK, udah di hapus");
                    }
                }
            }
        }
    }
}