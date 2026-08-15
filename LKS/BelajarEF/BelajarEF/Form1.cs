using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelajarEF
{
    public partial class Form1 : Form
    {
        SekolahDBEntities db = new SekolahDBEntities();
        public Form1()
        {
            InitializeComponent();
        }
        int idSiswa;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            loadData();
            

            comboBoxJurusan.DataSource = db.Jurusans.ToList();
            comboBoxJurusan.DisplayMember = "namaJurusan";
            comboBoxJurusan.ValueMember = "Id";
            comboBoxJurusan.SelectedIndex = -1;
            
        }

        private void loadData()
        {
            dataGridView1.DataSource = db.Siswas.Select(s => new
            {
                s.Id,
                s.Nama,
                s.Umur,
                s.Alamat,
                Jurusan = s.Jurusan.namaJurusan
            })
                .ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (textBoxNama.Text.Trim() == "" || numericUpDownUmur.Value <= 0 || richTextBoxAlamat.Text.Trim() == "" || comboBoxJurusan.SelectedIndex == -1 )
            {
                MessageBox.Show("semua data harus di isi");
                return;
            }
            
                var siswa = new Siswa();

                siswa.Nama = textBoxNama.Text;
                siswa.Umur = Convert.ToInt32(numericUpDownUmur.Value);
                siswa.Alamat = richTextBoxAlamat.Text;
                siswa.IDJurusan = Convert.ToInt32(comboBoxJurusan.SelectedValue);

                db.Siswas.Add( siswa );
                db.SaveChanges();

                MessageBox.Show("data berhasil ditambahkan");
                loadData();
            }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (columnName == "update")
            {
                idSiswa = Convert.ToInt32(row.Cells["Id"].Value);

                textBoxNama.Text = row.Cells["Nama"].Value.ToString() ;
                numericUpDownUmur.Value = Convert.ToInt32(row.Cells["Umur"].Value);
                richTextBoxAlamat.Text = row.Cells["Alamat"].Value.ToString();
                comboBoxJurusan.SelectedValue = row.Cells["jurusan"].Value.ToString();

                buttonAdd.Text = "Update";
            }
            else if (columnName == "delete")
            {
                var result = MessageBox.Show("Hapus data ini??", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int idDelete = Convert.ToInt32(row.Cells["Id"].Value);
                    var siswa = db.Siswas.Find(idDelete);

                    if (siswa != null)
                    {
                        db.Siswas.Remove(siswa);
                        db.SaveChanges();

                        MessageBox.Show("Data sudah si hapus permanen");
                    }
                }

                loadData();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string key = textBoxSearch.Text;
            if (key.Trim() == "" )
            {
                loadData();
                return;
            }

            dataGridView1.DataSource = db.Siswas.Where(s => 
                s.Nama.Contains(key) ||
                s.Umur.ToString().Contains(key) ||
                s.Alamat.Contains(key) ||
                s.Jurusan.namaJurusan.Contains("key")

            ).Select(s => new
            {
                s.Id,
                s.Nama,
                s.Umur,
                s.Alamat,
                Jurusan = s.Jurusan.namaJurusan
            }).ToList();
        }
    }
}
