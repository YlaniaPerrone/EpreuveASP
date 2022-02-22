using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.BLL.Entity
{
    public class OptionsBien
    {
        public int idOption { get; set; }
        public int idBien { get; set; }
        public string Valeur { get; set; }
    
        public Options Options { get; set; }
        public BienEchange BienEchange { get; set; }

        public OptionsBien(int id_Option, int id_Bien, string valeur)
        {
            idOption = id_Option;
            idBien = id_Bien;
            Valeur = valeur;
            Options = null;
            BienEchange = null;

        }

        public OptionsBien(string valeur, Options options, BienEchange bienEchange)
        {

            Valeur = valeur;
            Options = options;
            idOption = options.idOption;
            BienEchange = bienEchange;
            idBien = bienEchange.idBien;


        }

    }
}
