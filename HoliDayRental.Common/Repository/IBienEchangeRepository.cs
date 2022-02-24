
using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.Common.Repository
{
    public interface IBienEchangeRepository<TBienEchange> : IRepository<TBienEchange, int>
    {
        //public IEnumerable<TBienEchange> GetBienDyspo(bool isEnabled);
         IEnumerable<TBienEchange> Get5LastPropretyAdded();



    }
}
