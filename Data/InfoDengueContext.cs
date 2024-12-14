using InfoDengue.Models;
using Microsoft.EntityFrameworkCore;


namespace InfoDengue.Data
{
    public class InfoDengueContext : DbContext
    {
        public InfoDengueContext(DbContextOptions<InfoDengueContext> options) : base(options) { }

        public DbSet<Solicitante> Solicitantes { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
    }
}
