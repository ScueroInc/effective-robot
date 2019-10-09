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
    public class Categoria_IngresoService : ICategoria_IngresoService
    {
        private ICategoria_IngresoRepository objCategoria_IngresoRepo = new Categoria_IngresoRepository();
        public bool Delete(int? id)
        {
            return objCategoria_IngresoRepo.Delete(id);
        }

        public Categoria_Ingreso FindByID(int? id)
        {
            return objCategoria_IngresoRepo.FindByID(id);
        }

        public List<Categoria_Ingreso> FindAll()
        {
            return objCategoria_IngresoRepo.FindAll();
        }

        public bool Insert(Categoria_Ingreso t)
        {
            return objCategoria_IngresoRepo.Insert(t);
        }

        public bool Update(Categoria_Ingreso t)
        {
            return objCategoria_IngresoRepo.Update(t);
        }
    }
}
