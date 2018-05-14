using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagesScaffold.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> QuizQuestions { get; set; }
    }
}
