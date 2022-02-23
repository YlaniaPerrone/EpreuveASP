using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.Common.Repository
{
    public interface IGetRepository<TEntity, TId>
    {
        TEntity Get(TId id);    
        IEnumerable<TEntity> Get();
    }
}
