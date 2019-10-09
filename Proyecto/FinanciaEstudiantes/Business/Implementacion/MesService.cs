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
    public class MesService : IMesService
    {
        private IMesRepository MesRepository = new MesRepository();

        public bool Delete(int? id)
        {
            return MesRepository.Delete(id);
        }

        public Mes FinByID(int? id)
        {
            return MesRepository.FindByID(id);
        }

        public List<Mes> FindAll()
        {
            return MesRepository.FindAll();
        }

        public bool Insert(Mes t)
        {
            return MesRepository.Insert(t);
        }

        public bool Update(Mes t)
        {
            return MesRepository.Update(t);
        }
    }
}
