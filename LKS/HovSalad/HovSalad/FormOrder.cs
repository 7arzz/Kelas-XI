using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HovSalad
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void buttonIngredients_Click(object sender, EventArgs e)
        {
            AddIngredients addIngredients = new AddIngredients();
            addIngredients.Show();
        }
    }
}
