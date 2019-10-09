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
    public class Categoria_DeudaService : ICategoria_DeudaService
    {
        private ICategoria_DeudaRepository categoria_DeudaRepository = new Categoria_DeudaRepository();
        public bool Delete(int? id)
        {
            return categoria_DeudaRepository.Delete(id);
        }

        public Categoria_Deuda FinByID(int? id)
        {
            return categoria_DeudaRepository.FindByID(id);
        }

        public List<Categoria_Deuda> FindAll()
        {
            return categoria_DeudaRepository.FindAll();
        }

        public bool Insert(Categoria_Deuda t)
        {
            return categoria_DeudaRepository.Insert(t);
        }

        public bool Update(Categoria_Deuda t)
        {
            return categoria_DeudaRepository.Update(t);
        }
    }
}
