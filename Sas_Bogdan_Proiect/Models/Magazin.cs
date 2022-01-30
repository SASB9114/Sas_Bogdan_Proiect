using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sas_Bogdan_Proiect.Models
{
    public class Magazin
    {
        public int ID { get; set; }
        public int JocID { get; set; }
        public Joc Joc { get; set; }
        [RegularExpression(@"^[0-9''-'\s]{3,40}$",
        ErrorMessage = "Doar cifrele sunt permise, min = 1, max = 40"), Required]
        public int Pret { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data Introducerii in Magazin")]
        public DateTime Data { get; set; } 
    }
}
