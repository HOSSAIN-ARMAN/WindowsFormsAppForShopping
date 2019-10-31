using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppForShopping.Model;
using WindowsFormsAppForShopping.BLL;

namespace WindowsFormsAppForShopping.Repository
{
    public class PurchaseRepository
    {
        //public bool SaveCategory(ModelCategory modelCategory)
        //{
        //    bool isSaveCategory = false;
        //    string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
        //    SqlConnection sqlConnection = new SqlConnection(connection);
        //    string query = @"INSERT INTO Purchase(ProductCode, ManufactureDate, ExpireDate, Quantity)
        //                  VALUES('" + modelCategory.Code + "' , '" + modelCategory.Name + "')";


        //    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        //    sqlConnection.Open();
        //    int isExecute = sqlCommand.ExecuteNonQuery();
        //    if (isExecute > 0)
        //    {
        //        isSaveCategory = true;
        //    }
        //    sqlConnection.Close();
        //    return isSaveCategory;
        //}

        string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";

        
        public bool SubmitPurchase(ModelPurchase modelPurchase)
        {
            bool isSubmit = false;

            
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"INSERT INTO AddPurchase(ProductCode, ManufactureDate, ExpireDate, Quantity, UnitePrice,TotalPrice, Mrp,  Remarks, SupplierDate, supplierInvoice, SupplierName)
                                
                                VALUES('" + modelPurchase.ProductCode + "', '" + modelPurchase.ManufactureDate + "', '" + modelPurchase.ExpireDate + "'," + " " + modelPurchase.Quantity + ", " + modelPurchase.UnitePrice + ", " + modelPurchase.TotalPrice + ", " + modelPurchase.MRP + ", " + "' " + modelPurchase.Remarks + "', '"+modelPurchase.SupplierDate+"', '"+modelPurchase.supplierInvoice+"', '"+modelPurchase.SupplierName+"' )";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                isSubmit = true;
            }
            sqlConnection.Close();
            return isSubmit;
        }

        public bool IsCodeExits(ModelPurchase modelPurchase)
        {
            bool isCodeExits = false;

            SqlConnection sqlConnection = new SqlConnection(connection);

            string query = @"SELECT * FROM AddPurchase WHERE ProductCode = '" + modelPurchase.ProductCode + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                isCodeExits = true;
                //displayDataGridView.DataSource = dataTable;
                //itemName = "";
            }

            sqlConnection.Close();
            return isCodeExits;
        }

        public string AvaiableQuantity(ModelPurchase modelPurchase)
        {
            string availableqty = "";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"SELECT SUM(Quantity) FROM AddPurchase WHERE ProductCode = '" + modelPurchase.ProductCode + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            //sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                availableqty = sqlDataReader[modelPurchase.Quantity].ToString();

            }
            sqlConnection.Close();
            return availableqty;
        }
        public string PreviousUnitPrice(ModelPurchase modelPurchase)
        {
            //if ( connection.Equals == ConnectionState.Closed)
            //{
            //    connection.Open();
            //}
            string previousUnitPrice = "";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"SELECT  TOP(1)UnitePrice FROM AddPurchase WHERE ProductCode = '" + modelPurchase.ProductCode + "' ORDER BY UnitePrice DESC";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                previousUnitPrice = sqlDataReader[modelPurchase.UnitePrice].ToString();

            }
            sqlConnection.Close();
            return previousUnitPrice;
        }
        public string PreviousMRP(ModelPurchase modelPurchase)
        {
            string previousMrp = "";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"SELECT  TOP(1)Mrp FROM AddPurchase WHERE ProductCode = '" + modelPurchase.ProductCode + "' ORDER BY UnitePrice DESC";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                previousMrp = sqlDataReader[modelPurchase.MRP].ToString();

            }
            sqlConnection.Close();
            return previousMrp;
        }
    }
}
        