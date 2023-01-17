using System;
using System.Collections.Generic;
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
        public static List<Product> GetProducts()
        {
            List<Product> ProductsREST = new List<Product>();
            foreach (JObject item in GetArrayOfObject("https://fakestoreapi.com/products"))
            {
                ProductsREST.Add(new Product
                {
                    id = (string)item.GetValue("id"),
                    title = (string)item.GetValue("title"),
                    price = (float)item.GetValue("price"),
                    description = (string)item.GetValue("description"),
                    category = (string)item.GetValue("category"),
                    image = (string)item.GetValue("image")
                });
            }
            return ProductsREST;
        }
        public static JArray GetArrayOfObject(string url)
        {
            string json = CallRestMethod(url);
            JArray Json = JArray.Parse(json);
            return Json;
        }
        public static List<string> GetCategory()
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
        public static List<Product> Filter(string category)
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

    }
}