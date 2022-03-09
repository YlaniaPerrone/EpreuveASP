using HoliDayRental.Models.BienEchange;
using HoliDayRental.Models.Membre;
using HoliDayRental.Models.Payss;

namespace HoliDayRental.Handlers
{
    public static class Mapper
    {

        //bien
        public static BienEchangeItem ToListItem(this HoliDayRental.BLL.Entity.BienEchange entity )
        {
            if (entity == null) return null;
            return new BienEchangeItem
            {
                idBien = entity.idBien,
                titre = entity.titre,
                DescCourte = entity.DescCourte,
                DescLong = entity.DescLong,
                NombrePerson = entity.NombrePerson,
                idPays = entity.idPays,
                Ville = entity.Ville,
                Rue = entity.Rue,
                Numero = entity.Numero,
                CodePostal =  entity.CodePostal,
                Photo = entity.Photo,
                AssuranceObligatoire = entity.AssuranceObligatoire,
                isEnabled = entity.isEnabled,
                DisabledDate = entity.DisabledDate,
                DateCreation = entity.DateCreation,
                Latitude = entity.Latitude,
                Longitude = entity.Longitude,
                idMembre =  entity.idMembre,
            };
        }
        
        
        public static BienDetails ToDetails(this HoliDayRental.BLL.Entity.BienEchange entity)
        {
            if (entity == null) return null;
            return new BienDetails
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
                Latitude = entity.Latitude,
                Longitude = entity.Longitude
        
            };
        }
        
        public static BienEdit ToBienEdit(this HoliDayRental.BLL.Entity.BienEchange entity)
        {
            if (entity == null) return null;
            return new BienEdit
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
                // Photo = entity.Photo,
                isEnabled = entity.isEnabled,
                DisabledDate = entity.DisabledDate,
                AssuranceObligatoire = entity.AssuranceObligatoire,
                Latitude = entity.Latitude,
                Longitude = entity.Longitude
              
            };
        }

        //Membre
        public static MembreItem ToListMembre(this HoliDayRental.BLL.Entity.Membre entity)
        {
            if (entity == null) return null;
            return new MembreItem
            {
               idMembre = entity.idMembre,
               Nom = entity.Nom,
               Prenom = entity.Prenom,
                idPays = entity.idPays
                // Email = entity.Email,
                // Telephone = entity.Telephone,
                // Login = entity.Login,
                // Password = entity.Password

            };
        }
        public static MembreEdit ToEditMembre(this HoliDayRental.BLL.Entity.Membre entity)
        {
            if (entity == null) return null;
            return new MembreEdit
            {
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                Telephone = entity.Telephone,
                Pays = entity.idPays,
                Login = entity.Login,
                Password = entity.Password

            };
        }

        public static MembreDetails ToDtailsMembre(this HoliDayRental.BLL.Entity.Membre entity)
        {
            if (entity == null) return null;
            return new MembreDetails
            {
                idMembre = entity.idMembre,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                Telephone = entity.Telephone,
                idPays = entity.idPays,
            };
        }
        
        //Pays
        public static Pays ToListPays(this HoliDayRental.BLL.Entity.Pays entity)
        {
            if (entity == null) return null;
            return new Pays
            {
                idPays = entity.idPays,
                Libelle = entity.Libelle
            };
        }


    }
}
