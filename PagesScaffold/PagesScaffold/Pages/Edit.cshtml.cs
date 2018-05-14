using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagesScaffold.Data;
using PagesScaffold.Models;

namespace PagesScaffold.Pages
{
    public class EditModel : PageModel
    {
        private readonly QuizDbContext _context;

        public EditModel(QuizDbContext context)
        {
            _context = context;
        }

        public Question Question { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Question = await _context.Questions.SingleOrDefaultAsync(m => m.Id == id);

            if (Question == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Question).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private bool QuestionExists(int id)
        {
            return _context.Questions.Any(e => e.Id == id);
        }
    }
}
