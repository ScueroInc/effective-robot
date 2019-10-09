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
    public class Entidad_TipoService : IEntidad_TipoService
    {
        private IEntidad_TipoRepository objEntidadTipoRepo = new Entidad_TipoRepository();
        public bool Delete(int? id)
        {
            return objEntidadTipoRepo.Delete(id);
        }

        public Entidad_Tipo FindByID(int? id)
        {
            return objEntidadTipoRepo.FindByID(id);
        }

        public List<Entidad_Tipo> FindAll()
        {
            return objEntidadTipoRepo.FindAll();
        }

        public bool Insert(Entidad_Tipo t)
        {
            return objEntidadTipoRepo.Insert(t);
        }

        public bool Update(Entidad_Tipo t)
        {
            return objEntidadTipoRepo.Update(t);
        }
    }
}
