using System;
using System.Collections.Generic;
using System.Text;
using B = HoliDayRental.BLL.Entity;
using D = HoliDayRental.DAL.Entity;

namespace HoliDayRental.BLL.Handlers
{
    public static class Mapper
    {
        public static B.Options ToBLL(this D.Options entity)
        {
            if (entity == null) return null;
            return new B.Options(
                entity.idOption,
                entity.Libelle
            );
        }


        public static HoliDayRental.DAL.Entity.Options ToDAL(this HoliDayRental.BLL.Entity.Options entity)
        {
            if (entity == null) return null;
            return new D.Options
            {
                idOption = entity.idOption,
                Libelle = entity.Libelle
            };
        }

        public static B.BienEchange ToBLL(this D.BienEchange entity)
        {
            if (entity == null) return null;
            return new B.BienEchange(
                entity.idBien,
                entity.titre,
                entity.DescCourte,
                entity.DescLong,
                entity.NombrePerson,
                entity.Pays,
                entity.Ville,
                entity.Rue,
                entity.Numero,
                entity.CodePostal,
                entity.Photo,
                entity.AssuranceObligatoire,
                entity.isEnabled,
                entity.DisabledDate,
                entity.Latitude,
                entity.Longitude,
                entity.idMembre,
                entity.DateCreation
            );
        }

        public static D.BienEchange ToDALL(this B.BienEchange entity)
        {
            if (entity == null) return null;
            return new D.BienEchange
            {
                idBien = entity.idBien,
                titre = entity.titre,
                DescCourte = entity.DescCourte,
                DescLong = entity.DescLong,
                NombrePerson = entity.NombrePerson,
                Pays = entity.idPays,
                Ville = entity.Ville,
                Rue = entity.Rue,
                Numero = entity.Numero,
                CodePostal = entity.CodePostal,
                Photo = entity.Photo,
                AssuranceObligatoire = entity.AssuranceObligatoire,
                isEnabled = entity.isEnabled,
                DisabledDate = entity.DisabledDate,
                DateCreation = entity.DateCreation,
                Latitude = entity.Latitude,
                Longitude = entity.Longitude,
                idMembre = entity.idMembre
            };
        }

        public static B.Membre ToBLL(this D.Membre entity)
        {
            if (entity == null) return null;
            return new B.Membre
            {
                idMembre = entity.idMembre,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                Telephone = entity.Telephone,
                Login = entity.Login,
                Password = entity.Password,
                idPays = entity.Pays
            };
        }

        public static D.Membre ToDALL(this B.Membre entity)
        {
            if (entity == null) return null;
            return new D.Membre
            {
                idMembre = entity.idMembre,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                Telephone = entity.Telephone,
                Login = entity.Login,
                Password = entity.Password,
                Pays = entity.idPays
            };
        }

        public static B.Pays ToBLL(this D.Pays entity)
        {
            if (entity == null) return null;
            return new B.Pays
            {
                idPays = entity.idPays,
                Libelle = entity.Libelle
            };
        }

        public static D.Pays ToDALL(this B.Pays entity)
        {
            if (entity == null) return null;
            return new D.Pays
            {
                idPays = entity.idPays,
                Libelle = entity.Libelle
            };
        }
    }
}