using DataAccessLayer.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryRepository
    {
        public string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet; User ID = vjezbe; Password = vjezbe";

        public List<Category> GetAll()
        {
            var category = new List<Category>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Category";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        category.Add(new Category()
                        {                         
                            Id = Int32.Parse(reader["Country_id"].ToString()),
                            CategoryName = (string)reader["Country_name"]                          
                        });
                    }
                }
            }
            return category;
        }
    }
}
