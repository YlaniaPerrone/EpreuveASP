using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.BLL.Entity
{
    public class Options
    {
        public int idOption { get; set; }
        public string Libelle { get; set; }

        public Options(int id, string libelle)
        {
            idOption = id;
            Libelle = libelle;  
        }
    }
}
