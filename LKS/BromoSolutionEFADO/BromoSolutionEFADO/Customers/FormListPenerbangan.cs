using BromoSolutionEFADO.Customers;
using BromoSolutionEFADO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Diagnostics;

namespace ContohSoal1.Customer
{
    public partial class FormListPenerbangan : Form
    {
        BandaraEntities db = new BandaraEntities();
        private FormMain formSebelumnya;
        private int bandaraAsalID;
        private int bandaraTujuanID;
        private DateTime tanggalBerangkat;
        private int jumlahPenumpang;


        public FormListPenerbangan(FormMain formSebelumnya, int bandaraAsalID, int bandaraTujuanID, DateTime tanggalBerangkat, int jumlahPenumpang)
        {
            InitializeComponent();

            this.formSebelumnya = formSebelumnya;
            this.bandaraAsalID = bandaraAsalID;
            this.bandaraTujuanID = bandaraTujuanID;
            this.tanggalBerangkat = tanggalBerangkat;
            this.jumlahPenumpang = jumlahPenumpang;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridViewListPenerbangan.Columns[e.ColumnIndex].Name == "BeliTiket") 
            {
                int jadwalID = Convert.ToInt32(dataGridViewListPenerbangan.Rows[e.RowIndex].Cells["ID"].Value);

                FormBeliTiket beliTiket = new FormBeliTiket(this, formSebelumnya, jadwalID, jumlahPenumpang);
                Hide();
                beliTiket.Show();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();

            this.Hide();
        }


        private void FormListPenerbangan_Load(object sender, EventArgs e)
        {
            showParameter();
            loadData();
        }

        private void showParameter()
        {
            var bandaraAsal = db.Bandaras.FirstOrDefault(b => b.ID == bandaraAsalID);
            var bandaraTujuan = db.Bandaras.FirstOrDefault(b => b.ID == bandaraTujuanID);

            if (bandaraAsal != null)
            {
                labelKeberangkatan.Text = bandaraAsal.Nama + $"({bandaraAsal.KodeIATA})";
            }

            if (bandaraTujuan != null)
            {
                labelTujuan.Text = bandaraTujuan.Nama + $"({bandaraTujuan.KodeIATA})";
            }

            labelTanggal.Text = tanggalBerangkat.ToString("dddd, dd MMMM yyyy");
            labelPenumpang.Text = jumlahPenumpang.ToString() + " Penumpang";
        }

        private void loadData()
        {
            var query = db.JadwalPenerbangans
                        .Include(j => j.Maskapai)
                        .Include(j => j.Bandara)
                        .Include(j => j.Bandara1)
                        .Where(j => j.BandaraKeberangkatanID == bandaraAsalID && j.BandaraTujuanID == bandaraTujuanID &&
                                DbFunctions.TruncateTime(j.TanggalWaktuKeberangkatan) == DbFunctions.TruncateTime(tanggalBerangkat));

            bool adaFilter = checkBoxWaktu1.Checked || checkBoxWaktu2.Checked || checkBoxWaktu3.Checked || checkBoxWaktu4.Checked;

            if (adaFilter)
            {
                query = query.Where(j => (checkBoxWaktu1.Checked && j.TanggalWaktuKeberangkatan.Hour >= 0 && j.TanggalWaktuKeberangkatan.Hour < 6) ||
                                         (checkBoxWaktu2.Checked && j.TanggalWaktuKeberangkatan.Hour >= 6 && j.TanggalWaktuKeberangkatan.Hour < 12) ||
                                         (checkBoxWaktu3.Checked && j.TanggalWaktuKeberangkatan.Hour >= 12 && j.TanggalWaktuKeberangkatan.Hour < 18) ||
                                         (checkBoxWaktu4.Checked && j.TanggalWaktuKeberangkatan.Hour >= 18 && j.TanggalWaktuKeberangkatan.Hour < 24));
            }

            switch (comboBoxSort.SelectedIndex)
            {
                case 0: query = query.OrderBy(j => j.HargaPerTiket);
                    break;
                case 1: query = query.OrderBy(j => j.TanggalWaktuKeberangkatan);
                    break;
                case 2: query = query.OrderByDescending(j => j.TanggalWaktuKeberangkatan);
                    break;
                case 3: query = query.OrderBy(j => DbFunctions.AddMinutes(j.TanggalWaktuKeberangkatan, j.DurasiPenerbangan));
                    break;
                case 4: query = query.OrderByDescending(j => DbFunctions.AddMinutes(j.TanggalWaktuKeberangkatan, j.DurasiPenerbangan));
                    break;
                case 5: query = query.OrderBy(j => j.DurasiPenerbangan);
                    break;
            }

            dataGridViewListPenerbangan.AutoGenerateColumns = false;
            dataGridViewListPenerbangan.AllowUserToAddRows = false;
            dataGridViewListPenerbangan.ReadOnly = true;

            dataGridViewListPenerbangan.DataSource = query.AsEnumerable().Select(j => new
            { 
            
                j.ID,
                j.KodePenerbangan,
                BandaraKeberangkatan = j.Bandara.Nama,
                BandaraTujuan = j.Bandara1.Nama,
                j.HargaPerTiket,
                Tanggal = j.TanggalWaktuKeberangkatan.ToString("dd-MM-yyyy"),
                Jam = j.TanggalWaktuKeberangkatan.ToString("HH:mm") + " - " + j.TanggalWaktuKeberangkatan.AddMinutes(j.DurasiPenerbangan).ToString("HH:mm")
            
            }).ToList();
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            loadData();
        }


    }
    }
