using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_adoption_application
{
    public partial class HomeScreenForm : Form
    {
        public HomeScreenForm()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void petAdoptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creating a new instance of the AdoptionForm class
            AdoptionForm AdoptionForm = new AdoptionForm();

            // Showing the AdoptionForm, making it visible to the user
            AdoptionForm.Show();

            // Hiding the current form (assuming 'this' refers to the current form)
            this.Hide();
        }

        private void coffeeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creating a new instance of the CoffeeShopForm class
            CoffeeShopForm CoffeeShopForm = new CoffeeShopForm();

            // Showing the CoffeeShopForm, making it visible to the user
            CoffeeShopForm.Show();

            // Hiding the current form (assuming 'this' refers to the current form)
            this.Hide();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // No need to create a new instance because it's the current form
            this.Show();
        }

    }
}
