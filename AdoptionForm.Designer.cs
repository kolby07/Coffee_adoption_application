namespace Coffee_adoption_application
{
    partial class AdoptionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdoptionForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coffeeMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petAdoptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.q4textBox4 = new System.Windows.Forms.TextBox();
            this.q5textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.q1textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.q3textBox2 = new System.Windows.Forms.TextBox();
            this.q2textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.q6textBox6 = new System.Windows.Forms.TextBox();
            this.eligibilityResultLabel = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.eligibilityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.eligibilityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eligibilityDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eligibilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Coffee_adoption_application.Database1DataSet();
            this.eligibilityTableAdapter = new Coffee_adoption_application.Database1DataSetTableAdapters.EligibilityTableAdapter();
            this.tableAdapterManager = new Coffee_adoption_application.Database1DataSetTableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eligibilityBindingNavigator)).BeginInit();
            this.eligibilityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eligibilityDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eligibilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
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
            this.menuStrip1.Location = new System.Drawing.Point(747, 39);
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
            // q4textBox4
            // 
            this.q4textBox4.Location = new System.Drawing.Point(23, 248);
            this.q4textBox4.Name = "q4textBox4";
            this.q4textBox4.Size = new System.Drawing.Size(55, 22);
            this.q4textBox4.TabIndex = 5;
            // 
            // q5textBox5
            // 
            this.q5textBox5.Location = new System.Drawing.Point(23, 302);
            this.q5textBox5.Name = "q5textBox5";
            this.q5textBox5.Size = new System.Drawing.Size(55, 22);
            this.q5textBox5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Do you have a stable source of income? (yes/no)";
            // 
            // q1textBox1
            // 
            this.q1textBox1.Location = new System.Drawing.Point(23, 86);
            this.q1textBox1.Name = "q1textBox1";
            this.q1textBox1.Size = new System.Drawing.Size(162, 22);
            this.q1textBox1.TabIndex = 10;
            this.q1textBox1.TextChanged += new System.EventHandler(this.q1textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(396, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "How many hours per day can you spend with a dog? (on average)";
            // 
            // q3textBox2
            // 
            this.q3textBox2.Location = new System.Drawing.Point(23, 195);
            this.q3textBox2.Name = "q3textBox2";
            this.q3textBox2.Size = new System.Drawing.Size(55, 22);
            this.q3textBox2.TabIndex = 12;
            // 
            // q2textBox3
            // 
            this.q2textBox3.Location = new System.Drawing.Point(23, 141);
            this.q2textBox3.Name = "q2textBox3";
            this.q2textBox3.Size = new System.Drawing.Size(55, 22);
            this.q2textBox3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Have you owned a dog before? (yes/no)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(433, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Do you have a secure and spacious yard for the dog to play in? (yes/no)";
            // 
            // q6textBox6
            // 
            this.q6textBox6.Location = new System.Drawing.Point(23, 356);
            this.q6textBox6.Name = "q6textBox6";
            this.q6textBox6.Size = new System.Drawing.Size(55, 22);
            this.q6textBox6.TabIndex = 16;
            // 
            // eligibilityResultLabel
            // 
            this.eligibilityResultLabel.AutoSize = true;
            this.eligibilityResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.eligibilityResultLabel.ForeColor = System.Drawing.Color.White;
            this.eligibilityResultLabel.Location = new System.Drawing.Point(20, 465);
            this.eligibilityResultLabel.Name = "eligibilityResultLabel";
            this.eligibilityResultLabel.Size = new System.Drawing.Size(10, 16);
            this.eligibilityResultLabel.TabIndex = 17;
            this.eligibilityResultLabel.Text = " ";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(192, 408);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 18;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Eligibility: ";
            // 
            // eligibilityBindingNavigator
            // 
            this.eligibilityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eligibilityBindingNavigator.BindingSource = this.eligibilityBindingSource;
            this.eligibilityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eligibilityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eligibilityBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.eligibilityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eligibilityBindingNavigatorSaveItem});
            this.eligibilityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eligibilityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eligibilityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eligibilityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eligibilityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eligibilityBindingNavigator.Name = "eligibilityBindingNavigator";
            this.eligibilityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eligibilityBindingNavigator.Size = new System.Drawing.Size(1067, 27);
            this.eligibilityBindingNavigator.TabIndex = 20;
            this.eligibilityBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // eligibilityBindingNavigatorSaveItem
            // 
            this.eligibilityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eligibilityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eligibilityBindingNavigatorSaveItem.Image")));
            this.eligibilityBindingNavigatorSaveItem.Name = "eligibilityBindingNavigatorSaveItem";
            this.eligibilityBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.eligibilityBindingNavigatorSaveItem.Text = "Save Data";
            this.eligibilityBindingNavigatorSaveItem.Click += new System.EventHandler(this.eligibilityBindingNavigatorSaveItem_Click);
            // 
            // eligibilityDataGridView
            // 
            this.eligibilityDataGridView.AutoGenerateColumns = false;
            this.eligibilityDataGridView.BackgroundColor = System.Drawing.Color.Cyan;
            this.eligibilityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eligibilityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.eligibilityDataGridView.DataSource = this.eligibilityBindingSource;
            this.eligibilityDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eligibilityDataGridView.Location = new System.Drawing.Point(846, 430);
            this.eligibilityDataGridView.Name = "eligibilityDataGridView";
            this.eligibilityDataGridView.RowHeadersWidth = 51;
            this.eligibilityDataGridView.RowTemplate.Height = 24;
            this.eligibilityDataGridView.Size = new System.Drawing.Size(10, 10);
            this.eligibilityDataGridView.TabIndex = 20;
            this.eligibilityDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eligibilityDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "fullName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn3.HeaderText = "age";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "stableIncome";
            this.dataGridViewTextBoxColumn4.HeaderText = "stableIncome";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "hours";
            this.dataGridViewTextBoxColumn5.HeaderText = "hours";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "owned";
            this.dataGridViewTextBoxColumn6.HeaderText = "owned";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "yard";
            this.dataGridViewTextBoxColumn7.HeaderText = "yard";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "eligibility";
            this.dataGridViewTextBoxColumn8.HeaderText = "eligibility";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // eligibilityBindingSource
            // 
            this.eligibilityBindingSource.DataMember = "Eligibility";
            this.eligibilityBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eligibilityTableAdapter
            // 
            this.eligibilityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EligibilityTableAdapter = this.eligibilityTableAdapter;
            this.tableAdapterManager.UpdateOrder = Coffee_adoption_application.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AdoptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coffee_adoption_application.Resource1._360_F_436777481_3Nk1sGJwa9UaYtJZ8dzeHVZrV4j0ACo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 564);
            this.Controls.Add(this.eligibilityDataGridView);
            this.Controls.Add(this.eligibilityBindingNavigator);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.eligibilityResultLabel);
            this.Controls.Add(this.q6textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.q2textBox3);
            this.Controls.Add(this.q3textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.q1textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.q5textBox5);
            this.Controls.Add(this.q4textBox4);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdoptionForm";
            this.Text = "AdoptionForm";
            this.Load += new System.EventHandler(this.AdoptionForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eligibilityBindingNavigator)).EndInit();
            this.eligibilityBindingNavigator.ResumeLayout(false);
            this.eligibilityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eligibilityDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eligibilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coffeeMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petAdoptionToolStripMenuItem;
        private System.Windows.Forms.TextBox q4textBox4;
        private System.Windows.Forms.TextBox q5textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox q1textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox q3textBox2;
        private System.Windows.Forms.TextBox q2textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox q6textBox6;
        private System.Windows.Forms.Label eligibilityResultLabel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label9;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource eligibilityBindingSource;
        private Database1DataSetTableAdapters.EligibilityTableAdapter eligibilityTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eligibilityBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eligibilityBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView eligibilityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}