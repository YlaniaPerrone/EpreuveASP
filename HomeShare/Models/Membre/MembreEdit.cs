using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HoliDayRental.Models.Membre
{
    public class MembreEdit
    {
        [Required]
        [DisplayName("Nom")]
        public string Nom { get; set; }

        [Required]
        [DisplayName("Prenom")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "L'adresse email est obligatoire.")]
        [EmailAddress(ErrorMessage = "L'adresse n'est au bon format.")]
        [DisplayName("Adresse électronique : ")]
        public string Email { get; set; }

        // [Required]
        [DisplayName("PaysList")]
        public IEnumerable<Payss.Pays> PaysList { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public int Pays { get; set; }

        [Required(ErrorMessage = "entrez un bon num de tel")]
        [DisplayName("Telephone ")]
        public string Telephone { get; set; }

        [Required]
        // [RegularExpression(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\S+$).{8,20}$", ErrorMessage = "Uniquement du texte.")]
        [DisplayName("Login")]
        public string Login { get; set; }
        
        // [Required(ErrorMessage = "Le mot de passe est obligatoire.")]
        //any kind of letter from any language
        // [RegularExpression(@"\p{L}", ErrorMessage = "Le mot de passe doit au minimum un nombre, une minuscule, une majuscule, un caractère parmis '@#$%^&-+=()', aucun espace blanc, compris entre 8 et 20 caractères.")]
        [DataType(DataType.Password)]
        [DisplayName("Password ")]
        public string Password { get; set; }
       
    }
}
