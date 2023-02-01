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
    public class ProductRepository
    {
        public static string CallRestMethod(string url)
        {
            try
            {
                HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "GET";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
                Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
                StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
                string result = string.Empty;
                result = responseStream.ReadToEnd();
                webresponse.Close();
                return result;
            }
            catch(Exception)
            {
                return "";
            }

        }
        public static void OneTimeFunction()
        {
            List<Product> ProductsREST = new List<Product>();
            foreach (JObject item in GetArrayOfObject("https://fakestoreapi.com/products"))
            {
                ProductsREST.Add(new Product
                {
                    id = (int)item.GetValue("id"),
                    title = (string)item.GetValue("title"),
                    price = (float)item.GetValue("price"),
                    description = (string)item.GetValue("description"),
                    category = (string)item.GetValue("category"),
                    image = (string)item.GetValue("image")
                });
            }
            string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Nemet_Products (title, price, description, category, image) VALUES (@title, @price, @description, @category, @image)";
                command.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar) { Size = 50 });
                command.Parameters.Add(new SqlParameter("@price", SqlDbType.Money));
                command.Parameters.Add(new SqlParameter("@description", SqlDbType.Text));
                command.Parameters.Add(new SqlParameter("@category", SqlDbType.NVarChar) { Size = 50 });
                command.Parameters.Add(new SqlParameter("@image", SqlDbType.Text));

                foreach (Product product in ProductsREST)
                {
                    command.Parameters["@title"].Value = product.title;
                    command.Parameters["@price"].Value = product.price;
                    command.Parameters["@description"].Value = product.description;
                    command.Parameters["@category"].Value = product.category;
                    command.Parameters["@image"].Value = product.image;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public static void DeleteProduct(string id)
        {
            try
            {
                string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";
                using (DbConnection connection = new SqlConnection(connectionString))
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Nemet_Products WHERE id = @id";
                    command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = id });
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception)
            { }
        }
        public static void CreateProductDb(Product product)
        {
            try
            {
                string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";
                using (DbConnection connection = new SqlConnection(connectionString))
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Nemet_Products (title, price, description, category, image) VALUES (@title, @price, @description, @category, @image)";
                    command.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar) { Size = 50 });
                    command.Parameters.Add(new SqlParameter("@price", SqlDbType.Money));
                    command.Parameters.Add(new SqlParameter("@description", SqlDbType.Text));
                    command.Parameters.Add(new SqlParameter("@category", SqlDbType.NVarChar) { Size = 50 });
                    command.Parameters.Add(new SqlParameter("@image", SqlDbType.Text));
                    command.Parameters["@title"].Value = product.title;
                    command.Parameters["@price"].Value = product.price;
                    command.Parameters["@description"].Value = product.description;
                    command.Parameters["@category"].Value = product.category;
                    command.Parameters["@image"].Value = product.image;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch(Exception)
            { }
        }
        public static List<Product> GetProductsDB()
        {
            try
            {

                List<Product> products = new List<Product>();
                string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";
                using (DbConnection connection = new SqlConnection(connectionString))
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Nemet_Products";
                    connection.Open();
                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            float price;
                            if (!float.TryParse(reader["price"].ToString(), out price))
                            {
                                price = 0;
                            }
                            products.Add(new Product()
                            {
                                id = (int)reader["id"],
                                title = (string)reader["title"],
                                price = price,
                                description = (string)reader["description"],
                                category = (string)reader["category"],
                                image = (string)reader["image"]
                            });

                        }
                    }
                }
                return products;
            }
            catch(Exception) {
                return null;
            }

        }
        public static List<Product> GetProducts()
        {
            try
            {
                
            
            List<Product> ProductsREST = new List<Product>();
            foreach (JObject item in GetArrayOfObject("https://fakestoreapi.com/products"))
            {
                ProductsREST.Add(new Product
                {
                    id = (int)item.GetValue("id"),
                    title = (string)item.GetValue("title"),
                    price = (float)item.GetValue("price"),
                    description = (string)item.GetValue("description"),
                    category = (string)item.GetValue("category"),
                    image = (string)item.GetValue("image")
                });
            }
            return ProductsREST;
            }
            catch(Exception)
            {
                return null;
            }
        }
        public static JArray GetArrayOfObject(string url)
        {
            try
            {
            string json = CallRestMethod(url);
            JArray Json = JArray.Parse(json);
            return Json;
            }
            catch(Exception) { return null; }
        }
        public static List<string> GetCategory()
        {
            try
            {
                JArray Json = GetArrayOfObject("https://fakestoreapi.com/products/categories");
                List<string> CategoryREST = new List<string>();
                CategoryREST.Add("---Choose item category---");
                foreach (JValue item in Json)
                {
                    CategoryREST.Add((string)item);
                }
                return CategoryREST;
            }
            catch(Exception) { return null; }

        }
        public static List<Product> Filter(string category, string source)
        {
            try
            {
                if(source == "api")
                {
                    List<Product> filtered = GetProducts();
                    if (category == "---Choose item category---")
                    {
                        return filtered;
                    }
                    else
                    {

                        return filtered.Where(x => x.category == category).ToList();
                    }
                }    
                else if(source == "db")
                {
                    List<Product> filtered = GetProductsDB();
                    if (category == "---Choose item category---")
                    {
                        return filtered;
                    }
                    else
                    {

                        return filtered.Where(x => x.category == category).ToList();
                    }
                }
                return null;
            }
            catch(Exception) { return null; }
        }

        public static void UpdateProduct(Product product)
        {
            try
            {
                string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";
                using (DbConnection connection = new SqlConnection(connectionString))
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE Nemet_Products SET title=@title, price=@price, description=@description, category=@category, image=@image WHERE id = @id";
                    command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = product.id });
                    command.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar) { Value = product.title });
                    command.Parameters.Add(new SqlParameter("@price", SqlDbType.Money) { Value = product.price });
                    command.Parameters.Add(new SqlParameter("@description", SqlDbType.Text) { Value = product.description });
                    command.Parameters.Add(new SqlParameter("@category", SqlDbType.NVarChar) { Value = product.category });
                    command.Parameters.Add(new SqlParameter("@image", SqlDbType.Text) { Value = product.image });
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception)
            { }

        }
    }
}