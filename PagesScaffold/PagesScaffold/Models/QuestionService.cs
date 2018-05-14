using Microsoft.EntityFrameworkCore;
using PagesScaffold.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagesScaffold.Models
{
    public class QuestionService : IQuestionService
    {
        private readonly QuizDbContext _context;

        public QuestionService()
        {
            var options = new DbContextOptionsBuilder<QuizDbContext>()
                .UseInMemoryDatabase("Quiz")
                .Options;
            _context = new QuizDbContext(options);
        }

        public QuestionService(QuizDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Deletes a question and removes it from all quizes that referenced it
        /// </summary>
        /// <param name="id">the question id</param>
        /// <returns>task</returns>
        public async Task DeleteAsync(int id)
        {
            Question target = await _context.Questions.FirstOrDefaultAsync(x => x.Id == id);
            if (target != null)
            {
                //Delete from all quizes that contain it
                //List<Quiz> quizs = await _context.Quizs.Where(x => x.QuizQuestions.Contains(id)).ToListAsync();
                //foreach (Quiz q in quizs)
                //{
                //    q.QuizQuestions.Remove(id);
                //    _context.Update(q);
                //}

                //Now that no quizes contain question, delete question
                _context.Questions.Remove(target);
                await _context.SaveChangesAsync();
                return;
            }
        }

        /// <summary>
        /// Given a quiz, will get a list of all the questions for that quiz
        /// </summary>
        /// <param name="quizId">Quiz id</param>
        /// <returns>List of questions belonging to that quiz</returns>
        public async Task<List<Question>> GetQuizAsync(int quizId)
        {
            return null;
        }
            //Quiz target = await _context.Quizs.FirstOrDefaultAsync(x => x.Id == quizId);
            //if (target == null)
            //    return null;
            //return await _context.Questions.Where(x => target.QuizQuestions.Contains(x.Id)).ToListAsync();

        /// <summary>
        /// Add a question to the database
        /// </summary>
        /// <param name="question">question</param>
        /// <returns></returns>
        public async Task AddQuestionAsync(Question question)
        {
            await _context.Questions.AddAsync(question);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Adds an already existing question to a quiz in the database
        /// </summary>
        /// <param name="quizId">target quiz</param>
        /// <param name="questionId">Question to be added</param>
        /// <returns></returns>
        public async Task AddQuestionToQuizAsync(int quizId, int questionId)
        {
            //Quiz q = await _context.Quizs.FirstOrDefaultAsync(x => x.Id == quizId);
            //q.QuizQuestions.Add(questionId);
            //_context.Update(q);
            //await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Finds a question in the database
        /// </summary>
        /// <param name="id">question id</param>
        /// <returns>null or question</returns>
        public async Task<Question> FindAsync(int id)
        {
            Question q = await _context.Questions.FirstOrDefaultAsync(x => x.Id == id);
            return q;
        }
    }
}
