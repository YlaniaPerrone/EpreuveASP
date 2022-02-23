using HoliDayRental.BLL.Entity;
using HoliDayRental.BLL.Handlers;
using HoliDayRental.Common.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace HoliDayRental.BLL.Service
{
    public class PaysService : IPaysRepository<HoliDayRental.BLL.Entity.Pays> //IGetRepository<HoliDayRental.BLL.Entity.Pays, int> 
    {
        private readonly IPaysRepository<HoliDayRental.DAL.Entity.Pays> _repository;

        public PaysService(IPaysRepository<HoliDayRental.DAL.Entity.Pays> repository)
        {
            _repository = repository;
        }


        public Pays Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public IEnumerable<Pays> Get()
        {
            return _repository.Get().Select(p => p.ToBLL());
        }
        
    }
}
