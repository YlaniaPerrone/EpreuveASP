using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HoliDayRental.Models.Membre
{
    public class MembreItem
    {
        [ScaffoldColumn(false)]
        [Key]
        public int idMembre { get; set; }
        
        [DisplayName("Nom")]
        public string Nom { get; set; }
        
        [DisplayName("Prenom")]
        public string Prenom { get; set; }
        
        [ScaffoldColumn(false)]
        public int idPays { get; set; }
        
        // [ScaffoldColumn(false)]
        public Payss.Pays PaysList { get; set; }

    }
}
