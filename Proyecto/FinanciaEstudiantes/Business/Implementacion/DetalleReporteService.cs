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
    public class DetalleReporteService : IDetalleReporteService
    {
        private IDetalleReporteRepository DetalleReporteRepository = new DetalleReporteRepository();

        public bool Delete(int? id)
        {
            return DetalleReporteRepository.Delete(id);
        }

        public DetalleReporte FinByID(int? id)
        {
            return DetalleReporteRepository.FindByID(id); 
        }

        public List<DetalleReporte> FindAll()
        {
            return DetalleReporteRepository.FindAll();
        }

        public bool Insert(DetalleReporte t)
        {
            return DetalleReporteRepository.Insert(t);
        }

        public bool Update(DetalleReporte t)
        {
            return DetalleReporteRepository.Update(t);
        }
    }
}
