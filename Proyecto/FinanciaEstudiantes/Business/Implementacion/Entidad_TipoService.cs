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
    public class Entidad_TipoService : IEntidad_TipoService
    {
        private IEntidad_TipoRepository Entidad_TipoRepository = new Entidad_TipoRepository();

        public bool Delete(int? id)
        {
            return Entidad_TipoRepository.Delete(id);
        }

        public Entidad_Tipo FinByID(int? id)
        {
            return Entidad_TipoRepository.FindByID(id);
        }

        public List<Entidad_Tipo> FindAll()
        {
            return Entidad_TipoRepository.FindAll();
        }

        public bool Insert(Entidad_Tipo t)
        {
            return Entidad_TipoRepository.Insert(t);
        }

        public bool Update(Entidad_Tipo t)
        {
            return Entidad_TipoRepository.Update(t);
        }
    }
}
