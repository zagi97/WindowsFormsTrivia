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
        public List<Category> _categories = new List<Category>();
        public List<Difficulty> _difficulty = new List<Difficulty>();

        public TriviaRepostitory()
        {
            StreamReader oSr = new StreamReader("E:/Fakultet/RAC, 2.godina/III.Semestar/Programiranjeu.NETokolini2/Projekt/WindowsFormsTrivia/DataAccessLayer/kviz.json");
            string sJson = "";
            using (oSr)
            {
                sJson = oSr.ReadToEnd();
            }
            JObject oJson = JObject.Parse(sJson);


            var oPitanja = oJson["results"].ToList();

            for (int i = 0; i < oPitanja.Count; i++)
            {
                _categories.Add(new Category
                {
                    CategoryName = (string)oPitanja[i]["category"],
                });

                _difficulty.Add(new Difficulty
                {
                    DifficultyLevel = (string)oPitanja[i]["difficulty"]
                });

                _questions.Add(new Question
                {
                    Description = (string)oPitanja[i]["question"]
                });
            }
           
        }

        public List<string> GetCategories() // funkcija koja vraća listu stringova
        {
            var categories = _categories.Where(x => !string.IsNullOrEmpty(x.CategoryName)).Select(x => x.CategoryName).Distinct().OrderBy(x => x).ToList(); //DISTINCT->ZBOG TOGA DA NAM ISPIŠE JEDNOM EUROPA
            categories.Insert(0, "All");
            return categories;
        }

        public List<string> GetDifficulty() // funkcija koja vraća listu stringova
        {
            var difficulty = _difficulty.Where(x => !string.IsNullOrEmpty(x.DifficultyLevel)).Select(x => x.DifficultyLevel).Distinct().OrderBy(x => x).ToList(); //DISTINCT->ZBOG TOGA DA NAM ISPIŠE JEDNOM EUROPA
            difficulty.Insert(0, "All");
            return difficulty;
        }

        public List<string> GetQuestions() // funkcija koja vraća listu stringova
        {
            var question = _questions.Where(x => !string.IsNullOrEmpty(x.Description)).Select(x => x.Description).Distinct().OrderBy(x => x).ToList(); //DISTINCT->ZBOG TOGA DA NAM ISPIŠE JEDNOM EUROPA
            
            return question;
        }


        public List<Question> GetTriviaQA ()
        {
            StreamReader oSr = new StreamReader("E:/Fakultet/RAC, 2.godina/III.Semestar/Programiranjeu.NETokolini2/Projekt/WindowsFormsTrivia/DataAccessLayer/kviz.json");
            string sJson = "";
            using (oSr)
            {
                sJson = oSr.ReadToEnd();
            }
            JObject oJson = JObject.Parse(sJson);


            var oPitanja = oJson["results"].ToList();

            for (int i = 0; i < oPitanja.Count; i++)
            {
                //Kreirati praznu listu odgovora 
                //Kreirati novi objekt klase Answer i dodati ga u praznu listu odgovora
                List<Answer> answers = new List<Answer>();

                Answer correctAnswer = new Answer
                {
                    Description = (string)oPitanja[i]["correct_answer"],
                    Correct = true
                };
                answers.Add(correctAnswer);

                Answer incorrectAnswer1 = new Answer
                {
                    Description = (string)oPitanja[i]["incorrect_answers"][0],
                    Correct = false
                };
                answers.Add(incorrectAnswer1);

                Answer incorrectAnswer2 = new Answer
                {
                    Description = (string)oPitanja[i]["incorrect_answers"][1],
                    Correct = false
                };
                answers.Add(incorrectAnswer2);

                Answer incorrectAnswer3 = new Answer
                {
                    Description = (string)oPitanja[i]["incorrect_answers"][2],
                    Correct = false
                };
                answers.Add(incorrectAnswer3);

                _questions.Add(new Question
                {
                    Description = (string)oPitanja[i]["question"],
                    Answers = answers
                });
            }
            return _questions;

        }        
    }
}
