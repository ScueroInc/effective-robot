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
    public class IngresoService : IIngresoService
    {
        private IIngresoRepository objIngresoRepository = new IngresoRepository();
        public bool Delete(int? id)
        {
            return objIngresoRepository.Delete(id);
        }

        public Ingreso FindByID(int? id)
        {
            return objIngresoRepository.FindByID(id);
        }

        public List<Ingreso> FindAll()
        {
            return objIngresoRepository.FindAll();
        }

        public bool Insert(Ingreso t)
        {
            return objIngresoRepository.Insert(t);
        }

        public bool Update(Ingreso t)
        {
            return objIngresoRepository.Update(t);
        }
    }
}
