using Ctec_Materiais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ctec_Materiais.Services
{
    public class MaterialService
    {
        private readonly MateriaisContext _context;

        public MaterialService(MateriaisContext c)
        {
            _context = c;
        }

        public List<Material> FindAll()
        {
            return _context.Material.OrderBy(model => model.Nome).ToList();
        }


    }
}
