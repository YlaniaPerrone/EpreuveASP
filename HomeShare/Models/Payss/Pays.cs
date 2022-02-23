using System.ComponentModel.DataAnnotations;

namespace HoliDayRental.Models.Payss
{
    public class Pays
    {
        [ScaffoldColumn(false)]
        [Key]
        public int idPays { get; set; }
        public string Libelle { get; set; }
    }
}
