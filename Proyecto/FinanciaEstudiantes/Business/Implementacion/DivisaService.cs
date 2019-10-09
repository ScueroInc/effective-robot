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
    public class DivisaService : IDivisaService
    {
        private IDivisaRepository DivisaRepository = new DivisaRepository();

        public bool Delete(int? id)
        {
            return DivisaRepository.Delete(id);
        }

        public Divisa FinByID(int? id)
        {
            return DivisaRepository.FindByID(id);
        }

        public List<Divisa> FindAll()
        {
            return DivisaRepository.FindAll();
        }

        public bool Insert(Divisa t)
        {
            return DivisaRepository.Insert(t);
        }

        public bool Update(Divisa t)
        {
            return DivisaRepository.Update(t);
        }
    }
}
