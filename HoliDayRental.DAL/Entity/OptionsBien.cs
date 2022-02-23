using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.DAL.Entity
{
    public class OptionsBien
    {
        public int idOption { get; set; }
        public int idBien { get; set; } 
        public string Valeur { get; set; }
    }
}
