using BromoSolutionEFADO.Model;
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
    public partial class FormTiketSaya : Form
    {
        public FormTiketSaya()
        {
            InitializeComponent();
        }

        BandaraEntities db = new BandaraEntities();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();

            this.Close();
        }

        private void FormTiketSaya_Load(object sender, EventArgs e)
        {
            MuatDaftarTicket();
        }

        private void MuatDaftarTicket()
        {
            var daftarTiket = db.TransaksiHeaders
                .Where(t => t.AkunID == Session.loggedIn.ID)
                .Where(t => t.JadwalPenerbangan.TanggalWaktuKeberangkatan >= DateTime.Now)
                .Select(t => new {
                    KodePenerbangan = t.JadwalPenerbangan.KodePenerbangan,
                    Maskapai = t.JadwalPenerbangan.Maskapai.Nama,
                    BandaraKeberangkatan = t.JadwalPenerbangan.Bandara.Nama,
                    BandaraTujuan = t.JadwalPenerbangan.Bandara1.Nama,
                    TanggalKeberangkatan = t.JadwalPenerbangan.TanggalWaktuKeberangkatan,
                    WaktuKeberangkatan = t.JadwalPenerbangan.TanggalWaktuKeberangkatan,
                    DurasiPenerbangan = t.JadwalPenerbangan.DurasiPenerbangan,
                    JadwalPenerbanganID = t.JadwalPenerbangan.ID
                }).ToList();

            var dataTampil = daftarTiket
                .Select(t => new {
                    t.KodePenerbangan,
                    t.Maskapai,
                    t.BandaraKeberangkatan,
                    t.BandaraTujuan,
                    t.TanggalKeberangkatan,
                    WaktuPenerbangan = t.WaktuKeberangkatan.ToString("HH:mm") + " - " + t.WaktuKeberangkatan.AddMinutes(t.DurasiPenerbangan).ToString("HH:mm"),
                    StatusTerakhir = AmbilStatusTerakhir(t.JadwalPenerbanganID)
                }).ToList();

            dataGridViewTiket.DataSource = dataTampil;
        }

        private string AmbilStatusTerakhir(int IdJadwalPenerbangan)
        {
            var statusTerbaru = db.PerubahanStatusJadwalPenerbangans
                .Where(p => p.JadwalPenerbanganID == IdJadwalPenerbangan)
                .OrderByDescending(p => p.WaktuPerubahanTerjadi)
                .FirstOrDefault();

            if (statusTerbaru == null)
            {
                return "Sesuai Jadwal";
            }

            string namaStatus = statusTerbaru.StatusPenerbangan.Nama;
            if (namaStatus == "Delay" && statusTerbaru.PerkiraanDurasiDelay != null)
            {
                int totalMenit = statusTerbaru.PerkiraanDurasiDelay.Value;
                int jam = totalMenit / 60;  
                int menit = totalMenit % 60;

                return "Delay kurang lebih " + jam.ToString("00") + " Jam " + menit.ToString("00") + " Menit";
            }

            return namaStatus;
        }
    }
}
