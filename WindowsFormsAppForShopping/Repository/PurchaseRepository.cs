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

        public bool SubmitPurchase(ModelPurchase modelPurchase)
        {
            bool isSubmit = false;

            string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"INSERT INTO AddPurchase(ProductCode, ManufactureDate, ExpireDate, Quantity, UnitePrice,TotalPrice, Mrp, Remarks)
                                
                                VALUES('" + modelPurchase.ProductCode + "', '" + modelPurchase.ManufactureDate + "', '" + modelPurchase.ExpireDate + "'," + " " + modelPurchase.Quantity + ", " + modelPurchase.UnitePrice + ", " + modelPurchase.TotalPrice + ",  " + modelPurchase.MRP + ", " + "' " + modelPurchase.Remarks + "')";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                isSubmit = true;
            }
            sqlConnection.Close();
            return isSubmit;
        }
    }
}
