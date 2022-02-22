﻿using HoliDayRental.DAL.Entite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HoliDayRental.DAL.Handler
{
    public static class Mapper
    {
        public static Options ToOption(IDataRecord record)
        {
            if (record is null) return null;
            return new Options
            {
                idOption = (int)record[nameof(Options.idOption)],
                Libelle = (string)record[nameof(Options.Libelle)]
            };
        }

        public static OptionsBien ToOptionBien(IDataRecord record)
        {
            if (record is null) return null;
            return new OptionsBien
            {
                idBien = (int)record[nameof(OptionsBien.idBien)],
                idOption = (int)record[nameof(OptionsBien.idOption)],
                Valeur = (string)record[nameof(OptionsBien.Valeur)]
               
            };
        }

        public static Membre ToMembre(IDataRecord record)
        {
            if (record is null) return null;
            return new Membre
            {
                idMembre = (int)record[nameof(Membre.idMembre)],
                Nom = (string)record[nameof(Membre.Nom)],
                Prenom = (string)record[nameof(Membre.Prenom)],
                Email = (string)record[nameof(Membre.Email)],
                Telephone = (string)record[nameof(Membre.Telephone)],
                Pays = (int)record[nameof(Membre.Pays)],
                Login = (string)record[nameof(Membre.Login)],
                Password = (string)record[nameof(Membre.Password)]
            };
        }

        public static BienEchange ToBienEchange(IDataRecord record)
        {

            if (record is null) return null;
            return new BienEchange
            {
                idBien = (int)record[nameof(BienEchange.idBien)],
                titre = (string)record[nameof(BienEchange.titre)],
                DescCourte = (string)record[nameof(BienEchange.DescCourte)],
                DescLong = (string)record[nameof(BienEchange.DescLong)],
                NombrePerson = (int)record[nameof(BienEchange.NombrePerson)],
                Pays = (int)record[nameof(BienEchange.Pays)],
                Ville = (string)record[nameof(BienEchange.Ville)],
                Rue = (string)record[nameof(BienEchange.Rue)],
                Numero = (string)record[nameof(BienEchange.Numero)],
                CodePostal = (string)record[nameof(BienEchange.CodePostal)],
                Photo = (string)record[nameof(BienEchange.Photo)],
                AssuranceObligatoire = (bool)record[nameof(BienEchange.AssuranceObligatoire)],
                isEnabled   = (bool)record[nameof(BienEchange.isEnabled)],
                DisabledDate = (record[nameof(BienEchange.DisabledDate)] == DBNull.Value) ? null : (DateTime)record[nameof(BienEchange.DisabledDate)],
                Latitude = (string)record[nameof(BienEchange.Latitude)],
                Longitude = (string)record[nameof(BienEchange.Longitude)],
                idMembre = (int)record[nameof(BienEchange.idMembre)],
                DateCreation = (DateTime)record[nameof(BienEchange.DateCreation)],
            };
        }

        public static MembreBienEchange ToMembreBienEchange(IDataRecord record)
        {
            if (record is null) return null;
            return new MembreBienEchange
            {
                idMembre = (int)record[nameof(MembreBienEchange.idMembre)],
                idBien = (int)record[nameof(MembreBienEchange.idBien)],
                DateDebEchange = (DateTime)record[nameof(MembreBienEchange.DateDebEchange)],
                DateFinEchange = (DateTime)record[nameof(MembreBienEchange.DateDebEchange)],
                Assurance = (record[nameof(MembreBienEchange.Assurance)] == DBNull.Value) ? null : (bool)record[nameof(MembreBienEchange.Assurance)],
                Valide = (bool)record[nameof(MembreBienEchange.Valide)],


            };
        }
    }
}