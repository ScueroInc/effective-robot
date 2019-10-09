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
    public class MesService : IMesService
    {
        private IMesRepository objMesRepository = new MesRepository();
        public bool Delete(int? id)
        {
            return objMesRepository.Delete(id);
        }

        public Mes FindByID(int? id)
        {
            return objMesRepository.FindByID(id);
        }

        public List<Mes> FindAll()
        {
            return objMesRepository.FindAll();
        }

        public bool Insert(Mes t)
        {
            return objMesRepository.Insert(t);
        }

        public bool Update(Mes t)
        {
            return objMesRepository.Update(t);
        }
    }
}
