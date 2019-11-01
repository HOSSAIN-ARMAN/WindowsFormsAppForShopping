namespace WindowsFormsAppForShopping
{
    partial class Purchase
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.supplierModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierInvoiceTextBox = new System.Windows.Forms.TextBox();
            this.supplierDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductGroupBox = new System.Windows.Forms.GroupBox();
            this.expiredateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.manufracturedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.remarkRichTextBox = new System.Windows.Forms.RichTextBox();
            this.mrpTextBox = new System.Windows.Forms.TextBox();
            this.previousMrpTextBox = new System.Windows.Forms.TextBox();
            this.previousUnitTextBox = new System.Windows.Forms.TextBox();
            this.totalProductTextBox = new System.Windows.Forms.TextBox();
            this.productUnittextBox = new System.Windows.Forms.TextBox();
            this.productQtytextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.availAbleQtyTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.modelProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.modelCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.purchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.submitButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierModelBindingSource)).BeginInit();
            this.ProductGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.supplierComboBox);
            this.groupBox1.Controls.Add(this.supplierInvoiceTextBox);
            this.groupBox1.Controls.Add(this.supplierDateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(169, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.DataSource = this.supplierModelBindingSource;
            this.supplierComboBox.DisplayMember = "Name";
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(137, 69);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(142, 21);
            this.supplierComboBox.TabIndex = 3;
            this.supplierComboBox.ValueMember = "Id";
            this.supplierComboBox.SelectedIndexChanged += new System.EventHandler(this.SupplierComboBox_SelectedIndexChanged);
            // 
            // supplierInvoiceTextBox
            // 
            this.supplierInvoiceTextBox.Location = new System.Drawing.Point(137, 42);
            this.supplierInvoiceTextBox.Name = "supplierInvoiceTextBox";
            this.supplierInvoiceTextBox.Size = new System.Drawing.Size(200, 20);
            this.supplierInvoiceTextBox.TabIndex = 2;
            this.supplierInvoiceTextBox.TextChanged += new System.EventHandler(this.SupplierInvoiceTextBox_TextChanged);
            // 
            // supplierDateTimePicker
            // 
            this.supplierDateTimePicker.Location = new System.Drawing.Point(137, 13);
            this.supplierDateTimePicker.Name = "supplierDateTimePicker";
            this.supplierDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.supplierDateTimePicker.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bill/Invoice No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // ProductGroupBox
            // 
            this.ProductGroupBox.Controls.Add(this.expiredateTimePicker);
            this.ProductGroupBox.Controls.Add(this.manufracturedateTimePicker);
            this.ProductGroupBox.Controls.Add(this.addButton);
            this.ProductGroupBox.Controls.Add(this.label16);
            this.ProductGroupBox.Controls.Add(this.remarkRichTextBox);
            this.ProductGroupBox.Controls.Add(this.mrpTextBox);
            this.ProductGroupBox.Controls.Add(this.previousMrpTextBox);
            this.ProductGroupBox.Controls.Add(this.previousUnitTextBox);
            this.ProductGroupBox.Controls.Add(this.totalProductTextBox);
            this.ProductGroupBox.Controls.Add(this.productUnittextBox);
            this.ProductGroupBox.Controls.Add(this.productQtytextBox);
            this.ProductGroupBox.Controls.Add(this.label15);
            this.ProductGroupBox.Controls.Add(this.label14);
            this.ProductGroupBox.Controls.Add(this.label13);
            this.ProductGroupBox.Controls.Add(this.label12);
            this.ProductGroupBox.Controls.Add(this.label11);
            this.ProductGroupBox.Controls.Add(this.label10);
            this.ProductGroupBox.Controls.Add(this.availAbleQtyTextBox);
            this.ProductGroupBox.Controls.Add(this.codeTextBox);
            this.ProductGroupBox.Controls.Add(this.productComboBox);
            this.ProductGroupBox.Controls.Add(this.categoryComboBox);
            this.ProductGroupBox.Controls.Add(this.label9);
            this.ProductGroupBox.Controls.Add(this.label8);
            this.ProductGroupBox.Controls.Add(this.label7);
            this.ProductGroupBox.Controls.Add(this.label6);
            this.ProductGroupBox.Controls.Add(this.label5);
            this.ProductGroupBox.Controls.Add(this.label4);
            this.ProductGroupBox.Location = new System.Drawing.Point(58, 158);
            this.ProductGroupBox.Name = "ProductGroupBox";
            this.ProductGroupBox.Size = new System.Drawing.Size(640, 231);
            this.ProductGroupBox.TabIndex = 1;
            this.ProductGroupBox.TabStop = false;
            this.ProductGroupBox.Text = "Product";
            // 
            // expiredateTimePicker
            // 
            this.expiredateTimePicker.Location = new System.Drawing.Point(132, 142);
            this.expiredateTimePicker.Name = "expiredateTimePicker";
            this.expiredateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.expiredateTimePicker.TabIndex = 12;
            // 
            // manufracturedateTimePicker
            // 
            this.manufracturedateTimePicker.Location = new System.Drawing.Point(132, 118);
            this.manufracturedateTimePicker.Name = "manufracturedateTimePicker";
            this.manufracturedateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.manufracturedateTimePicker.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(539, 178);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "ReMarks";
            // 
            // remarkRichTextBox
            // 
            this.remarkRichTextBox.Location = new System.Drawing.Point(132, 172);
            this.remarkRichTextBox.Name = "remarkRichTextBox";
            this.remarkRichTextBox.Size = new System.Drawing.Size(401, 53);
            this.remarkRichTextBox.TabIndex = 5;
            this.remarkRichTextBox.Text = "";
            // 
            // mrpTextBox
            // 
            this.mrpTextBox.Location = new System.Drawing.Point(433, 135);
            this.mrpTextBox.Name = "mrpTextBox";
            this.mrpTextBox.Size = new System.Drawing.Size(100, 20);
            this.mrpTextBox.TabIndex = 4;
            // 
            // previousMrpTextBox
            // 
            this.previousMrpTextBox.Location = new System.Drawing.Point(433, 113);
            this.previousMrpTextBox.Name = "previousMrpTextBox";
            this.previousMrpTextBox.Size = new System.Drawing.Size(100, 20);
            this.previousMrpTextBox.TabIndex = 4;
            // 
            // previousUnitTextBox
            // 
            this.previousUnitTextBox.Location = new System.Drawing.Point(433, 88);
            this.previousUnitTextBox.Name = "previousUnitTextBox";
            this.previousUnitTextBox.Size = new System.Drawing.Size(100, 20);
            this.previousUnitTextBox.TabIndex = 4;
            // 
            // totalProductTextBox
            // 
            this.totalProductTextBox.Location = new System.Drawing.Point(433, 60);
            this.totalProductTextBox.Name = "totalProductTextBox";
            this.totalProductTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalProductTextBox.TabIndex = 4;
            // 
            // productUnittextBox
            // 
            this.productUnittextBox.Location = new System.Drawing.Point(433, 37);
            this.productUnittextBox.Name = "productUnittextBox";
            this.productUnittextBox.Size = new System.Drawing.Size(100, 20);
            this.productUnittextBox.TabIndex = 4;
            this.productUnittextBox.TextChanged += new System.EventHandler(this.ProductUnittextBox_TextChanged);
            // 
            // productQtytextBox
            // 
            this.productQtytextBox.Location = new System.Drawing.Point(433, 12);
            this.productQtytextBox.Name = "productQtytextBox";
            this.productQtytextBox.Size = new System.Drawing.Size(100, 20);
            this.productQtytextBox.TabIndex = 4;
            this.productQtytextBox.TextChanged += new System.EventHandler(this.ProductQtytextBox_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(322, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "MRP (TK)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(322, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Previous MRP";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(322, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Previous Unit Price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(322, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(322, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Unit Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(322, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Quantity";
            // 
            // availAbleQtyTextBox
            // 
            this.availAbleQtyTextBox.Location = new System.Drawing.Point(132, 91);
            this.availAbleQtyTextBox.Name = "availAbleQtyTextBox";
            this.availAbleQtyTextBox.Size = new System.Drawing.Size(121, 20);
            this.availAbleQtyTextBox.TabIndex = 2;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(132, 63);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(121, 20);
            this.codeTextBox.TabIndex = 2;
            this.codeTextBox.TextChanged += new System.EventHandler(this.CodeTextBox_TextChanged);
            // 
            // productComboBox
            // 
            this.productComboBox.DataSource = this.modelProductBindingSource;
            this.productComboBox.DisplayMember = "Name";
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(132, 37);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(121, 21);
            this.productComboBox.TabIndex = 1;
            this.productComboBox.ValueMember = "Id";
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductComboBox_SelectedIndexChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.modelCategoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(132, 12);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Expire Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Manufactured Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Available Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Products";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category";
            // 
            // purchaseDataGridView
            // 
            this.purchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseDataGridView.Location = new System.Drawing.Point(12, 395);
            this.purchaseDataGridView.Name = "purchaseDataGridView";
            this.purchaseDataGridView.Size = new System.Drawing.Size(776, 118);
            this.purchaseDataGridView.TabIndex = 2;
            this.purchaseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PurchaseDataGridView_CellContentClick);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(704, 519);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(530, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.purchaseDataGridView);
            this.Controls.Add(this.ProductGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierModelBindingSource)).EndInit();
            this.ProductGroupBox.ResumeLayout(false);
            this.ProductGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.TextBox supplierInvoiceTextBox;
        private System.Windows.Forms.DateTimePicker supplierDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ProductGroupBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mrpTextBox;
        private System.Windows.Forms.TextBox previousMrpTextBox;
        private System.Windows.Forms.TextBox previousUnitTextBox;
        private System.Windows.Forms.TextBox totalProductTextBox;
        private System.Windows.Forms.TextBox productUnittextBox;
        private System.Windows.Forms.TextBox productQtytextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox availAbleQtyTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox remarkRichTextBox;
        private System.Windows.Forms.DataGridView purchaseDataGridView;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.BindingSource supplierModelBindingSource;
        private System.Windows.Forms.BindingSource modelCategoryBindingSource;
        private System.Windows.Forms.BindingSource modelProductBindingSource;
        private System.Windows.Forms.DateTimePicker expiredateTimePicker;
        private System.Windows.Forms.DateTimePicker manufracturedateTimePicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}