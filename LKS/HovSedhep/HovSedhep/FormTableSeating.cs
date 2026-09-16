using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HovSedhep
{
    public partial class FormTableSeating : Form
    {
        
        public FormTableSeating()
        {
            InitializeComponent();
        }

        FormAssignTable notBooking = new FormAssignTable();
        FormDetailTable booking = new FormDetailTable();

        bool bookingTable = false;

        private void A1_Click(object sender, EventArgs e)
        {
            bookingTable = true;
            if (bookingTable == true)
            {
                booking.Show();
            }
            else
            {
                notBooking.Show();
            }

        }

        private void C1_Click(object sender, EventArgs e)
        {
            bookingTable = false;
            if (bookingTable == true)
            {
                booking.Show();
            }
            else
            {
                notBooking.Show();
            }
        }

        private void A2_Click(object sender, EventArgs e)
        {

        }

        private void B2_Click(object sender, EventArgs e)
        {

        }

        private void B1_Click(object sender, EventArgs e)
        {

        }

        private void A3_Click(object sender, EventArgs e)
        {

        }

        private void C2_Click(object sender, EventArgs e)
        {

        }

        private void A4_Click(object sender, EventArgs e)
        {

        }
    }
}
