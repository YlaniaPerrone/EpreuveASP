using System.ComponentModel.DataAnnotations;

namespace HoliDayRental.Models.Membre
{
    public class MembreItem
    {
        [ScaffoldColumn(false)]
        [Key]
        public int idMembre { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int idPays { get; set; }
        public string Telephone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
