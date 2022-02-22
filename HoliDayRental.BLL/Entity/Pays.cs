using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.BLL.Entity
{
    public class Pays
    {
         public int idPays { get; set; }
        public string Libelle { get; set; }

        public Pays(int id_Pays, string libelle)
        {
            idPays = id_Pays;
            Libelle = libelle;          
        }
    }
}
