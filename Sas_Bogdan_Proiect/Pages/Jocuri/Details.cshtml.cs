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

namespace Sas_Bogdan_Proiect.Pages.Jocuri
{
    public class DetailsModel : PageModel
    {
        private readonly Sas_Bogdan_Proiect.Data.Sas_Bogdan_ProiectContext _context;

        public DetailsModel(Sas_Bogdan_Proiect.Data.Sas_Bogdan_ProiectContext context)
        {
            _context = context;
        }

        public Joc Joc { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Joc = await _context.Joc
                .Include(j => j.Gen).FirstOrDefaultAsync(m => m.ID == id);

            if (Joc == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
