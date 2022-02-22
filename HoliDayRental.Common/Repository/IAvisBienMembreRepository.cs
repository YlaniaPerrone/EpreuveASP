using Demo.CinemaProject.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.Common.Repository
{
    public interface IAvisBienMembreRepository<TAvisBienMembre> : IRepository<TAvisBienMembre, int>
    {
        public IEnumerable<TAvisBienMembre> GetByMembreId(int membre_id);
        public IEnumerable<TAvisBienMembre> GetByBienId(int bienEchange_id);
    }
}
