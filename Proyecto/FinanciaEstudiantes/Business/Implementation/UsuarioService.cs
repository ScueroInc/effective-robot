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
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository objUsuarioRepositorio = new UsuarioRepository();
        public bool Delete(int? id)
        {
            return objUsuarioRepositorio.Delete(id);
        }

        public Usuario FindByID(int? id)
        {
            return objUsuarioRepositorio.FindByID(id);
        }

        public List<Usuario> FindAll()
        {
            return objUsuarioRepositorio.FindAll();
        }

        public bool Insert(Usuario t)
        {
            return objUsuarioRepositorio.Insert(t);
        }

        public bool Update(Usuario t)
        {
            return objUsuarioRepositorio.Update(t);
        }
    }
}
