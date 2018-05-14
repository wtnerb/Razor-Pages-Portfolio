using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagesScaffold.Models.ViewModels
{
    public class QuestionVm
    {
        public QuestionVm (Models.Question question)
        {
            Text = question.Text;
            Answers = question.AnswersCSV.Split(',');
            Answer = "";
            Id = question.Id;
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }
        public string[] Answers { get; set; }
    }
}
