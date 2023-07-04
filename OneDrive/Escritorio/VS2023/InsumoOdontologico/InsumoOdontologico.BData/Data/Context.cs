using InsumoOdontologico.BData.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsumoOdontologico.BData.Data
{
    public class Context : DbContext
    {
        public DbSet<Persona> Personas => Set<Persona>();

        public DbSet<Insumo> Insumos => Set<Insumo>();

        public Context(DbContextOptions options) : base(options) 
        {
        }
    }
}
