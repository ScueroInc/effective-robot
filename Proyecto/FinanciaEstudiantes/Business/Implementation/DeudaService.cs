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
    public class DeudaService : IDeudaService
    {
        private IDeudaRepository objDeudaRepo = new DeudaRepository();
        public bool Delete(int? id)
        {
            return objDeudaRepo.Delete(id);
        }

        public Deuda FindByID(int? id)
        {
            return objDeudaRepo.FindByID(id);
        }

        public List<Deuda> FindAll()
        {
            return objDeudaRepo.FindAll();
        }

        public bool Insert(Deuda t)
        {
            return objDeudaRepo.Insert(t);
        }

        public bool Update(Deuda t)
        {
            return objDeudaRepo.Update(t);
        }
    }
}
