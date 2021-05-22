using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ctec_Materiais.Models;

    public class MateriaisContext : DbContext
    {
        public MateriaisContext (DbContextOptions<MateriaisContext> options)
            : base(options)
        {
        }

        public DbSet<Material> Material { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<RegistroRetirada> RegistroRetirada { get; set; }
    }
