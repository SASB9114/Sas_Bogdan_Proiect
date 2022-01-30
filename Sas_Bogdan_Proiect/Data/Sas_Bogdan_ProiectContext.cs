#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sas_Bogdan_Proiect.Models;

namespace Sas_Bogdan_Proiect.Data
{
    public class Sas_Bogdan_ProiectContext : DbContext
    {
        public Sas_Bogdan_ProiectContext (DbContextOptions<Sas_Bogdan_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Sas_Bogdan_Proiect.Models.Gen> Gen { get; set; }

        public DbSet<Sas_Bogdan_Proiect.Models.Joc> Joc { get; set; }

        public DbSet<Sas_Bogdan_Proiect.Models.Magazin> Magazin { get; set; }
    }
}
