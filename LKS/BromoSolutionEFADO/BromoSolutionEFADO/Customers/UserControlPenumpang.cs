using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContohSoal1.Customer
{
    public partial class UserControlPenumpang : UserControl
    {
        public UserControlPenumpang()
        {
            InitializeComponent();
        }

        public int NomorPenumpang
        {
            set
            {
                labelNomor.Text = "Penumpang #" + value;
            }
        }

        public string Title 
        {
            get
            {
                return comboBoxTitle.Text;
            }
        }

        public string NamaLengkap
        {
            get
            {
                return textBoxNamaLengkap.Text.Trim();
            }
        }

        public bool dataLengkap
        {
            get
            {
                return comboBoxTitle.SelectedIndex != -1
                    && !string.IsNullOrWhiteSpace(textBoxNamaLengkap.Text);

            }
        }


        private void UserControlPenumpang_Load(object sender, EventArgs e)
        {

        }
    }
}
