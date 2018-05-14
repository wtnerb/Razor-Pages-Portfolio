using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagesScaffold.Models
{
    interface IQuestionService
    {
        Task DeleteAsync(int id);
        Task<List<Question>> GetQuizAsync(int quizId);
        Task AddQuestionAsync(Question question);
        Task AddQuestionToQuizAsync(int quizId, int questionId);
        Task<Question> FindAsync(int id);
    }
}
