using Microsoft.EntityFrameworkCore;
using PagesScaffold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagesScaffold.Data
{
    public class QuizDbContext : DbContext
    {
        public DbSet<Question> Questions {get; set;}
        //public DbSet<Quiz> Quizs { get; set; }

        public QuizDbContext (DbContextOptions<QuizDbContext> options) : base (options)
        {

        }
    }
}
