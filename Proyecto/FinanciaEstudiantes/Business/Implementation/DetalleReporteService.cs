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
    public class DetalleReporteService : IDetalleReporteService
    {
        private IDetalleReporteRepository objDetalleReporteRepo = new DetalleReporteRepository();
        public bool Delete(int? id)
        {
            return objDetalleReporteRepo.Delete(id);
        }

        public DetalleReporte FindByID(int? id)
        {
            return objDetalleReporteRepo.FindByID(id);
        }

        public List<DetalleReporte> FindAll()
        {
            return objDetalleReporteRepo.FindAll();
        }

        public bool Insert(DetalleReporte t)
        {
            return objDetalleReporteRepo.Insert(t);
        }

        public bool Update(DetalleReporte t)
        {
            return objDetalleReporteRepo.Update(t);
        }
    }
}
