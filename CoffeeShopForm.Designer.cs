namespace Coffee_adoption_application
{
    partial class CoffeeShopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeeShopForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coffeeMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petAdoptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mochaCheckbox = new System.Windows.Forms.CheckBox();
            this.frappaccinoCheckBox = new System.Windows.Forms.CheckBox();
            this.latteCheckBox = new System.Windows.Forms.CheckBox();
            this.cubanCheckBox = new System.Windows.Forms.CheckBox();
            this.numberTextBox2 = new System.Windows.Forms.TextBox();
            this.subtotalLabel2 = new System.Windows.Forms.Label();
            this.taxLabel3 = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.totalLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.cappaccinoCheckBox1 = new System.Windows.Forms.CheckBox();
            this.expressoCheckBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.coffeeMenuToolStripMenuItem,
            this.petAdoptionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(600, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // coffeeMenuToolStripMenuItem
            // 
            this.coffeeMenuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.coffeeMenuToolStripMenuItem.Name = "coffeeMenuToolStripMenuItem";
            this.coffeeMenuToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.coffeeMenuToolStripMenuItem.Text = "Coffee Menu";
            this.coffeeMenuToolStripMenuItem.Click += new System.EventHandler(this.coffeeMenuToolStripMenuItem_Click);
            // 
            // petAdoptionToolStripMenuItem
            // 
            this.petAdoptionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.petAdoptionToolStripMenuItem.Name = "petAdoptionToolStripMenuItem";
            this.petAdoptionToolStripMenuItem.Size = new System.Drawing.Size(110, 26);
            this.petAdoptionToolStripMenuItem.Text = "Pet Adoption";
            this.petAdoptionToolStripMenuItem.Click += new System.EventHandler(this.petAdoptionToolStripMenuItem_Click);
            // 
            // mochaCheckbox
            // 
            this.mochaCheckbox.AutoSize = true;
            this.mochaCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.mochaCheckbox.ForeColor = System.Drawing.Color.White;
            this.mochaCheckbox.Location = new System.Drawing.Point(61, 132);
            this.mochaCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.mochaCheckbox.Name = "mochaCheckbox";
            this.mochaCheckbox.Size = new System.Drawing.Size(107, 20);
            this.mochaCheckbox.TabIndex = 3;
            this.mochaCheckbox.Text = "Mocha  $6.50";
            this.mochaCheckbox.UseVisualStyleBackColor = false;
            this.mochaCheckbox.CheckedChanged += new System.EventHandler(this.mochaCheckbox_CheckedChanged);
            // 
            // frappaccinoCheckBox
            // 
            this.frappaccinoCheckBox.AutoSize = true;
            this.frappaccinoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.frappaccinoCheckBox.ForeColor = System.Drawing.Color.White;
            this.frappaccinoCheckBox.Location = new System.Drawing.Point(61, 160);
            this.frappaccinoCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.frappaccinoCheckBox.Name = "frappaccinoCheckBox";
            this.frappaccinoCheckBox.Size = new System.Drawing.Size(142, 20);
            this.frappaccinoCheckBox.TabIndex = 4;
            this.frappaccinoCheckBox.Text = "Frappaccino  $8.00";
            this.frappaccinoCheckBox.UseVisualStyleBackColor = false;
            this.frappaccinoCheckBox.CheckedChanged += new System.EventHandler(this.frappaccinoCheckBox_CheckedChanged);
            // 
            // latteCheckBox
            // 
            this.latteCheckBox.AutoSize = true;
            this.latteCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.latteCheckBox.ForeColor = System.Drawing.Color.White;
            this.latteCheckBox.Location = new System.Drawing.Point(61, 188);
            this.latteCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.latteCheckBox.Name = "latteCheckBox";
            this.latteCheckBox.Size = new System.Drawing.Size(95, 20);
            this.latteCheckBox.TabIndex = 5;
            this.latteCheckBox.Text = "Latte  $5.50";
            this.latteCheckBox.UseVisualStyleBackColor = false;
            this.latteCheckBox.CheckedChanged += new System.EventHandler(this.latteCheckBox_CheckedChanged);
            // 
            // cubanCheckBox
            // 
            this.cubanCheckBox.AutoSize = true;
            this.cubanCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.cubanCheckBox.ForeColor = System.Drawing.Color.White;
            this.cubanCheckBox.Location = new System.Drawing.Point(61, 245);
            this.cubanCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.cubanCheckBox.Name = "cubanCheckBox";
            this.cubanCheckBox.Size = new System.Drawing.Size(105, 20);
            this.cubanCheckBox.TabIndex = 7;
            this.cubanCheckBox.Text = "Cuban  $7.50";
            this.cubanCheckBox.UseVisualStyleBackColor = false;
            this.cubanCheckBox.CheckedChanged += new System.EventHandler(this.cubanCheckBox_CheckedChanged);
            // 
            // numberTextBox2
            // 
            this.numberTextBox2.Location = new System.Drawing.Point(337, 158);
            this.numberTextBox2.Name = "numberTextBox2";
            this.numberTextBox2.Size = new System.Drawing.Size(204, 22);
            this.numberTextBox2.TabIndex = 9;
            this.numberTextBox2.TextChanged += new System.EventHandler(this.numberTextBox2_TextChanged);
            // 
            // subtotalLabel2
            // 
            this.subtotalLabel2.AutoSize = true;
            this.subtotalLabel2.Location = new System.Drawing.Point(334, 217);
            this.subtotalLabel2.Name = "subtotalLabel2";
            this.subtotalLabel2.Size = new System.Drawing.Size(56, 16);
            this.subtotalLabel2.TabIndex = 11;
            this.subtotalLabel2.Text = "Subtotal";
            this.subtotalLabel2.Click += new System.EventHandler(this.subtotalLabel2_Click);
            // 
            // taxLabel3
            // 
            this.taxLabel3.AutoSize = true;
            this.taxLabel3.Location = new System.Drawing.Point(334, 245);
            this.taxLabel3.Name = "taxLabel3";
            this.taxLabel3.Size = new System.Drawing.Size(30, 16);
            this.taxLabel3.TabIndex = 12;
            this.taxLabel3.Text = "Tax";
            this.taxLabel3.Click += new System.EventHandler(this.taxLabel3_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(327, 311);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 14;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // totalLabel1
            // 
            this.totalLabel1.AutoSize = true;
            this.totalLabel1.Location = new System.Drawing.Point(334, 273);
            this.totalLabel1.Name = "totalLabel1";
            this.totalLabel1.Size = new System.Drawing.Size(38, 16);
            this.totalLabel1.TabIndex = 15;
            this.totalLabel1.Text = "Total";
            this.totalLabel1.Click += new System.EventHandler(this.totalLabel1_Click);
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(337, 103);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(204, 22);
            this.nameTextBox1.TabIndex = 16;
            this.nameTextBox1.TextChanged += new System.EventHandler(this.nameTextBox1_TextChanged);
            // 
            // cappaccinoCheckBox1
            // 
            this.cappaccinoCheckBox1.AutoSize = true;
            this.cappaccinoCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.cappaccinoCheckBox1.ForeColor = System.Drawing.Color.White;
            this.cappaccinoCheckBox1.Location = new System.Drawing.Point(61, 103);
            this.cappaccinoCheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cappaccinoCheckBox1.Name = "cappaccinoCheckBox1";
            this.cappaccinoCheckBox1.Size = new System.Drawing.Size(142, 20);
            this.cappaccinoCheckBox1.TabIndex = 17;
            this.cappaccinoCheckBox1.Text = "Cappaccino   $7.00";
            this.cappaccinoCheckBox1.UseVisualStyleBackColor = false;
            this.cappaccinoCheckBox1.CheckedChanged += new System.EventHandler(this.cappaccinoCheckBox1_CheckedChanged);
            // 
            // expressoCheckBox1
            // 
            this.expressoCheckBox1.AutoSize = true;
            this.expressoCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.expressoCheckBox1.ForeColor = System.Drawing.Color.White;
            this.expressoCheckBox1.Location = new System.Drawing.Point(61, 217);
            this.expressoCheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.expressoCheckBox1.Name = "expressoCheckBox1";
            this.expressoCheckBox1.Size = new System.Drawing.Size(123, 20);
            this.expressoCheckBox1.TabIndex = 18;
            this.expressoCheckBox1.Text = "Expresso  $5.00";
            this.expressoCheckBox1.UseVisualStyleBackColor = false;
            this.expressoCheckBox1.CheckedChanged += new System.EventHandler(this.expressoCheckBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(334, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Order Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(334, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cell Number";
            // 
            // CoffeeShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 416);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expressoCheckBox1);
            this.Controls.Add(this.cappaccinoCheckBox1);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(this.totalLabel1);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.taxLabel3);
            this.Controls.Add(this.subtotalLabel2);
            this.Controls.Add(this.numberTextBox2);
            this.Controls.Add(this.cubanCheckBox);
            this.Controls.Add(this.latteCheckBox);
            this.Controls.Add(this.frappaccinoCheckBox);
            this.Controls.Add(this.mochaCheckbox);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CoffeeShopForm";
            this.Text = "CoffeeShopForm";
            this.Load += new System.EventHandler(this.CoffeeShopForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coffeeMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petAdoptionToolStripMenuItem;
        private System.Windows.Forms.CheckBox mochaCheckbox;
        private System.Windows.Forms.CheckBox frappaccinoCheckBox;
        private System.Windows.Forms.CheckBox latteCheckBox;
        private System.Windows.Forms.CheckBox cubanCheckBox;
        private System.Windows.Forms.TextBox numberTextBox2;
        private System.Windows.Forms.Label subtotalLabel2;
        private System.Windows.Forms.Label taxLabel3;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label totalLabel1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.CheckBox cappaccinoCheckBox1;
        private System.Windows.Forms.CheckBox expressoCheckBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}