using ContohSoal1.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            MessageBox.Show("oke makasih, cek cek aja penerbangan lain wok wkwkwk");
            FormMain main = new FormMain();
            main.Show();

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //FormListPenerbangan listPenerbangan = new FormListPenerbangan();
            //listPenerbangan.Show();

            this.Close();
        }

        private void FormBeliTiket_Load(object sender, EventArgs e)
        {

        }
    }
}
