using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PC2.Domain;
using PC2.Repository.Context;

namespace PC2.Repository.Implementation
{
    public class Planta_ViveroRepository : IPlanta_ViveroRepository
    {
        private ApplicationDbContext context;
        public Planta_ViveroRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            try{
                var entity = context.Plantas_Viveros.FirstOrDefault(x=>x.id==id);
                context.Plantas_Viveros.Remove(entity);
                context.SaveChanges();
                return true;
            }
            catch (System.Exception) {
                return false;
            }
        }

        public IEnumerable<Planta_Vivero> FindAll()
        {
            var result = new List<Planta_Vivero>();
            try {
                result = context.Plantas_Viveros
                .Include(pv => pv.planta)
                .Include(pv => pv.vivero)
                .OrderBy(pv => pv.vivero.id)
                .ToList();
            }
            catch  (System.Exception) {
                throw;
            }
            return result;
        }

        public Planta_Vivero FindById(int id)
        {
            var planta_vivero = new Planta_Vivero();
            try {
                planta_vivero =  context.Plantas_Viveros
                .Include(pv => pv.planta)
                .Include(pv => pv.vivero)
                .FirstOrDefault(x=>x.id==id);
            }
            catch (System.Exception) {
                throw;
            }
            return planta_vivero;  
        }

        public bool Save(Planta_Vivero entity)
        {
            try {
                var entidad = new Planta_Vivero();
            
                entidad.id = entity.id;
                entidad.planta = context.Plantas.FirstOrDefault(x => x.id == entity.planta.id);
                entidad.vivero = context.Viveros.FirstOrDefault(x => x.id == entity.vivero.id);
                entidad.fechaRegistro = entity.fechaRegistro;

                context.Plantas_Viveros.Add(entidad);
                context.SaveChanges();
            }
            catch (System.Exception) {
                return false;
            }
            return true;
        }

        public bool Update(Planta_Vivero entity)
        {
            try {
                var planta_viveroOriginal = context.Plantas_Viveros.Single (
                    x=>x.id == entity.id
                );
                planta_viveroOriginal.id = entity.id;
                planta_viveroOriginal.planta = entity.planta;
                planta_viveroOriginal.vivero = entity.vivero;
                planta_viveroOriginal.fechaRegistro = entity.fechaRegistro;

                context.Plantas_Viveros.Update(planta_viveroOriginal);
                context.SaveChanges();
            }
            catch (System.Exception) {
                return false;
            }
            return true;
        }
    }
}