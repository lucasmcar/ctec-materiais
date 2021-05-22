using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ctec_Materiais.Models;

namespace Ctec_Materiais.Data
{
    public class SeedingService
    {
        private MateriaisContext _context;

        public SeedingService(MateriaisContext c)
        {
            _context = c;
        }
        
        //Método que popula banco de dados
        public void Seed()
        {
            if(_context.Material.Any() || 
                _context.Usuario.Any() || 
                _context.RegistroRetirada.Any())
            {
                return; //Banco de dados já foi populado;
            }

             
        }
    }
}
