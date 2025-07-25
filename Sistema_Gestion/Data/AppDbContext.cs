using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelos;

    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        
        public DbSet<Modelos.Proyectos> Proyectos { get; set; } = default!;

public DbSet<Modelos.Tareas> Tareas { get; set; } = default!;

public DbSet<Modelos.Usuario> Usuario { get; set; } = default!;
    }
