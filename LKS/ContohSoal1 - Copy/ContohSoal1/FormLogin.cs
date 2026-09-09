using ContohSoal1.Customer;

namespace ContohSoal1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();

            if (textBoxUsn.Text.Trim() == "" || textBoxPassword.Text.Trim() == "")
            {
                MessageBox.Show("Username dan Password Wajib di isi");
                return;
            }

            if (textBoxUsn.Text == "Admin" && textBoxPassword.Text == "admin123")
            {
                this.Hide();
                dashboard.Show();

                MessageBox.Show("Login Berhasil");
            }
            else
            {
                string username = textBoxUsn.Text.Trim();

                FormMain mainCustomer = new FormMain();

                this.Hide();
                mainCustomer.Show();

                MessageBox.Show("Login berhasil");
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