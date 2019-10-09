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
    public class FrecuenciaService : IFrecuenciaService
    {
        private IFrecuenciaRepository FrecuenciaRepository = new FrecuenciaRepository();

        public bool Delete(int? id)
        {
            return FrecuenciaRepository.Delete(id);
        }

        public Frecuencia FinByID(int? id)
        {
            return FrecuenciaRepository.FindByID(id);
        }

        public List<Frecuencia> FindAll()
        {
            return FrecuenciaRepository.FindAll();
        }

        public bool Insert(Frecuencia t)
        {
            return FrecuenciaRepository.Insert(t);
        }

        public bool Update(Frecuencia t)
        {
            return FrecuenciaRepository.Update(t);
        }
    }
}
