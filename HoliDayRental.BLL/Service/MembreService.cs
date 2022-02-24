using HoliDayRental.BLL.Entity;
using HoliDayRental.Common.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HoliDayRental.BLL.Handlers;

namespace HoliDayRental.BLL.Service
{
    public class MembreService : IMembreRepository<HoliDayRental.BLL.Entity.Membre>
    {
        private readonly IMembreRepository<DAL.Entity.Membre> _membreRepository;
        // private readonly IPaysRepository<DAL.Entity.Membre> _paysRepository;

        public MembreService( IMembreRepository<DAL.Entity.Membre> repositoryMembre) //IBienEchangeRepository<DAL.Entity.BienEchange> repository, IPaysRepository<DAL.Entity.Pays> repositoryPays)
        {
            _membreRepository = repositoryMembre;
            // _bienEchangeRepository = repository;
            //_paysRepository = repositoryPays;
        }
        public void Delete(int id)
        {
            _membreRepository.Delete(id);
            
        }

        public Membre Get(int id)
        {
            return _membreRepository.Get(id).ToBLL();
        }

        public IEnumerable<Membre> Get()
        {
            return _membreRepository.Get().Select(d => d.ToBLL());
        }


        public int Insert(Membre entity)
        {
            return _membreRepository.Insert(entity.ToDALL());

        }

        public void Update(int id, Membre entity)
        {
            _membreRepository.Update(id, entity.ToDALL());
        }
    }
}
