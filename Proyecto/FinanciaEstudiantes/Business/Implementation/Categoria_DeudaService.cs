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
    public class Categoria_DeudaService : ICategoria_DeudaService
    {
        private ICategoria_DeudaRepository objCategoria_DeudaRepo = new Categoria_DeudaRepository();
        public bool Delete(int? id)
        {
            return objCategoria_DeudaRepo.Delete(id);
        }

        public Categoria_Deuda FindByID(int? id)
        {
            return objCategoria_DeudaRepo.FindByID(id);
        }

        public List<Categoria_Deuda> FindAll()
        {
            return objCategoria_DeudaRepo.FindAll();
        }

        public bool Insert(Categoria_Deuda t)
        {
            return objCategoria_DeudaRepo.Insert(t);
        }

        public bool Update(Categoria_Deuda t)
        {
            return objCategoria_DeudaRepo.Update(t);
        }
    }
}
