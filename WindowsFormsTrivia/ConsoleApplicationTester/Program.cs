using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Diagnostics;

namespace ConsoleApplicationTester
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var categoryRepo = new CategoryRepository();
            var categories = categoryRepo.GetAll();           
            foreach(var category in categories)
            {
                Console.WriteLine(category.Id +" " +category.CategoryName);
            }*/
          var categoryRepo = new TriviaRepostitory();
          var questions = categoryRepo.GetTriviaQA();           
          foreach(var question in questions)
          {
              Console.WriteLine(question.Description); 
              foreach( var answer in question.Answers)
                {
                    Console.WriteLine(answer.Description);
                    Console.WriteLine(answer.Correct);
                }
                Console.WriteLine();
          }

            Console.ReadKey();
        }
    }
}
