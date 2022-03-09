// using System;
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.ComponentModel.DataAnnotations;
//
// namespace HoliDayRental.Models.BienEchange
// {
//     public class BienEdit
//     {
//         [ScaffoldColumn(false)]
//         [Key]
//         public int idBien { get; set; }
//         [Required]
//         [DisplayName("titre")]
//         public string titre { get; set; }
//         [Required]
//         [DisplayName("DescCourte")]
//         public string DescCourte { get; set; }
//         [Required]
//         [DisplayName("DescLong")]
//         public string DescLong { get; set; }
//         [Required]
//         [DisplayName("NombrePerson")]
//         public int NombrePerson { get; set; }
//         [Required]
//         [DisplayName("PaysList")]
//         public IEnumerable<Payss.Pays> PaysList { get; set; }
//         [Required]
//         [ScaffoldColumn(false)]
//         public int Pays { get; set; }
//         [Required]
//         [DisplayName("Ville")]
//         public string Ville { get; set; }
//         [Required]
//         [DisplayName("Rue")]
//         public string Rue { get; set; }
//         [Required]
//         [DataType(DataType.PhoneNumber)]
//         [DisplayName("Numero")]
//         public string Numero { get; set; }
//         [Required]
//         [DisplayName("CodePostal")]
//         public string CodePostal { get; set; }
//         // [Required]
//         // [DisplayName("Photo")]
//         // public string Photo { get; set; }
//         [Required]
//         [DisplayName("AssuranceObligatoire")]
//         public bool AssuranceObligatoire { get; set; }
//         [Required]
//         [DisplayName("isEnabled")]
//         public bool isEnabled { get; set; }
//         [DataType(DataType.Date)]
//         [DisplayName("DisabledDate")]
//         public DateTime? DisabledDate { get; set; }
//         [Required]
//         [DisplayName("Latitude")]
//         public string Latitude { get; set; }
//         [Required]
//         [DisplayName("Longitude")]
//         public string Longitude { get; set; }
//     }
// }
