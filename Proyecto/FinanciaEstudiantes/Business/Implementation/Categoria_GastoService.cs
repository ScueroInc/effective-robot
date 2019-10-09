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
    public class Categoria_GastoService : ICategoria_GastoService
    {
        private ICategoria_GastoRepository objCategoria_GastoRepo = new Categoria_GastoRepository();
        public bool Delete(int? id)
        {
            return objCategoria_GastoRepo.Delete(id);
        }

        public Categoria_Gasto FindByID(int? id)
        {
            return objCategoria_GastoRepo.FindByID(id);
        }

        public List<Categoria_Gasto> FindAll()
        {
            return objCategoria_GastoRepo.FindAll();
        }

        public bool Insert(Categoria_Gasto t)
        {
            return objCategoria_GastoRepo.Insert(t);
        }

        public bool Update(Categoria_Gasto t)
        {
            return objCategoria_GastoRepo.Update(t);
        }
    }
}
