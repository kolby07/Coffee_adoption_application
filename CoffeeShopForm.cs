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
    public partial class CoffeeShopForm : Form
    {

        private const decimal CappaccinoPrice = 7.00m;
        private const decimal MochaPrice = 6.50m;
        private const decimal FrappaccinoPrice = 8.00m;
        private const decimal LattePrice = 5.50m;
        private const decimal ExpressoPrice = 5.00m;
        private const decimal CubanPrice = 7.50m;
        private const decimal TaxRate = 0.075m; 
        private decimal subtotal = 0.00m;

        public CoffeeShopForm()
        {
            InitializeComponent();
        }

        private void CoffeeShopForm_Load(object sender, EventArgs e)
        {

        }

        private void CalculateOrder()
        {
            // Reset subtotal
            subtotal = 0.00m;

            // Check each coffee checkbox and add its price to the subtotal
            if (cappaccinoCheckBox1.Checked)
                subtotal += CappaccinoPrice;
            if (mochaCheckbox.Checked)
                subtotal += MochaPrice;
            if (frappaccinoCheckBox.Checked)
                subtotal += FrappaccinoPrice;
            if (latteCheckBox.Checked)
                subtotal += LattePrice;
            if (expressoCheckBox1.Checked)
                subtotal += ExpressoPrice;
            if (cubanCheckBox.Checked)
                subtotal += CubanPrice;

            // Display the subtotal in a label
            subtotalLabel2.Text = $"Subtotal: ${subtotal:F2}";

            // Calculate tax and total
            decimal tax = subtotal * TaxRate;
            decimal total = subtotal + tax;

            // Display tax and total in labels
            taxLabel3.Text = $"Tax: ${tax:F2}";
            totalLabel1.Text = $"Total: ${total:F2}";
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creating a new instance of the HomeScreenForm class
            HomeScreenForm HomeScreenForm = new HomeScreenForm();

            // Showing the HomeScreenForm, making it visible to the user
            HomeScreenForm.Show();

            // Hiding the current form (assuming 'this' refers to the current form)
            this.Hide();

        }

        private void coffeeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // No need to create a new instance because it's the current form
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void subtotalLabel2_Click(object sender, EventArgs e)
        {

        }

        private void taxLabel3_Click(object sender, EventArgs e)
        {

        }

        private void totalLabel1_Click(object sender, EventArgs e)
        {

        }

        private void numberTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cappaccinoCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Call the CalculateOrder method when the state of a checkbox changes
            CalculateOrder();
        }

        private void mochaCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateOrder();
        }

        private void frappaccinoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateOrder();
        }

        private void latteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateOrder();
        }

        private void expressoCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CalculateOrder();
        }

        private void cubanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateOrder();
        }
    }
}
