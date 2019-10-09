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
    public class ReporteService : IReporteService
    {
        private IReporteRepository ReporteRepository = new ReporteRepository();

        public bool Delete(int? id)
        {
            return ReporteRepository.Delete(id);
        }

        public Reporte FinByID(int? id)
        {
            return ReporteRepository.FindByID(id);
        }

        public List<Reporte> FindAll()
        {
            return ReporteRepository.FindAll();
        }

        public bool Insert(Reporte t)
        {
            return ReporteRepository.Insert(t);
        }

        public bool Update(Reporte t)
        {
            return ReporteRepository.Update(t);
        }
    }
}
