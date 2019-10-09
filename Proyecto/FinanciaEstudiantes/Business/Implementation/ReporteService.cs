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
    public class ReporteService : IReporteService
    {
        private IReporteRepository objReporteRepository = new ReporteRepository();
        public bool Delete(int? id)
        {
            return objReporteRepository.Delete(id);
        }

        public Reporte FindByID(int? id)
        {
            return objReporteRepository.FindByID(id);
        }

        public List<Reporte> FindAll()
        {
            return objReporteRepository.FindAll();
        }

        public bool Insert(Reporte t)
        {
            return objReporteRepository.Insert(t);
        }

        public bool Update(Reporte t)
        {
            return objReporteRepository.Update(t);
        }
    }
}
