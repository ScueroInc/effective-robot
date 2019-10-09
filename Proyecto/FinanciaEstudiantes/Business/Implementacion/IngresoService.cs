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
    public class IngresoService : IIngresoService
    {
        private IIngresoRepository IngresoRepository = new IngresoRepository();

        public bool Delete(int? id)
        {
            return IngresoRepository.Delete(id);
        }

        public Ingreso FinByID(int? id)
        {
            return IngresoRepository.FindByID(id);
        }

        public List<Ingreso> FindAll()
        {
            return IngresoRepository.FindAll();
        }

        public bool Insert(Ingreso t)
        {
            return IngresoRepository.Insert(t);
        }

        public bool Update(Ingreso t)
        {
            return IngresoRepository.Update(t);
        }
    }
}
