using System;
using Microsoft.EntityFrameworkCore;

namespace simulacro.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<simulacro.Models.SolicitudCompra> DataContactos { get; set; }
        public DbSet<simulacro.Models.Categoria> DataCategorias {get; set;}
    }
}