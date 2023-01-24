using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebShopLibrary
{
    public class UserRepository
    {
        public static List<User> GetUsers()
        {
            List<User> Users = new List<User>();
            string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Nemet_Users";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Users.Add(new User()
                        {
                            Username = (string)reader["username"],
                            Password = (string)reader["password"]
                        });

                    }
                }
            }
            return Users;
        }
    }
}
