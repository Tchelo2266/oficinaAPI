using Microsoft.EntityFrameworkCore;
using oficinaAPI.Models;

namespace oficinaAPI.Data
{
    public class OficinaContext(DbContextOptions<OficinaContext> opts) : DbContext(opts)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>()
                .HasMany(c => c.Veiculos)
                .WithOne(c => c.Cliente)
                .HasForeignKey(v => v.ClienteId);

            builder.Entity<Servico>()
                .HasOne(s => s.TipoServico)
                .WithMany(ts => ts.Servicos);

            builder.Entity<TipoServico>()
                .HasMany(ts => ts.Servicos);
        }

        public DbSet<Cliente> Clientes { get; set;}

        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet<Servico> Servicos { get; set; }

        public DbSet<TipoServico> TiposServico { get; set; }

    }
}
