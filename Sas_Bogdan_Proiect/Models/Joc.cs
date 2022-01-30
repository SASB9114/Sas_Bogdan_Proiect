using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sas_Bogdan_Proiect.Models
{
    public class Joc
    {
        public int ID { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9''-'\s]{3,40}$",
        ErrorMessage = "Doar literele si cifrele sunt permise, min = 3, max = 40"), Required]
        [Display(Name = "Nume de Joc")]
        public string Nume  { get; set; }
        public int GenID { get; set; }
        public Gen Gen { get; set; }

    }
}
