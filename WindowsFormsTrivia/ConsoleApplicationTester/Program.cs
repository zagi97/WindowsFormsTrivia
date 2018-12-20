﻿using System;
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
          var categories = categoryRepo.GetTriviaQA();           
          foreach(var category in categories)
          {
              Console.WriteLine(category.Description);
          }

            Console.ReadKey();
        }
    }
}
