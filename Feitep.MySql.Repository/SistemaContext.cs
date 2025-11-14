using Feitep.MySql.Models;
using Microsoft.EntityFrameworkCore;

namespace Feitep.MySql.Repository;
    public class SistemaContext
    {
        public DbSet<Cliente>? Clientes { get; set; }
    }
