#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sas_Bogdan_Proiect.Data;
using Sas_Bogdan_Proiect.Models;

namespace Sas_Bogdan_Proiect.Pages.Genuri
{
    public class CreateModel : PageModel
    {
        private readonly Sas_Bogdan_Proiect.Data.Sas_Bogdan_ProiectContext _context;

        public CreateModel(Sas_Bogdan_Proiect.Data.Sas_Bogdan_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Gen Gen { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Gen.Add(Gen);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
