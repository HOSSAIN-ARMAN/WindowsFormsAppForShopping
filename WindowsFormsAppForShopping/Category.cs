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
    public partial class Category : Form
    {
        CategoryManager _categoryManager = new CategoryManager();
        ModelCategory _modelCategory = new ModelCategory();
        public Category()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(saveButton.Text == "Save")
                {
                   
                    _modelCategory.Code = codeTextBox.Text;
                    if (string.IsNullOrEmpty(codeTextBox.Text))
                    {
                        MessageBox.Show("Input Field Can Not Be Empty");
                        return;
                    }

                    if (_categoryManager.IsCategoryCodeExits(_modelCategory))
                    {
                        MessageBox.Show("Sorry This Code Already Exits!!!");
                        codeTextBox.Clear();
                        nametextBox.Clear();
                        return;
                    }

                    if (codeTextBox.Text.Length != 4)
                    {
                        MessageBox.Show("Code must be 4 Charecter in Length");
                        return;
                    }

                    _modelCategory.Name = nametextBox.Text;
                    bool saveCategory = _categoryManager.SaveCategory(_modelCategory);

                    if (saveCategory)
                    {
                        codeTextBox.Clear();
                        nametextBox.Clear();

                        categoryDataGridView.DataSource = _categoryManager.DisplaySaveCategories();
                    }
                    else
                    {
                        MessageBox.Show("Error: " + saveCategory);
                    }

                }else if(saveButton.Text == "Update")
                {
                    if (string.IsNullOrEmpty(nametextBox.Text) || string.IsNullOrEmpty(codeTextBox.Text))
                    {
                        saveButton.Text = "Save";
                        return;
                    }
                    _modelCategory.Id = Convert.ToInt32(idtextBox.Text);
                    _modelCategory.Code = codeTextBox.Text.ToString();
                    _modelCategory.Name = nametextBox.Text.ToString();
                    _categoryManager.UpdateCategory(_modelCategory);

                    saveButton.Text = "Save";
                }
                else
                {

                }
               

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CategoryDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            categoryDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            
        }

        private void CategoryGroupBox_Enter(object sender, EventArgs e)
        {
            categoryDataGridView.DataSource = _categoryManager.DisplaySaveCategories();
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.HeaderText = "Action";
            //btn.Text = "Edit";
            //btn.Name = "editButton";
            //btn.UseColumnTextForButtonValue = true;
            //btn.Visible = true;
            //categoryDataGridView.Columns.Add(btn);

        }
        
        private void CategoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idtextBox.Text  = categoryDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                codeTextBox.Text = categoryDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                nametextBox.Text = categoryDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                saveButton.Text = "Update";

            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }
    }
}
