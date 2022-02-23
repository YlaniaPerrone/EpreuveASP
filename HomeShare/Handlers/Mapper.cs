using HoliDayRental.Models.BienEchange;
using HoliDayRental.Models.Membre;

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
                Pays = entity.idPays,
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

        public static BienEchangeCreate ToCreate(this HoliDayRental.BLL.Entity.BienEchange entity)
        {
            if (entity == null) return null;
            return new BienEchangeCreate
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
                Latitude = entity.Latitude,
                Longitude = entity.Longitude,
                idMembre = entity.idMembre,
                DateCreation = entity.DateCreation,
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
               Email = entity.Email,
               Telephone = entity.Telephone,
               //Pays = entity.Pays,
               Login = entity.Login,
               Password = entity.Password
               
            };
        }



    }
}
