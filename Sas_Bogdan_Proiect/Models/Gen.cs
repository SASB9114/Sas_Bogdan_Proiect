using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Sas_Bogdan_Proiect.Models
{
    public class Gen
    {
        public int ID { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9''-'\s]{3,40}$",
        ErrorMessage = "Doar literele si cifrele sunt permise, min = 3, max = 40"), Required]
        [Display(Name = "Nume Gen de Joc")]
        public string Nume { get; set; }
    }
}
