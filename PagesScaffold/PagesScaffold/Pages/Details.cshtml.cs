using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PagesScaffold.Data;
using PagesScaffold.Models;
using PagesScaffold.Models.ViewModels;

namespace PagesScaffold.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly QuizDbContext _context;

        public DetailsModel(QuizDbContext context)
        {
            _context = context;
        }

        public QuestionVm Question { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Question q = await _context.Questions.SingleOrDefaultAsync(m => m.Id == id);

            if (q == null)
            {
                return NotFound();
            }
            Question = new QuestionVm(q);
            return Page();
        }
    }
}
