using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.DAL.Repository
{
    public abstract class ConnectionBase
    {
        protected string _connString = @"Data Source=DESKTOP-2SOL3FP;Initial Catalog=HolyDayRental;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
