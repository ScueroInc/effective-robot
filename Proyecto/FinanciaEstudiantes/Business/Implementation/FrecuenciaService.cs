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
    public class FrecuenciaService : IFrecuenciaService
    {
        private IFrecuenciaRepository objFrecuenciaRepository = new FrecuenciaRepository();
        public bool Delete(int? id)
        {
            return objFrecuenciaRepository.Delete(id);
        }

        public Frecuencia FindByID(int? id)
        {
            return objFrecuenciaRepository.FindByID(id);
        }

        public List<Frecuencia> FindAll()
        {
            return objFrecuenciaRepository.FindAll();
        }

        public bool Insert(Frecuencia t)
        {
            return objFrecuenciaRepository.Insert(t);
        }

        public bool Update(Frecuencia t)
        {
            return objFrecuenciaRepository.Update(t);
        }
    }
}
