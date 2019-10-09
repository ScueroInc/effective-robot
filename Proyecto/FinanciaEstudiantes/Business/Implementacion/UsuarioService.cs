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
    public class UsuarioService : IUsuarioService

    {
        private IUsuarioRepository UsuarioRepository = new UsuarioRepository();

        public bool Delete(int? id)
        {
            return UsuarioRepository.Delete(id);
        }

        public Usuario FinByID(int? id)
        {
            return UsuarioRepository.FindByID(id);
        }

        public List<Usuario> FindAll()
        {
            return UsuarioRepository.FindAll();
        }

        public bool Insert(Usuario t)
        {
            return UsuarioRepository.Insert(t);
        }

        public bool Update(Usuario t)
        {
            return UsuarioRepository.Update(t);
        }
    }
}
