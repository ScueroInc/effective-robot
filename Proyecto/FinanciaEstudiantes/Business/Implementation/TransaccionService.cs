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
    public class TransaccionService : ITransaccionService
    {
        private ITransaccionRepository objTransaccionRepository = new TransaccionRepository();
        public bool Delete(int? id)
        {
            return objTransaccionRepository.Delete(id);
        }

        public Transaccion FindByID(int? id)
        {
            return objTransaccionRepository.FindByID(id);
        }

        public List<Transaccion> FindAll()
        {
            return objTransaccionRepository.FindAll();
        }

        public bool Insert(Transaccion t)
        {
            return objTransaccionRepository.Insert(t);
        }

        public bool Update(Transaccion t)
        {
            return objTransaccionRepository.Update(t);
        }
    }
}
