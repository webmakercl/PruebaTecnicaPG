using Microsoft.EntityFrameworkCore;
using PruebaTecnicaPG.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PruebaTecnicaPG.Data
{
    /// <summary>
    /// Clase que maneja el contexto de la base de datos de la app
    /// </summary>
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}
