﻿using System;
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

        public Pays Pays { get; set; }
        public Membre Membre { get; set; }


        public BienEchange(int id, string title, string descCourte, string descLong, int nbrePerson,  string ville, string rue, string num, string codePostal, string photo, bool assurance, string latitude, string longitude, DateTime dateCreation, Pays pays, Membre membre)
        {
            idBien = id;
            titre = title;
            DescCourte = descCourte;
            DescLong = descLong;
            NombrePerson = nbrePerson;
            Pays = pays;
            Ville = ville;
            Rue = rue;
            Numero = num;
            CodePostal = codePostal;
            Photo = photo;
            AssuranceObligatoire = assurance;
            Latitude = latitude;
            Longitude = longitude;
            DateCreation = dateCreation;
            Membre = membre;
            if (pays == null) throw new ArgumentNullException(nameof(idPays));
            idPays = pays.idPays;
            if (membre == null) throw new ArgumentNullException(nameof(idMembre));
            idMembre = membre.idMembre;
        }

        public BienEchange(int id, string title, string descCourte, string descLong, int nbrePerson, int Id_pays, string ville, string rue, string num, string codePostal, string photo, bool assurance, string latitude, string longitude, int id_membre, DateTime dateCreation)
        {
            idBien = id;
            titre = title;
            DescCourte = descCourte;
            DescLong = descLong;
            NombrePerson = nbrePerson;
            Ville = ville;
            Rue = rue;
            Numero = num;
            CodePostal = codePostal;
            Photo = photo;
            AssuranceObligatoire = assurance;
            Latitude = latitude;
            Longitude = longitude;
             DateCreation = dateCreation;
            idPays = Id_pays;
            idMembre = id_membre;
           // Membre = null;
           // Pays = null;
        }


    }
}
