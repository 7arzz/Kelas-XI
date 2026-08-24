using System.Drawing;
using System.Windows.Forms;
using System;
using BromoSolutionEFADO.Model;
using BromoSolutionEFADO.Customers;
using System.Linq;

namespace BromoSolutionEFADO
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        BandaraEntities db = new BandaraEntities();
            
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            FormMain customer = new FormMain();

            if (textBoxUsn.Text.Trim() == "" || textBoxPassword.Text.Trim() == "")
            {
                MessageBox.Show("Username dan Password Wajib di isi");
                return;
            }

            var user = db.Akuns.FirstOrDefault(a => a.Username == textBoxUsn.Text && a.Password == textBoxPassword.Text);

            if (user != null)
            {
                this.Hide();
                //dashboard.Show();

                MessageBox.Show("Login Berhasil");

                if (user.MerupakanAdmin)
                {
                    dashboard.Show();
                }
                else
                {
                    customer.Show();
                }
            }
            else
            {
                MessageBox.Show("Username atau Password anda salah");
            }
        }

        private void linkLabelDatar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister register = new FormRegister();

            this.Hide();
            register.Show();
        }
    }
}