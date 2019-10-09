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
    public class Categoria_GastoService : ICategoria_GastoService
    {
        private ICategoria_GastoRepository categoria_GastoRepository = new Categoria_GastoRepository();

        public bool Delete(int? id)
        {
            return categoria_GastoRepository.Delete(id);
        }

        public Categoria_Gasto FinByID(int? id)
        {
            return categoria_GastoRepository.FindByID(id);
        }

        public List<Categoria_Gasto> FindAll()
        {
            return categoria_GastoRepository.FindAll();
        }

        public bool Insert(Categoria_Gasto t)
        {
            return categoria_GastoRepository.Insert(t);
        }

        public bool Update(Categoria_Gasto t)
        {
            return categoria_GastoRepository.Update(t);
        }
    }
}
