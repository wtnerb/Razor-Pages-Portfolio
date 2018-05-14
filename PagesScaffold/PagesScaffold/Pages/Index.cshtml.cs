using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PagesScaffold.Data;
using PagesScaffold.Models;

namespace PagesScaffold.Pages
{
    public class IndexModel : PageModel
    {
        private readonly QuizDbContext _context;

        public IndexModel(QuizDbContext context)
        {
            _context = context;
        }

        public IList<Question> Question { get;set; }

        public async Task OnGetAsync()
        {
            Question = await _context.Questions.ToListAsync();
        }
    }
}
