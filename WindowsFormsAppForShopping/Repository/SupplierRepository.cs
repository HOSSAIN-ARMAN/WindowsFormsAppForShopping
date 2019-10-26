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
    public class SupplierRepository
    {
        public bool AddSupplier(SupplierModel supplierModel)
        {
            bool isAddSupplier = false;
            string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"INSERT INTO Supplier(Code, Name, Address, Email, Contact, Person)VALUES('" + supplierModel.Code + "','" + supplierModel.Name + "' , '" + supplierModel.Address + "', '" + supplierModel.Email + "','" + supplierModel.Contact + "', '" + supplierModel.Person + "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                isAddSupplier = true;
            }
            sqlConnection.Close();
            return isAddSupplier;
        }
        public DataTable DisplaySaveSupplier()
        {
            string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"SELECT * FROM Supplier";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public List<SupplierModel> UpdateSupplierInfo(SupplierModel supplierModel)
        {
            string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"UPDATE Supplier SET Code='" + supplierModel.Code + "', Name='" + supplierModel.Name + "', Address='" + supplierModel.Address + "', Email='" + supplierModel.Email + "',  Contact='" + supplierModel.Contact + "', Person='" + supplierModel.Person + "'  WHERE Id = " + supplierModel.Id + "";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            List<SupplierModel> supplierInfotList = new List<SupplierModel>();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            supplierInfotList.Add(supplierModel);
            sqlConnection.Close();
            return supplierInfotList;

        }
        public DataTable DisplayComboSupplier()
        {
            string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"SELECT Id, Name FROM Supplier";
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
