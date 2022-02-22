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
                DescLong = entity.DescLong
            };
        }
    }
}
