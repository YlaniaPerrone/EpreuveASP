using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HoliDayRental.Models.Membre
{
    public class MembreCreate
    {
        [ScaffoldColumn(false)]
        [Key]
        public int idMembre { get; set; }
        [Required]
        [DisplayName("Nom")]
        public string Nom { get; set; }
        [Required]
        [DisplayName("Prenom")]
        public string Prenom { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "L'adresse n'est au bon format.")]
        [DisplayName("Email")]
        public string Email { get; set; }
        public int Pays { get; set; }
        [Required]
        [DisplayName("Telephone")]
        public string Telephone { get; set; }
        [Required]
        [DisplayName("Login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Le mot de passe est obligatoire.")]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\S+$).{8,20}$", ErrorMessage = "Le mot de passe doit au minimum un nombre, une minuscule, une majuscule, un caractère parmis '@#$%^&-+=()', aucun espace blanc, compris entre 8 et 20 caractères.")]
        [DataType(DataType.Password)]
        [DisplayName("Mot de passe : ")]
        public string Password { get; set; }
    }
}
