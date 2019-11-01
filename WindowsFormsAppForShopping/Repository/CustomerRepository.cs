using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppForShopping.Model;

namespace WindowsFormsAppForShopping.Repository
{
    public class CustomerRepository
    {
        string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
        public bool SaveCustomer(ModelCustomer modelCustomer)
        {
            bool isSaveCustomer = false;
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"INSERT INTO Customer(CustomerCode, CustomerName, CustomerAddress, CustomerEmail, Contact, LoyaltyPoint)VALUES('" + modelCustomer.CustomerCode + "' , '" + modelCustomer.CustomerName + "', '" + modelCustomer.CustomerAddress + "', '" + modelCustomer.CustomerEmail + "', '" + modelCustomer.Contact + "', "+modelCustomer.LoyaltyPoint+")";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                isSaveCustomer = true;
            }
            sqlConnection.Close();
            return isSaveCustomer;
        }
        public DataTable DisplayCustomerInfo()
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"SELECT Id, CustomerName FROM Customer";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }
    }
}
