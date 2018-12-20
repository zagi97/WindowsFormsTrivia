using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Question
    {
        public string Description { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
