using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserRepository
    {
        public string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";

        public void SaveUser(User user, Category category, Difficulty difficulty)
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand oCommand = connection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO [User](UserName, Category, Difficulty) VALUES('" + user.UserName + "','" + category.CategoryName + "','" + difficulty.DifficultyLevel + "')";
                connection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }

            }
        }

    }
}
