using HoliDayRental.Common.Repository;
using HoliDayRental.DAL.Entite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Repository
{
    public class AvisMembreBienService : ConnectionBase, IAvisBienMembreRepository<AvisMembreBien>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public AvisMembreBien Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AvisMembreBien> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AvisMembreBien> GetByBienId(int bienEchange_id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AvisMembreBien> GetByMembreId(int membre_id)
        {
            throw new NotImplementedException();
        }

        public int Insert(AvisMembreBien entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, AvisMembreBien entity)
        {
            throw new NotImplementedException();
        }
    }
}
