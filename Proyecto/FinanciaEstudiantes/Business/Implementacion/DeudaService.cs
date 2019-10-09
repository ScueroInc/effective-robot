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
    public class DeudaService : IDeudaService
    {
        private IDeudaRepository DeudaRepository = new DeudaRepository();
        public bool Delete(int? id)
        {
            return DeudaRepository.Delete(id);
        }

        public Deuda FinByID(int? id)
        {
            return DeudaRepository.FindByID(id);
        }

        public List<Deuda> FindAll()
        {
            return DeudaRepository.FindAll();
        }

        public bool Insert(Deuda t)
        {
            return DeudaRepository.Insert(t);
        }

        public bool Update(Deuda t)
        {
            return DeudaRepository.Update(t);
        }
    }
}
