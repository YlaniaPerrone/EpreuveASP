﻿using System.ComponentModel.DataAnnotations;

namespace HoliDayRental.Models.Membre
{
    public class MembreItem
    {
        [ScaffoldColumn(false)]
        [Key]
        public int idMembre { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
       
    }
}
