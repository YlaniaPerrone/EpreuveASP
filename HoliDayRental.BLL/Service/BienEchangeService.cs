using HoliDayRental.BLL.Entity;
using HoliDayRental.BLL.Handlers;
using HoliDayRental.Common.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoliDayRental.BLL.Service

{
    public class BienEchangeService : IBienEchangeRepository<HoliDayRental.BLL.Entity.BienEchange>

    {
        private readonly IBienEchangeRepository<DAL.Entite.BienEchange> _BienEchangeRepository;
        public BienEchangeService(IBienEchangeRepository<DAL.Entite.BienEchange> repository)
        {
            _BienEchangeRepository = repository;
        }
        public void Delete(int id)
        {
            _BienEchangeRepository.Delete(id);
        }

        public BienEchange Get(int id)
        {
            return _BienEchangeRepository.Get(id).ToBLL();
        }

        public IEnumerable<BienEchange> Get()
        {
            return _BienEchangeRepository.Get().Select(c => c.ToBLL());

        }

        public int Insert(BienEchange entity)
        {
            return _BienEchangeRepository.Insert(entity.ToDALL());
        }

        public void Update(int id, BienEchange entity)
        {
            _BienEchangeRepository.Update(id, entity.ToDALL());
        }
    }
}