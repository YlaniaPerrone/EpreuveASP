using System.ComponentModel.DataAnnotations;
using HoliDayRental.Models.Payss;

namespace HoliDayRental.Models.Membre
{
    public class MembreDetails
    {
        [ScaffoldColumn(false)]
        [Key]
        public int idMembre { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public int idPays { get; set; }
        public Pays Pays { get; set; }
        public string Telephone { get; set; }
      
    }
}
