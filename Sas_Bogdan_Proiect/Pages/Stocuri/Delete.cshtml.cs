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

namespace Sas_Bogdan_Proiect.Pages.Stocuri
{
    public class DeleteModel : PageModel
    {
        private readonly Sas_Bogdan_Proiect.Data.Sas_Bogdan_ProiectContext _context;

        public DeleteModel(Sas_Bogdan_Proiect.Data.Sas_Bogdan_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Magazin Magazin { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Magazin = await _context.Magazin
                .Include(m => m.Joc).FirstOrDefaultAsync(m => m.ID == id);

            if (Magazin == null)
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

            Magazin = await _context.Magazin.FindAsync(id);

            if (Magazin != null)
            {
                _context.Magazin.Remove(Magazin);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
