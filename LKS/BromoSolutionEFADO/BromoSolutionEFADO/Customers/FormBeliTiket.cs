using BromoSolutionEFADO.Model;
using ContohSoal1.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BromoSolutionEFADO.Customers
{
    public partial class FormBeliTiket : Form
    {

        private FormListPenerbangan formSebelumnya;
        private FormMain formMain;
        private int jadwalID;
        private int jumlahPenumpang;

        private List<UserControlPenumpang> daftarKartuPenumpang = new List<UserControlPenumpang>();

        private BandaraEntities db = new BandaraEntities();

        private JadwalPenerbangan jadwal;

        private double totalDiskon;
        private double totalPembayaranAkhir;
        private int? kodePromoID = null;
        private bool transaksiBerhasil; 

        public FormBeliTiket
            (
                FormListPenerbangan formSebelumnya,
                FormMain formMain,
                int jadwalID,
                int jumlahPenumpang
            )
        {
            InitializeComponent();

            this.formSebelumnya = formSebelumnya;
            this.formMain = formMain;
            this.jadwalID = jadwalID;
            this.jumlahPenumpang = jumlahPenumpang;
        }

        private void buttonPembayaran_Click(object sender, EventArgs e)
        {
            if (!ValidateDataPenumpang())
            {
                return;
            }

            if (!SimpanTransaksi())
            {
                return;
            }

            transaksiBerhasil = true;
            MessageBox.Show("Pembayaran berhasil wok", "Informastion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private bool SimpanTransaksi()
        {
            using (var databaseTransaction = db.Database.BeginTransaction())
            {
                try
                {
                    TransaksiHeader header = new TransaksiHeader
                    {
                        AkunID = Session.loggedIn.ID,

                        TanggalTransaksi = DateTime.Now,

                        JadwalPenerbanganID = jadwalID,

                        JumlahPenumpang = jumlahPenumpang,

                        TotalHarga = totalPembayaranAkhir,

                        KodePromoID = kodePromoID,
                    };

                    db.TransaksiHeaders.Add(header);
                    db.SaveChanges();

                    savePassengerDetail(header.ID);
                    db.SaveChanges();

                    databaseTransaction.Commit();

                    return true;
                }
                catch (Exception ex)
                {
                    databaseTransaction.Rollback();
                    MessageBox.Show("Transaksinya gagal disimpan wok \n\n" + "Detail error : " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //FormListPenerbangan listPenerbangan = new FormListPenerbangan();
            //listPenerbangan.Show();
            formSebelumnya.Show();
            this.Close();
        }

        private void FormBeliTiket_Load(object sender, EventArgs e)
        {
            if (!ValidatePenerbangan())
            {
                Close();
                return;
            }

            ShowParameter();

            kartuPenumpang();
        }

        private bool ValidatePenerbangan()
        {
            jadwal = db.JadwalPenerbangans.FirstOrDefault(j => j.ID == jadwalID);

            if (jadwal == null)
            {
                MessageBox.Show("Data penerbangannya ga ada wok", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ShowParameter()
        {
            DateTime waktuBerangkat = jadwal.TanggalWaktuKeberangkatan;

            labelAsal.Text = $"{jadwal.Bandara.Nama} ({jadwal.Bandara.KodeIATA})";
            labelTujuan.Text = $"{jadwal.Bandara1.Nama} ({jadwal.Bandara1.KodeIATA})";

            labelMaskapai.Text = jadwal.Maskapai.Nama;

            labelTanggal.Text = waktuBerangkat.ToString("dddd, dd MM yyyy");

            labelJam.Text = waktuBerangkat.ToString("HH:mm") + " - " + waktuBerangkat.AddMinutes(jadwal.DurasiPenerbangan).ToString("HH:mm");

            labelJumlahPenumpang.Text = jumlahPenumpang + " Penumpang";
        }

        private void kartuPenumpang()
        {
            flpPenumpang.Controls.Clear();

            daftarKartuPenumpang.Clear();

            for (int nomor = 1; nomor <= jumlahPenumpang; nomor++ )
            {
                UserControlPenumpang card = new UserControlPenumpang();

                card.NomorPenumpang = nomor;

                card.Width = flpPenumpang.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 10;

                daftarKartuPenumpang.Add(card);

                flpPenumpang.Controls.Add(card);
            }
        }

        private void totalCount()
        {
            double hargaBelumDiskon = jadwal.HargaPerTiket * jumlahPenumpang;

            totalPembayaranAkhir = hargaBelumDiskon - totalDiskon;

            totalPembayaranAkhir = Math.Max(totalPembayaranAkhir, 0);

            labelTotalPembayaran.Text = "IDR" + totalPembayaranAkhir.ToString("NO", CultureInfo.GetCultureInfo("id-ID")); 
        }

        private void buttonReedem_Click(object sender, EventArgs e)
        {
            string kodeInput = textBoxReedem.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(kodeInput))
            {
                MessageBox.Show("Masukkan kodenya dulu bosku", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ApplyPromoCode(kodeInput);
        }

        private void ApplyPromoCode(string kodeInput)
        {
            KodePromo promo = db.KodePromoes.FirstOrDefault(p => p.Kode == kodeInput);

            if (promo == null || promo.BerlakuSampai < DateTime.Today)
            {
                kodePromoID = null;
                totalDiskon = 0;
                totalCount();

                MessageBox.Show("Kode promo tidak valid atau udah kadaluarsa wkwkwk", "Kode Promo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            kodePromoID = promo.ID;
            double totalSebelumDiskon = jadwal.HargaPerTiket * jumlahPenumpang;

            double diskonDenganPersen = totalSebelumDiskon * promo.PersentaseDiskon / 100.0;

            totalDiskon = Math.Min(diskonDenganPersen, promo.MaksimumDiskon);

            totalCount();

            MessageBox.Show("Oke, kode berhasil di pake cuyy", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateDataPenumpang()
        {
            for (int i = 0; i < daftarKartuPenumpang.Count; i++)
            {
                UserControlPenumpang card = daftarKartuPenumpang[i];

                if (!card.dataLengkap)
                {
                    MessageBox.Show("Lengkapi dulu data penumpangnya #" + (i + 1), "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void savePassengerDetail(int transaksiHeaderID)
        {
            foreach (UserControlPenumpang card in daftarKartuPenumpang)
            {
                TransaksiDetail detail = new TransaksiDetail
                {
                    TransaksiHeaderID = transaksiHeaderID,
                    TitelPenumpang = card.Title,
                    NamaLengkapPenumpang = card.NamaLengkap,
                };

                db.TransaksiDetails.Add(detail);
            }
        }

        private void FormBeliTiket_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (transaksiBerhasil)
            {
                formMain.Show();
            }
            else
            {
                formSebelumnya.Show();
            }
        }
    }
}
