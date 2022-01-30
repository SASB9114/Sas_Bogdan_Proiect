#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sas_Bogdan_Proiect.Data;
using Sas_Bogdan_Proiect.Models;

namespace Sas_Bogdan_Proiect.Pages.Genuri
{
    public class DeleteModel : PageModel
    {
        private readonly Sas_Bogdan_Proiect.Data.Sas_Bogdan_ProiectContext _context;

        public DeleteModel(Sas_Bogdan_Proiect.Data.Sas_Bogdan_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Gen Gen { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gen = await _context.Gen.FirstOrDefaultAsync(m => m.ID == id);

            if (Gen == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gen = await _context.Gen.FindAsync(id);

            if (Gen != null)
            {
                _context.Gen.Remove(Gen);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
