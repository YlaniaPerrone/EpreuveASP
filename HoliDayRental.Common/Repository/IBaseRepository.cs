using Demo.CinemaProject.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.Common.Repository
{
    public interface IBaseRepository<TEntite> : IRepository<TEntite, int>, IGetRepository<TEntite, int>
    {
    }
}
