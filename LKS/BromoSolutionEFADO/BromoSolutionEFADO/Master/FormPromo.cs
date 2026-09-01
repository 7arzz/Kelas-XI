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
    public partial class FormPromo : Form
    {
        public FormPromo()
        {
            InitializeComponent();
        }

        BandaraEntities db = new BandaraEntities();
        private int idPromo = -1;

        private void FormPromo_Load(object sender, EventArgs e)
        {
            dataGridViewPromo.AutoGenerateColumns = false;
            dataGridViewPromo.AllowUserToAddRows = false;
            dataGridViewPromo.ReadOnly = true;

            loadData();
        }

        private void loadData()
        {
            dataGridViewPromo.DataSource = db.KodePromoes.ToList();
        }

        private void clearForm()
        {
            textBoxKode.Clear();
            dateTimePickerBerlaku.Value = DateTime.Today;
            numericUpDownPersentaseDiskon.Value = 0;
            numericUpDownMaxDiskon.Value = 0;
            richTextBoxDeskripsi.Clear();
            idPromo = -1;

            buttonSimpan.Text = "Simpan";
        }

        private void textBoxKode_TextChanged(object sender, EventArgs e)
        {
            textBoxKode.Text = textBoxKode.Text.ToUpper();
            textBoxKode.SelectionStart = textBoxKode.Text.Length;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxKode.Text.Trim() == "" || richTextBoxDeskripsi.Text.Trim() == "")
            {
                MessageBox.Show("Semua data harus di isi ya wok");
                return;
            }

            bool adaKode = db.KodePromoes.Any(p => p.Kode == textBoxKode.Text && p.ID != idPromo);
            if (adaKode)
            {
                MessageBox.Show("Kodenya udah ada wokk, ganti yang lain ajaa");
                return;
            }

            if (dateTimePickerBerlaku.Value <= DateTime.Today)
            {
                MessageBox.Show("Yang bener klo kasih tanggal yaaa");
                return;
            }

            if (numericUpDownPersentaseDiskon.Value <= 0 || numericUpDownMaxDiskon.Value <= 0)
            {
                MessageBox.Show("klo ga niat kasih diskon mending gausah ngasih sihh");
                return;
            }

            if (idPromo == -1)
            {
                KodePromo tambahPromo = new KodePromo();

                tambahPromo.Kode = textBoxKode.Text;
                tambahPromo.BerlakuSampai = dateTimePickerBerlaku.Value;
                tambahPromo.PersentaseDiskon = Convert.ToInt32(numericUpDownPersentaseDiskon.Value);
                tambahPromo.MaksimumDiskon = Convert.ToInt32(numericUpDownMaxDiskon.Value);
                tambahPromo.Deskripsi = richTextBoxDeskripsi.Text;

                db.KodePromoes.Add(tambahPromo);
                db.SaveChanges();

                MessageBox.Show("promo dengan Kode " + tambahPromo.Kode + " sudah di masukkan");

                loadData();
                clearForm();
                
            }
            else
            {
                KodePromo editPromo = db.KodePromoes.Find(idPromo); 
                
                editPromo.Kode = textBoxKode.Text;
                editPromo.BerlakuSampai = dateTimePickerBerlaku.Value;
                editPromo.PersentaseDiskon = Convert.ToInt32(numericUpDownPersentaseDiskon.Value);
                editPromo.MaksimumDiskon = Convert.ToInt32(numericUpDownMaxDiskon.Value);
                editPromo.Deskripsi = richTextBoxDeskripsi.Text;

                db.SaveChanges();

                MessageBox.Show("Promo sudah di edit wokk");
            }
        }

        private void dataGridViewPromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridViewPromo.Columns[e.ColumnIndex].Name == "Edit")
            {
                idPromo = Convert.ToInt32(dataGridViewPromo.Rows[e.RowIndex].Cells["ID"].Value);
                KodePromo editPromo = db.KodePromoes.Find(idPromo);

                textBoxKode.Text = editPromo.Kode ;
                dateTimePickerBerlaku.Value = editPromo.BerlakuSampai ;
                numericUpDownPersentaseDiskon.Value = Convert.ToInt32(editPromo.PersentaseDiskon);
                numericUpDownMaxDiskon.Value = Convert.ToInt32(editPromo.MaksimumDiskon);
                richTextBoxDeskripsi.Text = editPromo.Deskripsi;

                buttonSimpan.Text = "Edit";

            }
            else if (dataGridViewPromo.Columns[e.ColumnIndex].Name == "Hapus")
            {
                int idHapus = Convert.ToInt32(dataGridViewPromo.Rows[e.RowIndex].Cells["ID"].Value);
                var hasil = MessageBox.Show("Yakin mau hapus wok???", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    KodePromo hapusPromo = db.KodePromoes.Find(idHapus);
                    db.KodePromoes.Remove(hapusPromo);

                    db.SaveChanges();
                    MessageBox.Show("Datanya udah di hapus wok :) ");

                    loadData();
                    clearForm();
                }
            }

        }
    }
}
