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
    public partial class FormMaskapai : Form
    {
        public FormMaskapai()
        {
            InitializeComponent();
        }

        BandaraEntities db = new BandaraEntities();
        private int idMaskapai = -1;

        private void FormMaskapai_Load(object sender, EventArgs e)
        {

            dataGridViewMaskapai.AutoGenerateColumns = false;
            dataGridViewMaskapai.AllowUserToAddRows = false;
            dataGridViewMaskapai.ReadOnly = true;
            
            loadMaskapai();

        }

        private void clearForm()
        {
            textBoxNama.Clear();
            textBoxPerusahaan.Clear();
            numericUpDownJumlahKru.Value = 0;
            richTextBoxDeskripsi.Clear();
            idMaskapai = -1;
            buttonSimpan.Text = "Simpan";
        }

        private void loadMaskapai()
        {
            dataGridViewMaskapai.DataSource = db.Maskapais.OrderBy(m => m.Nama).ToList();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text.Trim() == "" || textBoxPerusahaan.Text.Trim() == "" || numericUpDownJumlahKru.Value <= 0 || richTextBoxDeskripsi.Text.Trim() == "")
            {
                MessageBox.Show("Data nya ada yang kosong wok, san jumlah kru minimal 1. Emangnya bisa kerja ga ada kru??? wkwkwkwkkw");
                return;
            }

            if (idMaskapai == -1)
            {
                Maskapai maskapaiBaru = new Maskapai();

                maskapaiBaru.Nama = textBoxNama.Text;
                maskapaiBaru.Perusahaan = textBoxPerusahaan.Text;
                maskapaiBaru.JumlahKru = Convert.ToInt32(numericUpDownJumlahKru.Value);
                maskapaiBaru.Deskripsi = richTextBoxDeskripsi.Text;

                db.Maskapais.Add(maskapaiBaru);
                MessageBox.Show("oke, data baru udah masuk wok");
            }
            else
            {
                Maskapai editMaskapai = db.Maskapais.Find(idMaskapai);

                editMaskapai.Nama = textBoxNama.Text;
                editMaskapai.Perusahaan = textBoxPerusahaan.Text;
                editMaskapai.JumlahKru = Convert.ToInt32(numericUpDownJumlahKru.Value);
                editMaskapai.Deskripsi = richTextBoxDeskripsi.Text;

            }

            db.SaveChanges();
            loadMaskapai();
            clearForm();
        }

        private void dataGridViewMaskapai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 )
            {
                return;
            }

            if (dataGridViewMaskapai.Columns[e.ColumnIndex].Name == "Edit")
            {
                idMaskapai = Convert.ToInt32( dataGridViewMaskapai.Rows[e.RowIndex].Cells["ID"].Value);
                Maskapai editMaskapai = db.Maskapais.Find(idMaskapai);


                textBoxNama.Text = editMaskapai.Nama;
                textBoxPerusahaan.Text = editMaskapai.Perusahaan;
                numericUpDownJumlahKru.Value = editMaskapai.JumlahKru;
                richTextBoxDeskripsi.Text = editMaskapai.Deskripsi;

                buttonSimpan.Text = "Update";
            }
            else if (dataGridViewMaskapai.Columns[e.ColumnIndex].Name == "Hapus")
            {
                int id = Convert.ToInt32( dataGridViewMaskapai.Rows[e.RowIndex].Cells["ID"].Value);

                var hasil = MessageBox.Show("Yakin di hapus wok?? ga bisa di undo lhoo", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Maskapai hapusMaskapai = db.Maskapais.Find(id);
                    db.Maskapais.Remove(hapusMaskapai); 
                    db.SaveChanges();

                    MessageBox.Show("OKe, maskapai" + hapusMaskapai.Nama + " udah di hapus wok");
                    loadMaskapai();
                    clearForm();  
                }


            }
            
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
