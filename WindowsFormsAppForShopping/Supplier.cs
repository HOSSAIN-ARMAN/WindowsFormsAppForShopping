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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        SupplierManager _supplierManager = new SupplierManager();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierModel _supplierModel = new SupplierModel();

                if (saveButton.Text == "Save")
                {
                   
                    //_supplierModel.Id = Convert.ToInt32(idTextBox.Text);
                    _supplierModel.Code = codeTextBox.Text;
                    _supplierModel.Name = nameTextBox.Text;
                    _supplierModel.Address = addressTextBox.Text;
                    _supplierModel.Email = emailTextBox.Text;
                    _supplierModel.Contact = contactTextBox.Text;
                    _supplierModel.Person = personTextBox.Text;

                    if (_supplierManager.AddSupplier(_supplierModel))
                    {
                        supplieDataGridView.DataSource = _supplierManager.DisplaySaveSupplier();
                    }
                }
                else if(saveButton.Text == "Update")
                {
                    _supplierModel.Id = Convert.ToInt32(idTextBox.Text);
                    _supplierModel.Code = codeTextBox.Text;
                    _supplierModel.Name = nameTextBox.Text;
                    _supplierModel.Address = addressTextBox.Text;
                    _supplierModel.Email = emailTextBox.Text;
                    _supplierModel.Contact = contactTextBox.Text;
                    _supplierModel.Person = personTextBox.Text;

                    _supplierManager.UpdateSupplierInfo(_supplierModel);

                    idTextBox.Clear();
                    codeTextBox.Clear();
                    nameTextBox.Clear();
                    addressTextBox.Clear();
                    emailTextBox.Clear();
                    contactTextBox.Clear();
                    personTextBox.Clear();

                    supplieDataGridView.DataSource = _supplierManager.DisplaySaveSupplier();

                    saveButton.Text = "Save";
                    

                }
                

                

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void SupplieDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextBox.Text = supplieDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            codeTextBox.Text = supplieDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            nameTextBox.Text = supplieDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            addressTextBox.Text = supplieDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            emailTextBox.Text = supplieDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            contactTextBox.Text = supplieDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            personTextBox.Text = supplieDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            saveButton.Text = "Update";
        }

        private void SupplieDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            supplieDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
            supplieDataGridView.DataSource = _supplierManager.DisplaySaveSupplier();
        }
    }
}
