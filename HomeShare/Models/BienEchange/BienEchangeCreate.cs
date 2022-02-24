using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using HoliDayRental.Models.Membre;

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
        
        [ScaffoldColumn(false)]
      public int idPays { get; set; }

        [ScaffoldColumn(false)]
        public IEnumerable<Payss.Pays> PaysList { get; set; }


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
        [MaxLength(6)]
        [DisplayName("CodePostal")]
        public string CodePostal { get; set; }
        
        [Required]
        [DisplayName("Photo")]
        public string Photo { get; set; }
        [Required]
        [DisplayName("AssuranceObligatoire")]
        public bool AssuranceObligatoire { get; set; }
        [ScaffoldColumn(false)]
        public bool isEnabled { get; set; }
        
        [DataType(DataType.Date)]

        public DateTime? DisabledDate { get; set; }
        [Required]
        [DisplayName("Latitude")]
        public string Latitude { get; set; }
        [Required]
        [DisplayName("Longitude")]
        public string Longitude { get; set; }
        [Required]
        [DisplayName("idMembre")]

        [ScaffoldColumn(false)]
        public int idMembre { get; set; }

        [ScaffoldColumn(false)]
        public IEnumerable<MembreItem> listMembre { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        public DateTime DateCreation { get; set; }
    }
}
