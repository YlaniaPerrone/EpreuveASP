// using HoliDayRental.BLL.Entity;
// using HoliDayRental.BLL.Handlers;
// using HoliDayRental.Common.Repository;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
//
// namespace HoliDayRental.BLL.Service
//
// {
//     public class BienEchangeService : IBienEchangeRepository<HoliDayRental.BLL.Entity.BienEchange>
//
//     {
//         private readonly IBienEchangeRepository<DAL.Entity.BienEchange> _bienEchangeRepository;
//         private readonly IMembreRepository<DAL.Entity.Membre> _membreRepository;
//         //private readonly IPaysRepository<DAL.Entity.Pays> _paysRepository;
//         public BienEchangeService(IBienEchangeRepository<DAL.Entity.BienEchange> repository, IMembreRepository<DAL.Entity.Membre> repositoryMembre) //IPaysRepository<DAL.Entity.Pays> repositoryPays)
//         {
//             _bienEchangeRepository = repository;
//             _membreRepository = repositoryMembre;
//             //_paysRepository = repositoryPays;
//         }
//         public void Delete(int id)
//         {
//             _bienEchangeRepository.Delete(id);
//         }
//
//         public BienEchange Get(int id)
//         {
//             return _bienEchangeRepository.Get(id).ToBLL();
//         }
//
//         public IEnumerable<BienEchange> Get()
//         {
//           
//             return _bienEchangeRepository.Get().Select(b => {
//                 BienEchange result = b.ToBLL();
//                 result.Membre = _membreRepository.Get(result.idMembre).ToBLL();
//                 //result.Pays = _paysRepository.Get(result.idPays).ToBLL();
//                 return result;
//             });
//         }
//
//         
//         public int Insert(BienEchange entity)
//         {
//             return _bienEchangeRepository.Insert(entity.ToDALL());
//         }
//
//         public void Update(int id, BienEchange entity)
//         {
//             _bienEchangeRepository.Update(id, entity.ToDALL());
//         }
//
//         public IEnumerable<BienEchange> Get5LastPropretyAdded()
//         {
//             return _bienEchangeRepository.Get().Select(d => d.ToBLL());
//         }
//     }
// }