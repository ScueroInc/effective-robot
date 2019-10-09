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
    public class DivisaService : IDivisaService
    {
        private IDivisaRepository objDivisaRepo = new DivisaRepository();
        public bool Delete(int? id)
        {
            return objDivisaRepo.Delete(id);
        }

        public Divisa FindByID(int? id)
        {
            return objDivisaRepo.FindByID(id);
        }

        public List<Divisa> FindAll()
        {
            return objDivisaRepo.FindAll();
        }

        public bool Insert(Divisa t)
        {
            return objDivisaRepo.Insert(t);
        }

        public bool Update(Divisa t)
        {
            return objDivisaRepo.Update(t);
        }
    }
}
