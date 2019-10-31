using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppForShopping.BLL;
using WindowsFormsAppForShopping.Model;

namespace WindowsFormsAppForShopping
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();



                purchaseDataGridView.ColumnCount = 11;
           
                purchaseDataGridView.Columns[0].Name = "Product Code";
                purchaseDataGridView.Columns[1].Name = "Manufracture date";
                purchaseDataGridView.Columns[2].Name = "Expire date";
                purchaseDataGridView.Columns[3].Name = "Quantity";
                purchaseDataGridView.Columns[4].Name = "Unit price";
                purchaseDataGridView.Columns[5].Name = "Total Price";
                purchaseDataGridView.Columns[6].Name = "MRP(tk)";
                purchaseDataGridView.Columns[7].Name = "Remarks";
                purchaseDataGridView.Columns[8].Name = "Supplier Date";
                purchaseDataGridView.Columns[9].Name = "Supplier Invoice";
                purchaseDataGridView.Columns[10].Name = "Supplier Name";

                //purchaseDataGridView.ColumnCount++;
         
            
            //purchaseDataGridView.Columns[11].Name = "";
            


        }
        PurchaseManager _purchaseManager = new PurchaseManager();
        ModelPurchase _modelPurchase = new ModelPurchase();

        /// <summary>
       
        /// </summary>
        //int invoiceAutoIncrement = 1111;
        /// <summary>
        /// ////
        /// </summary>

        

        private void Purchase_Load(object sender, EventArgs e)
        {
            SupplierManager _supplierManager = new SupplierManager();
            supplierComboBox.DataSource = _supplierManager.DisplayComboSupplier();

            CategoryManager _categoryManager = new CategoryManager();
            categoryComboBox.DataSource = _categoryManager.DisplayComboCategories();
           


           

            //ProductManager _productManager = new ProductManager();
            //productComboBox.DataSource =  _productManager.DisplayComboProducts();


            //ModelProduct _modelProduct = new ModelProduct();
            //_modelProduct.Name = categoryComboBox.Text;
            //_productManager.ProductComboList(_modelProduct);
            //productComboBox.DataSource = _productManager.DisplayComboProducts();


            //supplierInvoiceTextBox.Text = invoiceAutoIncrement.ToString();
        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ProductManager _productManager = new ProductManager();
                ModelProduct _modelProduct = new ModelProduct();
                _modelProduct.Name = productComboBox.Text;
                _productManager.ProductComboList(_modelProduct);
                codeTextBox.Text = _modelProduct.Name + " ( " + _modelProduct.Code + " )";

                //int qty = 0;
                //int availableQty = 0;
                //for (int i = 0; i < _productManager.ProductComboList(_modelProduct).Count; i++)
                //{
                //    qty = i + _modelProduct.Constant;
                //    availableQty = qty + 1;
                //}
               
                //availAbleQtyTextBox.Text = availableQty.ToString();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ProductManager _productManager = new ProductManager();
            ModelProduct _modelProduct = new ModelProduct();

            _modelProduct.CategoryName = categoryComboBox.Text;
            productComboBox.DataSource = _productManager.CategoryComboList(_modelProduct);
           

        }

        private void ProductUnittextBox_TextChanged(object sender, EventArgs e)
        {
            //int val = 0;
            _modelPurchase.Quantity = Convert.ToInt32(productQtytextBox.Text);
            if (string.IsNullOrEmpty(productUnittextBox.Text))
            {

                return;
            }
            
            _modelPurchase.UnitePrice = Convert.ToInt32(productUnittextBox.Text);

            int totalPrice = _modelPurchase.Quantity * _modelPurchase.UnitePrice;
            totalProductTextBox.Text = totalPrice.ToString();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
            //invoiceAutoIncrement++;
            //var autoNo = Convert.ToInt32(invoiceAutoIncrement);
            //supplierInvoiceTextBox.Text = autoNo.ToString();
        }

        private void SupplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //invoiceAutoIncrement++;
            //var autoNo = Convert.ToInt32(invoiceAutoIncrement);
            //supplierInvoiceTextBox.Text = autoNo.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            AddData(codeTextBox.Text, manufracturedateTimePicker.Value.ToString(), expiredateTimePicker.Value.ToString(), productQtytextBox.Text, productUnittextBox.Text, totalProductTextBox.Text, mrpTextBox.Text, remarkRichTextBox.Text, supplierDateTimePicker.Value.ToString(), supplierInvoiceTextBox.Text, supplierComboBox.Text);
            //remarkRichTextBox.Clear();
            //productQtytextBox.Clear();            
            //totalProductTextBox.Clear();
            //mrpTextBox.Clear();
            //availAbleQtyTextBox.Clear();
            //previousUnitTextBox.Clear();
            //previousMrpTextBox.Clear();
            
        }
        private void AddData(string code, string manufracture, string expire, string productQty, string productUnitPrice, string totalPrice, string mrp, string remark, string suplierDate, string supplirInvoice, string supplierName)
        {
            
            string[] row = { code, manufracture, expire, productQty , productUnitPrice , totalPrice , mrp, remark, suplierDate , supplirInvoice, supplierName };
            purchaseDataGridView.Rows.Add(row);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            
            bool isAdd = false;
            for (int  i = 0; i< purchaseDataGridView.Rows.Count -1; i++)
            {
                _modelPurchase.ProductCode = purchaseDataGridView.Rows[i].Cells[0].Value.ToString();
                _modelPurchase.ManufactureDate = purchaseDataGridView.Rows[i].Cells[1].Value.ToString();
                _modelPurchase.ExpireDate = purchaseDataGridView.Rows[i].Cells[2].Value.ToString();
                _modelPurchase.Quantity = Convert.ToInt32(purchaseDataGridView.Rows[i].Cells[3].Value.ToString());
                _modelPurchase.UnitePrice = Convert.ToInt32(purchaseDataGridView.Rows[i].Cells[4].Value.ToString());
                _modelPurchase.TotalPrice = Convert.ToInt32(purchaseDataGridView.Rows[i].Cells[5].Value.ToString());           
                _modelPurchase.MRP = Convert.ToInt32(purchaseDataGridView.Rows[i].Cells[6].Value.ToString());
                _modelPurchase.Remarks = purchaseDataGridView.Rows[i].Cells[7].Value.ToString();               
                _modelPurchase.SupplierDate = purchaseDataGridView.Rows[i].Cells[8].Value.ToString();
                _modelPurchase.supplierInvoice = purchaseDataGridView.Rows[i].Cells[9].Value.ToString();
                _modelPurchase.SupplierName = purchaseDataGridView.Rows[i].Cells[10].Value.ToString();
                isAdd = _purchaseManager.SubmitPurchase(_modelPurchase);
            }
           
            if (isAdd == true)
            {
                MessageBox.Show("Purchase Product Add Successfully Done !!!");
                purchaseDataGridView.Rows.Clear();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            _modelPurchase.ProductCode = codeTextBox.Text;

            if (_purchaseManager.IsCodeExits(_modelPurchase))
            {
                availAbleQtyTextBox.Text = _purchaseManager.AvaiableQuantity(_modelPurchase).ToString();
                previousUnitTextBox.Text = _purchaseManager.PreviousUnitPrice(_modelPurchase).ToString();
                previousMrpTextBox.Text = _purchaseManager.PreviousMRP(_modelPurchase).ToString();
            }
            else
            {
                availAbleQtyTextBox.Text = "0";
                previousUnitTextBox.Text = "0";
                previousMrpTextBox.Text = "0";
                return;
            }



            //if (string.IsNullOrEmpty(availAbleQtyTextBox.Text))
            //{
            //    availAbleQtyTextBox.Text = 0.ToString();
            //}
            //else
            //{
            //    availAbleQtyTextBox.Text = _purchaseManager.AvaiableQuantity(_modelPurchase).ToString();
            //}


           










            //availAbleQtyTextBox.Text = _purchaseManager.Qty(_modelPurchase).ToString();

            //int qty = 0;
            ////int availableQty = 0;

            //for (int i = 0; i < _purchaseManager.AvaiableQuantity(_modelPurchase).Count; i++)
            //{
            //    qty = i + _modelPurchase.Quantity;
            //    //availableQty = qty + 1;
            //}
            //availAbleQtyTextBox.Text = qty.ToString();


        }

        private void PurchaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            codeTextBox.Text = purchaseDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            //manufracturedateTimePicker.Text = purchaseDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            //expiredateTimePicker.Text = purchaseDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            productQtytextBox.Text = purchaseDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            totalProductTextBox.Text = purchaseDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            mrpTextBox.Text = purchaseDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            remarkRichTextBox.Text = purchaseDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            supplierComboBox.Text = purchaseDataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();

            //productUnittextBox.Text = purchaseDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();





            //purchaseDataGridView.Columns[0].Name = "Product Code";
            //purchaseDataGridView.Columns[1].Name = "Manufracture date";
            //purchaseDataGridView.Columns[2].Name = "Expire date";
            //purchaseDataGridView.Columns[3].Name = "Quantity";
            //purchaseDataGridView.Columns[4].Name = "Unit price";
            //purchaseDataGridView.Columns[5].Name = "Total Price";
            //purchaseDataGridView.Columns[6].Name = "MRP(tk)";
            //purchaseDataGridView.Columns[7].Name = "Remarks";
            //purchaseDataGridView.Columns[8].Name = "Supplier Date";
            //purchaseDataGridView.Columns[9].Name = "Supplier Invoice";
            //purchaseDataGridView.Columns[10].Name = "Supplier Name";
        }

        private void SupplierInvoiceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

 