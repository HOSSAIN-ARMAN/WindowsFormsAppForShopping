using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppForShopping.Repository;
using WindowsFormsAppForShopping.Model;

namespace WindowsFormsAppForShopping.BLL
{
    public class ProductManager
    {
        ProductRepository _productRepository = new ProductRepository();
        public bool SaveProduct(ModelProduct modelProduct)
        {
            return _productRepository.SaveProduct(modelProduct);
        }
        public DataTable DisplaySaveProducts()
        {
            return _productRepository.DisplaySaveProducts();
        }
        public List<ModelProduct> UpdateProduct(ModelProduct modelProduct)
        {
            return _productRepository.UpdateProduct(modelProduct);
        }
        public bool IsProductCodeExits(ModelProduct modelProduct)
        {
            return _productRepository.IsProductCodeExits(modelProduct);
        }
    }
}
