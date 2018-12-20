using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using Newtonsoft.Json.Linq;

namespace DataAccessLayer
{
   public class TriviaRepostitory
    {
        public List<Question> _questions = new List<Question>();

        public TriviaRepostitory()
        {
            
        }
        public static string GenerateUrl(int amount, int category,string difficulty, string type)
          {           
            StringBuilder buiilder = new StringBuilder();
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            buiilder.AppendFormat("https://opentdb.com/api.php?amount={0}&category={1}&difficulty={2}&type={3}", amount, category, difficulty, type);
            //buiilder.AppendFormat("<a href=\"https://opentdb.com/api.php?amount={0}&category={1}&difficulty={2}&type={3}\">Link</a>", amount, category, difficulty, type);
            return buiilder.ToString();
        }
          
        public List<Question> GetTriviaQA ()
        {
            string url = GenerateUrl(15,25,"medium","multiple");
            string json = CallRestMethod(url);



            JObject jsonObject = JObject.Parse(json);
            var oBooks = jsonObject["results"].ToList();
            for (int i = 0; i < oBooks.Count; i++)
            {
                _questions.Add(new Question
                {
                    Description = (string)oBooks[i]["question"]
                });
            }

            return _questions;
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
