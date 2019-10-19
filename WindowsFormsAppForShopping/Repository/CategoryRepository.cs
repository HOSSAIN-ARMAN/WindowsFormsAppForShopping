using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppForShopping.Model;
 

namespace WindowsFormsAppForShopping.Repository
{
    public class CategoryRepository
    {
        public bool SaveCategory(ModelCategory modelCategory)
        {
            bool isSaveCategory = false;
            string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"INSERT INTO Categories(Code, Name)VALUES('" + modelCategory.Code+ "' , '"+modelCategory.Name+"')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int isExecute = sqlCommand.ExecuteNonQuery();
            if(isExecute > 0)
            {
                isSaveCategory = true;
            }
            sqlConnection.Close();
            return isSaveCategory;
        }
        public DataTable DisplaySaveCategories()
        {
            string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"SELECT * FROM Categories";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public List<ModelCategory> UpdateCategory(ModelCategory modelCategory)
        {
        
            string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"UPDATE Categories SET Code = '"+modelCategory.Code+"', Name = '"+modelCategory.Name+"' WHERE Id = "+modelCategory.Id+"";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<ModelCategory> upDateCategories = new List<ModelCategory>();
            upDateCategories.Add(modelCategory);
            sqlConnection.Close();
            return upDateCategories;
        }
        public bool IsCategoryCodeExits(ModelCategory modelCategory)
        {
            bool isCodeExits = false;
            string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"SELECT * FROM Categories WHERE Code = '"+modelCategory.Code+"'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if(dataTable.Rows.Count > 0)
            {
                isCodeExits = true;
            }
            sqlConnection.Close();
            return isCodeExits;
        }

        public DataTable DisplayComboCategories()
        {
            string connection = @"Server = AHO-BATIJA; DataBase = SmallBusinessManagementSystem; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connection);
            string query = @"SELECT Id, Name FROM Categories";
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
