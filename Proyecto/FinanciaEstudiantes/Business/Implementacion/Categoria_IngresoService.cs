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
    public class Categoria_IngresoService : ICategoria_IngresoService
    {
        private ICategoria_IngresoRepository categoria_IngresoRepository = new Categoria_IngresoRepository();

        public bool Delete(int? id)
        {
            return categoria_IngresoRepository.Delete(id);
        }

        public Categoria_Ingreso FinByID(int? id)
        {
            return categoria_IngresoRepository.FindByID(id);
        }

        public List<Categoria_Ingreso> FindAll()
        {
            return categoria_IngresoRepository.FindAll();
        }

        public bool Insert(Categoria_Ingreso t)
        {
            return categoria_IngresoRepository.Insert(t);
        }

        public bool Update(Categoria_Ingreso t)
        {
            return categoria_IngresoRepository.Update(t);
        }
    }
}
