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
    public class DeleteModel : PageModel
    {
        private readonly QuizDbContext _context;

        public DeleteModel(QuizDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Question q = await _context.Questions.FindAsync(id);

            if (q != null)
            {
                _context.Questions.Remove(q);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
