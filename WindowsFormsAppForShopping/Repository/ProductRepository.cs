using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppForShopping.BLL;
using WindowsFormsAppForShopping.Model;

namespace WindowsFormsAppForShopping.Repository
{
    public class ProductRepository
    {
       public bool SaveProduct(ModelProduct modelProduct)
        {
            bool isSaveProduct = false;
            string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"INSERT INTO Products(CategoryName, Code, Name, ReOrder, Description)VALUES('" + modelProduct.CategoryName+"','" + modelProduct.Code + "' , '" + modelProduct.Name + "', "+modelProduct.ReOrder+",'"+modelProduct.Description+"')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                isSaveProduct = true;
            }
            sqlConnection.Close();
            return isSaveProduct;

        }
        public DataTable DisplaySaveProducts()
        {
            string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"SELECT * FROM Products";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public List<ModelProduct> UpdateProduct(ModelProduct modelProduct)
        {
            string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"UPDATE Products SET CategoryName='"+modelProduct.CategoryName+"', Code='"+modelProduct.Code+"', Name='"+modelProduct.Name+ "', ReOrder="+modelProduct.ReOrder+ ", Description='"+modelProduct.Description+"' WHERE Id = "+modelProduct.Id+"";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            List<ModelProduct> modelProductList = new List<ModelProduct>();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            modelProductList.Add(modelProduct);
            sqlConnection.Close();
            return modelProductList;

        }
        public bool IsProductCodeExits(ModelProduct modelProduct)
        {
            bool isCodeExits = false;
            string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"SELECT * FROM Products WHERE Code = '" + modelProduct.Code + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                isCodeExits = true;
            }
            sqlConnection.Close();
            return isCodeExits;
        }
    }
}
