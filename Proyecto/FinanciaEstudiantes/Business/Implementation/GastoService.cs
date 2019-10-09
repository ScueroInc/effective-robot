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
    public class GastoService : IIGastoService
    {
        private IGastoRepository objGastoRepository = new GastoRepository();
        public bool Delete(int? id)
        {
            return objGastoRepository.Delete(id);
        }

        public Gasto FindByID(int? id)
        {
            return objGastoRepository.FindByID(id);
        }

        public List<Gasto> FindAll()
        {
            return objGastoRepository.FindAll();
        }

        public bool Insert(Gasto t)
        {
            return objGastoRepository.Insert(t);
        }

        public bool Update(Gasto t)
        {
            return objGastoRepository.Update(t);
        }
    }
}
