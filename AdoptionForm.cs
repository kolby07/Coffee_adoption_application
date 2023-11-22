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
    public partial class AdoptionForm : Form
    {
        public AdoptionForm()
        {
            InitializeComponent();
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creating a new instance of the HomeScreenForm class
            HomeScreenForm HomeScreenForm = new HomeScreenForm();

            // Showing the HomeScreenForm, making it visible to the user
            HomeScreenForm.Show();

            // Hiding the current form (assuming 'this' refers to the current form)
            this.Hide();
        }

        private void petAdoptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // No need to create a new instance because it's the current form
            this.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            // Retrieve user input from TextBoxes
            int age = Convert.ToInt32(q2textBox3.Text);
            string incomeStatus = q3textBox2.Text.ToLower();
            double dailyHours = Convert.ToDouble(q4textBox4.Text);
            string previousDogOwner = q5textBox5.Text.ToLower();
            string hasYard = q6textBox6.Text.ToLower();

            // Check eligibility based on the criteria
            if (age >= 18 && incomeStatus == "yes" && dailyHours >= 2.0 && previousDogOwner == "yes" && hasYard == "yes")
            {
                eligibilityResultLabel.Text = "Congratulations! You are eligible to adopt a dog. See the calendar for an available time to meet our pups!";
            }
            else
            {
                eligibilityResultLabel.Text = "Sorry, you are not eligible to adopt a dog based on the provided information.";
            }

            this.eligibilityTableAdapter.Insert(q1textBox1.Text, int.Parse(q2textBox3.Text), q3textBox2.Text, Convert.ToDouble(q4textBox4.Text), q5textBox5.Text, q6textBox6.Text, eligibilityResultLabel.Text);
            this.eligibilityTableAdapter.Fill(this.database1DataSet.Eligibility);

        }

        private void q1textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void eligibilityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eligibilityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void AdoptionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Eligibility' table. You can move, or remove it, as needed.
            this.eligibilityTableAdapter.Fill(this.database1DataSet.Eligibility);

        }

        private void eligibilityDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
