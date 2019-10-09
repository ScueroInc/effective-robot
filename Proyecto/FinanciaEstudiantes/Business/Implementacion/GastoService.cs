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
    public class GastoService : IIGastoService
    {
        private IGastoRepository GastoRepository = new GastoRepository();

        public bool Delete(int? id)
        {
            return GastoRepository.Delete(id);
        }

        public Gasto FinByID(int? id)
        {
            return GastoRepository.FindByID(id);
        }

        public List<Gasto> FindAll()
        {
            return GastoRepository.FindAll();
        }

        public bool Insert(Gasto t)
        {
            return GastoRepository.Insert(t);
        }

        public bool Update(Gasto t)
        {
            return GastoRepository.Update(t);
        }
    }
}
