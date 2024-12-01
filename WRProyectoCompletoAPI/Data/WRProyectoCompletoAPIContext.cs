using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WRproyectoCompletoAPI.Models;

namespace WRProyectoCompletoAPI.Data
{
    public class WRProyectoCompletoAPIContext : DbContext
    {
        public WRProyectoCompletoAPIContext (DbContextOptions<WRProyectoCompletoAPIContext> options)
            : base(options)
        {
        }
        public DbSet<WRproyectoCompletoAPI.Models.WREstudiante> WREstudiante { get; set; } = default!;
    }
}
