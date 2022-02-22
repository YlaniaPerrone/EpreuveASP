using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.BLL.Entity
{
    public class BienEchange
    {
        public int idBien { get; set; }
        public string titre { get; set; }
        public string DescCourte { get; set; }
        public string DescLong { get; set; }

        public int NombrePerson { get; set; }
        public int Pays { get; set; }
        public string Ville { get; set; }
        public string Rue { get; set; }

        public string Numero { get; set; }

        public string CodePostal { get; set; }
        public string Photo { get; set; }
        public bool AssuranceObligatoire { get; set; }
        public bool isEnabled { get; set; }
        public DateTime? DisabledDate { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int idMembre { get; set; }
        public DateTime DateCreation { get; set; }

        //public Membre Membre { get; set; }
        //public  Pays Pays { get; set; }

//        public BienEchange(int id_bien, string title, string descCourte, string descLong, int nombrePerson, int pays, string ville, string rue, string numero, string codePostal, string photo, bool assuranceObligatoire, bool is_Enabled, DateTime? disabledDate, string latitude, string longitude, int id_Membre, DateTime dateCreation
//)
//        {
//            idBien = id_bien;
//            titre = title;
//            DescCourte = descCourte;
//            DescLong = descLong;
//            NombrePerson = nombrePerson;
//            Pays = pays;
//            Ville = ville;
//            Rue = rue;
//            Numero = numero;
//            CodePostal = codePostal;
//            Photo = photo;  
//            AssuranceObligatoire = assuranceObligatoire;
//            isEnabled = is_Enabled;
//            DisabledDate = disabledDate;
//            Latitude = latitude;
//            Longitude = longitude;
//            idMembre = id_Membre;
//            DateCreation = dateCreation;
//            Membre = null;

//        }
    
    }
}
