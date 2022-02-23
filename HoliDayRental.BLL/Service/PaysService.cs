using Demo.CinemaProject.Common.Repositories;
using HoliDayRental.BLL.Handlers;
using HoliDayRental.DAL.Entite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoliDayRental.BLL.Service
{
    public class PaysService : IGetRepository<HoliDayRental.DAL.Entite.Pays, int>
    {
        private readonly IGetRepository<HoliDayRental.DAL.Entite.Pays, int> _repository;

        public PaysService(IGetRepository<HoliDayRental.DAL.Entite.Pays, int> repository)
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
