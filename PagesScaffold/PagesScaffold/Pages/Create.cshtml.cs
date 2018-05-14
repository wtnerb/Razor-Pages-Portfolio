using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PagesScaffold.Data;
using PagesScaffold.Models;

namespace PagesScaffold.Pages
{
    public class CreateModel : PageModel
    {
        private readonly QuizDbContext _context;

        public CreateModel(QuizDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Question Question { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Questions.Add(Question);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}