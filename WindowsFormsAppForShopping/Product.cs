using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppForShopping.BLL;
using WindowsFormsAppForShopping.Model;

namespace WindowsFormsAppForShopping
{
    public partial class Product : Form
    {
        //this _categoryManager use for CategoryCombox
        CategoryManager _categoryManager = new CategoryManager();

        ProductManager _productManager = new ProductManager();
        ModelProduct _modelProduct = new ModelProduct(); 
        public Product()
        {
            InitializeComponent();
        }

        private void ProductGroupBox_Enter(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = _categoryManager.DisplayComboCategories();

            productDataGridView.DataSource = _productManager.DisplaySaveProducts();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
               if(saveButton.Text == "Save")
                {
                    
                    _modelProduct.CategoryName = categoryComboBox.Text;
                    _modelProduct.Code = codeTextBox.Text;
                    if (string.IsNullOrEmpty(codeTextBox.Text))
                    {
                        MessageBox.Show("Code Can not be Empty!!");
                        return;
                    }
                    if (_productManager.IsProductCodeExits(_modelProduct))
                    {
                        MessageBox.Show("This Code Already Exits!!");
                        return;
                    }
                    _modelProduct.Name = nameTextBox.Text;
                    if (string.IsNullOrEmpty(nameTextBox.Text))
                    {
                        MessageBox.Show("Name Can not be Empty!!");
                        return;
                    }
                    _modelProduct.ReOrder = Convert.ToInt32(reOrederTextBox.Text);
                    _modelProduct.Description = descriptionRichTextBox.Text;
                    
                    if (_productManager.SaveProduct(_modelProduct))
                    {

                        categoryComboBox.DataSource = _categoryManager.DisplayComboCategories();
                        productDataGridView.DataSource = _productManager.DisplaySaveProducts();

                        categoryComboBox.Text = "";
                        codeTextBox.Clear();
                        nameTextBox.Clear();
                        reOrederTextBox.Clear();
                        descriptionRichTextBox.Clear();
                        return;
                    }
                }
               else if(saveButton.Text == "Update")
               {
                    if (string.IsNullOrEmpty(codeTextBox.Text) || string.IsNullOrEmpty(nameTextBox.Text))
                    {
                        saveButton.Text = "Save";
                    }
                    else
                    {
                        _modelProduct.Id = Convert.ToInt32(idTextBox.Text);
                        _modelProduct.CategoryName = categoryComboBox.Text;
                        _modelProduct.Code = codeTextBox.Text;
                        _modelProduct.Name = nameTextBox.Text;
                        _modelProduct.ReOrder = Convert.ToInt32(reOrederTextBox.Text);
                        _modelProduct.Description = descriptionRichTextBox.Text;

                        _productManager.UpdateProduct(_modelProduct);
                        categoryComboBox.DataSource = _categoryManager.DisplayComboCategories();
                        productDataGridView.DataSource = _productManager.DisplaySaveProducts();

                        categoryComboBox.Text = "";
                        codeTextBox.Clear();
                        nameTextBox.Clear();
                        reOrederTextBox.Clear();
                        descriptionRichTextBox.Clear();

                        saveButton.Text = "Save";
                    }
                    
               }

            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ProductDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                productDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idTextBox.Text = productDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                categoryComboBox.Text = productDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                codeTextBox.Text = productDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                nameTextBox.Text = productDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                reOrederTextBox.Text = productDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                descriptionRichTextBox.Text = productDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                saveButton.Text = "Update";

            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
