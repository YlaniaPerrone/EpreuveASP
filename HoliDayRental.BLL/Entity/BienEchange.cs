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
        public int idPays { get; set; }
        public Pays Pays { get; set; }

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
        public Membre Membre { get; set; }

        public DateTime DateCreation { get; set; }



        public BienEchange(int id, string title, string descCourte, string descLong, int nbrePerson, Pays pays, string ville, string rue, string numero, string codePostale, string photo, bool assurance, bool enabed, DateTime? dateDisable, string latitude, string longitude, Membre membre, DateTime date)
        {
           
            idBien = id;
            titre = title;
            DescCourte = descCourte;
            DescLong = descLong;
            NombrePerson = nbrePerson;
            Pays = pays;
            if (pays == null) throw new ArgumentNullException(nameof(idPays));
            idPays = pays.idPays;
            Ville = ville;
            Rue = rue;
            Numero = numero;
            CodePostal = codePostale;
            Photo = photo;
            AssuranceObligatoire = assurance;
            isEnabled = enabed;
            DisabledDate = dateDisable;
            Latitude = latitude;
            Longitude = longitude;
            Membre = membre;
            if (membre == null) throw new ArgumentNullException(nameof(idMembre));
            idMembre = membre.idMembre;
            DateCreation = date;
       
        }

        public BienEchange(int id, string title, string descCourte, string descLong, int nbrePerson, int Id_pays, string ville, string rue, string numero, string codePostale, string photo, bool assurance, bool enabed, DateTime? dateDisable, string latitude, string longitude, int id_membre, DateTime date)
        {

           idBien = id;
            titre = title;
            DescCourte = descCourte;
            DescLong = descLong;
            NombrePerson = nbrePerson;
            idPays = Id_pays;
            Ville = ville;
            Rue = rue;
            Numero = numero;
            CodePostal = codePostale;
            Photo = photo;
            AssuranceObligatoire = assurance;
            isEnabled = enabed;
            DisabledDate = dateDisable;
            Latitude = latitude;
            Longitude = longitude;
            idMembre = id_membre;
            DateCreation = date;

        }

       
    }
}
