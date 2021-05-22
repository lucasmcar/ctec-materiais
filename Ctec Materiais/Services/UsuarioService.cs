using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ctec_Materiais.Models;


namespace Ctec_Materiais.Services
{
    public class UsuarioService
    {
        private readonly MateriaisContext _context;

        public UsuarioService(MateriaisContext c)
        {
            _context = c;
        }

        public List<Usuario> FindAll()
        {
            return _context.Usuario.ToList();
        }
        
        public void Insert(Usuario objUser)
        {
            _context.Add(objUser);
            _context.SaveChanges();
        }

    }
}
