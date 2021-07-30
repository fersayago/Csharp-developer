using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioWebApi.Model
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> opciones) : base(opciones) { }
        public DbSet<Amigo> Amigo { get; set;  }
    }
}
