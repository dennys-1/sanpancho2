using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mi_proyecto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Mi_proyecto.Models.Producto> Productos { get; set; }
        public DbSet<Mi_proyecto.Models.Usuario> Usuarios { get; set; }
        public DbSet<Mi_proyecto.Models.OrdenDetail> OrdenDetails { get; set; }
        //public DbSet<LibreriaProgra.Models.Citas> Citas { get; set; }
        public DbSet<Mi_proyecto.Models.Contactanos> Contactanos { get; set; }
    }
}
