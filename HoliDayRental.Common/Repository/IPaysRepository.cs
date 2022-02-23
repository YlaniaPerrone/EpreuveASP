﻿using Demo.CinemaProject.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.Common.Repository
{
    public  interface IPaysRepository<TEntite> : IGetRepository<TEntite, int>
    {
    }
}
