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
    public class TipoCuentaService : ITipoCuentaService
    {
        private ITipoCuentaRepository objTipoCuentaRepository = new TipoCuentaRepository();

        public bool Delete(int? id)
        {
            return objTipoCuentaRepository.Delete(id);
        }

        public TipoCuenta FindByID(int? id)
        {
            return objTipoCuentaRepository.FindByID(id);
        }

        public List<TipoCuenta> FindAll()
        {
            return objTipoCuentaRepository.FindAll();
        }

        public bool Insert(TipoCuenta t)
        {
            return objTipoCuentaRepository.Insert(t);
        }

        public bool Update(TipoCuenta t)
        {
            return objTipoCuentaRepository.Update(t);
        }
    }
}
