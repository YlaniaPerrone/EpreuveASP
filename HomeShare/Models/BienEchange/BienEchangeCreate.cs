using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HoliDayRental.Models.BienEchange
{
    public class BienEchangeCreate
    {
        [Key]
        [ScaffoldColumn(false)]
        public int idBien { get; set; }

        [Required]
        [DisplayName("Titre")]
        public string titre { get; set; }

        [Required]
        [DisplayName("DescCourte")]
        public string DescCourte { get; set; }
        [Required]
        [DisplayName("DescLong")]
        public string DescLong { get; set; }
        [Required]
        [DisplayName("NombrePerson")]
        public int NombrePerson { get; set; }
        [Required]

        //public IEnemurable<Pays> Pays { get; set; }
        public int Pays { get; set; }
        [Required]
        [DisplayName("Ville")]
        public string Ville { get; set; }
        [Required]
        [DisplayName("Rue")]
        public string Rue { get; set; }
        [Required]
        [DisplayName("Numero")]

        public string Numero { get; set; }
        [Required]
        [DisplayName("CodePostal")]

        public string CodePostal { get; set; }
        [Required]
        [DisplayName("Photo")]
        public string Photo { get; set; }
        [Required]
        [DisplayName("AssuranceObligatoire")]
        public bool AssuranceObligatoire { get; set; }
        [Required]
        [DisplayName("isEnabled")]
        public bool isEnabled { get; set; }
        
        public DateTime? DisabledDate { get; set; }
        [Required]
        [DisplayName("Latitude")]
        public string Latitude { get; set; }
        [Required]
        [DisplayName("Longitude")]
        public string Longitude { get; set; }
        [Required]
        [DisplayName("idMembre")]

        //[ScaffoldColumn(false)]

        public int idMembre { get; set; }

        public DateTime DateCreation { get; set; }
    }
}
