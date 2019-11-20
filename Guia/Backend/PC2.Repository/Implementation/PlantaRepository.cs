using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PC2.Domain;
using PC2.Repository.Context;

namespace PC2.Repository.Implementation
{
    public class PlantaRepository : IPlantaRepository
    {
        private ApplicationDbContext context;

        public PlantaRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            try{
                var entity = context.Plantas.FirstOrDefault(x=>x.id==id);
                context.Plantas.Remove(entity);
                context.SaveChanges();
                return true;
            }
            catch (System.Exception) {
                return false;
            }
        }

        public IEnumerable<Planta> FindAll()
        {
            var result = new List<Planta>();
            try {
                result = context.Plantas.ToList();
            }
            catch  (System.Exception) {
                throw;
            }
            return result;
        }

        public Planta FindById(int id)
        {
            var planta = new Planta();
            try {
                planta =  context.Plantas.FirstOrDefault(x=>x.id==id);
            }
            catch (System.Exception) {
                throw;
            }
            return planta;   
        }

        public bool Save(Planta entity)
        {
            try {
                context.Plantas.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception) {
                return false;
            }
            return true;
        }

        public bool Update(Planta entity)
        {
            try {
                var plantaOriginal = context.Plantas.Single (
                    x=>x.id == entity.id
                );
                plantaOriginal.id = entity.id;
                plantaOriginal.NroFactura = entity.NroFactura;
                plantaOriginal.moneda=entity.moneda;
                plantaOriginal.Retencion=entity.Retencion;
                plantaOriginal.DiaEmision=entity.DiaEmision;
                plantaOriginal.DiaPago=entity.DiaPago;
                plantaOriginal.TotalFacturado=entity.TotalFacturado;

                context.Plantas.Update(plantaOriginal);
                context.SaveChanges();
            }
            catch (System.Exception) {
                return false;
            }
            return true;
        }
    }
}