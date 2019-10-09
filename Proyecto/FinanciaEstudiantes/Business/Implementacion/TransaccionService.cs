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
    public class TransaccionService : ITransaccionService
    {
        private ITransaccionRepository TransaccionRepository = new TransaccionRepository();

        public bool Delete(int? id)
        {
            return TransaccionRepository.Delete(id);
        }

        public Transaccion FinByID(int? id)
        {
            return TransaccionRepository.FindByID(id);
        }

        public List<Transaccion> FindAll()
        {
            return TransaccionRepository.FindAll();
        }

        public bool Insert(Transaccion t)
        {
            return TransaccionRepository.Insert(t);
        }

        public bool Update(Transaccion t)
        {
            return TransaccionRepository.Update(t);
        }
    }
}
