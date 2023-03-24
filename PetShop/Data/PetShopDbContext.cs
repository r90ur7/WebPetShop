using Microsoft.EntityFrameworkCore;
using PetShop.Data.Mappings;
using PetShop.Models;

namespace PetShop.Data
{
    public class PetShopDbContext : DbContext
    {
        public PetShopDbContext(DbContextOptions<PetShopDbContext> options)
            : base(options)
        { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Consulta> Consultas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ConsultaMapeamento();
        }
    }
}
