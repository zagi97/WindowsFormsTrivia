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
        private List<Category> _category = new List<Category>();

        public CategoryRepository() //konstruktor
        {

            string url = "https://opentdb.com/api.php?amount=10";
            string json = CallRestMethod(url);

            JArray jsonObject = JArray.Parse(json);

            foreach (JObject item in jsonObject)
            {
                _category.Add(new Category
                {
                    CategoryName = (string)item["category"]                  
                });
            }

        }

        public List<Category> GetCategory()
        {
            return _category;
        }

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
    }
}
