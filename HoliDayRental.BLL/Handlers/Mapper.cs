using System;
using System.Collections.Generic;
using System.Text;
using B = HoliDayRental.BLL.Entity;
using D = HoliDayRental.DAL.Entite;

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


        public static HoliDayRental.DAL.Entite.Options ToDAL(this HoliDayRental.BLL.Entity.Options entity)
        {
            if (entity == null) return null;
            return new D.Options
            {
                idOption = entity.idOption,
                Libelle = entity.Libelle
            };
        }
    }
}
