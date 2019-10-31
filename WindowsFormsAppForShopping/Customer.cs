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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        CustomerManager _customerManager = new CustomerManager();
        ModelCustomer _modelCustomer = new ModelCustomer();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _modelCustomer.CustomerCode = customerCodetextBox.Text;
            _modelCustomer.CustomerName = customerNameTextBox.Text;
            _modelCustomer.CustomerAddress = customerAddresstextBox.Text;
            _modelCustomer.CustomerEmail = customerEmailTextBox.Text;
            _modelCustomer.Contact = contactTextBox.Text;
            _modelCustomer.LoyaltyPoint = Convert.ToInt32(loyaltyPointTextBox.Text);

            if (_customerManager.SaveCustomer(_modelCustomer))
            {
               customerDataGridView.DataSource = _customerManager.DisplayCustomerInfo();
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            customerDataGridView.DataSource = _customerManager.DisplayCustomerInfo();
        }
    }
}
