using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace ConsoleApplicationTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var categoryRepo = new CategoryRepository();
            string categories = categoryRepo.GetCategory();           
            foreach(var category in categories)
            {
                Console.WriteLine(category.CategoryName);
            }
            Console.ReadKey();
        }
    }
}
