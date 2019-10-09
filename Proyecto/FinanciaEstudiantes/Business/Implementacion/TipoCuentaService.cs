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
    public class TipoCuentaService : ITipoCuentaService
    {
        private ITipoCuentaRepository TipoCuentaRepository = new TipoCuentaRepository();

        public bool Delete(int? id)
        {
            return TipoCuentaRepository.Delete(id);
        }

        public TipoCuenta FinByID(int? id)
        {
            return TipoCuentaRepository.FindByID(id);
        }

        public List<TipoCuenta> FindAll()
        {
            return TipoCuentaRepository.FindAll();
        }

        public bool Insert(TipoCuenta t)
        {
            return TipoCuentaRepository.Insert(t);
        }

        public bool Update(TipoCuenta t)
        {
            return TipoCuentaRepository.Update(t);
        }
    }
}
