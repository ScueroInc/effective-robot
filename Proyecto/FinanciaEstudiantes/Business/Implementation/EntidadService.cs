using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;
using Data.Implementation;

namespace Business.Implementation
{
    public class EntidadService : IEntidadService
    {
        private IEntidadRepository objEntidadRepository = new EntidadRepository();
        public bool Delete(int? id)
        {
            return objEntidadRepository.Delete(id);
        }

        public Entidad FindByID(int? id)
        {
            return objEntidadRepository.FindByID(id);
        }

        public List<Entidad> FindAll()
        {
            return objEntidadRepository.FindAll();
        }

        public bool Insert(Entidad t)
        {
            return objEntidadRepository.Insert(t);
        }

        public bool Update(Entidad t)
        {
            return objEntidadRepository.Update(t);
        }
    }
}
