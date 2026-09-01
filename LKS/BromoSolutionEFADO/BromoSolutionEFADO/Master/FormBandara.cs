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
    public partial class FormBandara : Form
    {
        public FormBandara()
        {
            InitializeComponent();
        }

        BandaraEntities db = new BandaraEntities();
        private int idBandara = -1;

        private void FormBandara_Load(object sender, EventArgs e)
        {
            Loadbandara();
            LoadNegara();

            dataGridViewBandara.AutoGenerateColumns = false;
            dataGridViewBandara.AllowUserToAddRows = false;
            dataGridViewBandara.ReadOnly = true;
        }

        private void Loadbandara()
        {
            dataGridViewBandara.DataSource = db.Bandaras.Include("Negara")
                                            .OrderBy(b => b.Nama)
                                            .Select(b => new
                                            {
                                                b.ID,
                                                b.Nama,
                                                b.KodeIATA,
                                                b.Kota,
                                                Negara = b.Negara.Nama,
                                                b.JumlahTerminal,
                                                b.Alamat
                                            }).ToList();

        }

        private void LoadNegara()
        {
            comboBoxNegara.DataSource = db.Negaras.OrderBy(n => n.Nama).ToList();

            comboBoxNegara.ValueMember = "ID";
            comboBoxNegara.DisplayMember = "Nama";
            comboBoxNegara.SelectedIndex = -1;
        }

        private void resetFom()
        {
            textBoxNama.Clear();
            textBoxIATA.Clear();
            textBoxKota.Clear();
            comboBoxNegara.SelectedIndex = -1;
            numericUpDownTerminal.Value = 1;
            richTextBoxAlamat.Clear();
            idBandara = -1;
            buttonSimpan.Text = "Simpan";   
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text.Trim() == "" || textBoxIATA.Text.Trim() == "" || textBoxKota.Text.Trim() == "" || comboBoxNegara.SelectedIndex == -1 || numericUpDownTerminal.Value <= 0 || richTextBoxAlamat.Text.Trim() == "")
            {
                MessageBox.Show("Isi semua lah wokkk, gimana kau ini");
                return;
            }

            bool adaIATA = db.Bandaras.Any(b => b.KodeIATA.ToLower() == textBoxIATA.Text.ToLower() && b.ID != idBandara);

            if (adaIATA)
            {
                MessageBox.Show("Nama IATA nya dah di pake wokk");
                return;
            }

            if (textBoxIATA.Text.Length != 3)
            {
                MessageBox.Show("Kode IATA biasanya 3 huruf sihhhh");
                return;
            }

            if (!textBoxIATA.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Kode IATA itu biasanya cuma huruf wok, ga ada itu simbol lain");
                return;
            }

            if (numericUpDownTerminal.Value < 1)
            {
                MessageBox.Show("Minimal 1 gak sih??");
            }

            bool adaBandara = db.Bandaras.Any(b => b.Nama.ToLower() == textBoxNama.Text.ToLower() && b.ID != idBandara);

            if (adaBandara)
            {
                MessageBox.Show("Nama bandaranya dah di pake, cari yang lain aja");
                return;
            }

            if (idBandara == -1)
            {
                Bandara bandara = new Bandara();

                bandara.Nama = textBoxNama.Text;
                bandara.KodeIATA = textBoxIATA.Text;
                bandara.Kota = textBoxKota.Text;
                bandara.NegaraID = Convert.ToInt32(comboBoxNegara.SelectedValue);
                bandara.JumlahTerminal = Convert.ToInt32(numericUpDownTerminal.Value);
                bandara.Alamat = richTextBoxAlamat.Text;

                db.Bandaras.Add(bandara);
                MessageBox.Show("oke, datanya udah masuk wok");
            }
            else
            {
                Bandara editBandara = db.Bandaras.Find(idBandara);

                editBandara.Nama = textBoxNama.Text;
                editBandara.KodeIATA = textBoxIATA.Text;
                editBandara.Kota = textBoxKota.Text;
                editBandara.NegaraID = Convert.ToInt32(comboBoxNegara.SelectedValue);
                editBandara.JumlahTerminal = Convert.ToInt32(numericUpDownTerminal.Value);
                editBandara.Alamat = richTextBoxAlamat.Text;

                MessageBox.Show("Oke, bandara lu udah di edit wok");
            }
            db.SaveChanges();

            Loadbandara();
            LoadNegara();
            resetFom();
        }

        private void dataGridViewBandara_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridViewBandara.Columns[e.ColumnIndex].Name == "edit")
            {
                idBandara = Convert.ToInt32(dataGridViewBandara.Rows[e.RowIndex].Cells["ID"].Value);

                Bandara bandaraEdit = db.Bandaras.Find(idBandara);

                textBoxNama.Text = bandaraEdit.Nama;
                textBoxIATA.Text = bandaraEdit.KodeIATA;
                textBoxKota.Text = bandaraEdit.Kota;
                richTextBoxAlamat.Text = bandaraEdit.Alamat;
                comboBoxNegara.SelectedValue = bandaraEdit.Negara;
                numericUpDownTerminal.Value = bandaraEdit.JumlahTerminal;

                buttonSimpan.Text = "Update";

            } else if (dataGridViewBandara.Columns[e.ColumnIndex].Name == "hapus")
            {
                int id = Convert.ToInt32(dataGridViewBandara.Rows[e.RowIndex].Cells["ID"].Value);

                var hasil = MessageBox.Show("Yakin lo hapus??", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Bandara bandaraHapus = db.Bandaras.Find(id);
                    db.Bandaras.Remove(bandaraHapus);
                    db.SaveChanges();

                    Loadbandara();
                    resetFom();
                }
            }
        }
    }
}
