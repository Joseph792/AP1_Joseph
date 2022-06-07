using Microsoft.EntityFrameworkCore;
using AportesBlazor.Models;

namespace AportesBlazor.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Aportes> Aportes { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            
        }
    }
}
