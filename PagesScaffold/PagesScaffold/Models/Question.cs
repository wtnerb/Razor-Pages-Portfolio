using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagesScaffold.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string[] Answers { get; set; }
        public string CorrectAnswer { get; set; }
        //TODO uncomment and add features
        //public bool Calulate { get; set; }
        //public string[] Descriptive_Tags { get; set; }
    }
}
