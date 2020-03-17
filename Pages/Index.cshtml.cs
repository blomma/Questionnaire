using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Data;
using Models;

namespace Questionnaire.Pages {
    public class CreateModel : PageModel {
        private readonly Data.QuestionsContext _context;

        public CreateModel(Data.QuestionsContext context) {
            _context = context;
        }

        public IActionResult OnGet() {
            return Page();
        }

        [BindProperty]
        public Models.Questions questions { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Questions.Add(questions);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
