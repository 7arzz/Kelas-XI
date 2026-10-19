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
            checkTable();
        }

        FormAssignTable notBooking = new FormAssignTable();
        FormDetailTable booking = new FormDetailTable();

        // SEMENTARA
        bool A1Booking = false;
        bool A2Booking = true;
        bool A3Booking = true;
        bool A4Booking = false;
        bool B1Booking = false;
        bool B2Booking = false;
        bool C1Booking = false;
        bool C2Booking = false;



        private void A1_Click(object sender, EventArgs e)
        {
            if (A1Booking)
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
            if (C1Booking)
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
            if (A2Booking)
            {
                booking.Show();
            }
            else
            {
                notBooking.Show();
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (B2Booking)
            {
                booking.Show();
            }
            else
            {
                notBooking.Show();
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (B1Booking)
            {
                booking.Show();
            }
            else
            {
                notBooking.Show();
            }
        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (A3Booking)
            {
                booking.Show();
            }
            else
            {
                notBooking.Show();
            }
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (C2Booking)
            {
                booking.Show();
            }
            else
            {
                notBooking.Show();
            }
        }

        private void A4_Click(object sender, EventArgs e)
        {
            if (A4Booking)
            {
                booking.Show();
            }
            else
            {
                notBooking.Show();
            }
        }


        private void checkTable()
        {

            // A1
            if (A1Booking)
            {
                A1.BackColor = Color.Red;
            }
            else
            {
                A1.BackColor = Color.Green;
            }


            // A2
            if (A2Booking)
            {
                A2.BackColor = Color.Red;
            }
            else
            {
                A2.BackColor = Color.Green;
            }


            // A3
            if (A3Booking)
            {
                A3.BackColor = Color.Red;
            }
            else
            {
                A3.BackColor = Color.Green;
            }


            // A4
            if (A4Booking)
            {
                A4.BackColor = Color.Red;
            }
            else
            {
                A4.BackColor = Color.Green;
            }


            // B1
            if (B1Booking)
            {
                B1.BackColor = Color.Red;
            }
            else
            {
                B1.BackColor = Color.Green;
            }


            // B2
            if (B2Booking)
            {
                B2.BackColor = Color.Red;
            }
            else
            {
                B2.BackColor = Color.Green;
            }


            // C1
            if (C1Booking)
            {
                C1.BackColor = Color.Red;
            }
            else
            {
                C1.BackColor = Color.Green;
            }


            // C2
            if (C2Booking)
            {
                C2.BackColor = Color.Red;
            }
            else
            {
                C2.BackColor = Color.Green;
            }

        }
    }
}
