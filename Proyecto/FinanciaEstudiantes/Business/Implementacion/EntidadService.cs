using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Implementation;
using Entity;

namespace Business.Implementation
{
    public class EntidadService : IEntidadService
    {
        private IEntidadRepository EntidadRepository = new EntidadRepository();

        public bool Delete(int? id)
        {
            return EntidadRepository.Delete(id);
        }

        public Entidad FinByID(int? id)
        {
            return EntidadRepository.FindByID(id);
        }

        public List<Entidad> FindAll()
        {
            return EntidadRepository.FindAll();
        }

        public bool Insert(Entidad t)
        {
            return EntidadRepository.Insert(t);
        }

        public bool Update(Entidad t)
        {
            return EntidadRepository.Update(t);
        }
    }
}
