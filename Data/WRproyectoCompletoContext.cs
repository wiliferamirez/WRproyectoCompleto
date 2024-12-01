using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WRproyectoCompleto.Models;

namespace WRproyectoCompleto.Data
{
    public class WRproyectoCompletoContext : DbContext
    {
        public WRproyectoCompletoContext (DbContextOptions<WRproyectoCompletoContext> options)
            : base(options)
        {
        }

        public DbSet<WRproyectoCompleto.Models.WREstudiante> WREstudiante { get; set; } = default!;
    }
}
