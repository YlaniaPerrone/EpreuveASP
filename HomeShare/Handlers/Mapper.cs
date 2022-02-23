using HoliDayRental.Models;
namespace HoliDayRental.Handlers
{
    public static class Mapper
    {
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
                Latitude = entity.Latitude,
                Longitude = entity.Longitude,
                idMembre =  entity.idMembre,
                DateCreation = entity.DateCreation,
            };
        }
    }
}
