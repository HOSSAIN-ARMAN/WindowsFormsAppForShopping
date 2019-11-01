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
    public partial class SalesModule : Form
    {
        public SalesModule()
        {
            InitializeComponent();
        }

        
        private void SalesModule_Load(object sender, EventArgs e)
        {
            CustomerManager _customerManager = new CustomerManager();
            customerComboBox.DataSource = _customerManager.DisplayCustomerInfo();


            PurchaseManager _purchaseManager = new PurchaseManager();
            categoryComboBox.DataSource =  _purchaseManager.PurchaseCategory();

            

        }

       
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PurchaseManager _purchaseManager = new PurchaseManager();
            ModelPurchase _modelPurchase = new ModelPurchase();
            _modelPurchase.purchaseCategory = categoryComboBox.Text;
            purchaseProductComboBox.DataSource = _purchaseManager.PurchaseProduct(_modelPurchase);
        }

        private void PurchaseProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelPurchase _modelPurchase = new ModelPurchase();
            _modelPurchase.purchaseProduct = purchaseProductComboBox.Text;

            PurchaseManager _purchaseManager = new PurchaseManager();
            availableQtyTextBox.Text = _purchaseManager.AvaiablePurchaseQuantity(_modelPurchase);
            totalMrpTextBox.Text = _purchaseManager.TotalMrp(_modelPurchase);
        }
    }
}
