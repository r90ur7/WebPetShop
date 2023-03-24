using Microsoft.EntityFrameworkCore;
using PetShop.Models;

namespace PetShop.Data.Mappings
{
    public static class MappingConsulta
    {
        public static void ConsultaMapeamento(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consulta>()
                    .HasKey(p => p.Id);
            modelBuilder.Entity<Consulta>()
                .HasOne(pe => pe.Clientes)
                .WithMany(pe => pe.Consultas)
                .HasForeignKey(pe => pe.ClienteId);

            modelBuilder.Entity<Consulta>()
                .HasOne(pe => pe.Funcionarios)
                .WithMany(pe => pe.Consultas)
                .HasForeignKey(pe => pe.FuncionarioId);

            modelBuilder.Entity<Consulta>()
                .HasOne(pe => pe.Estoques)
                .WithMany(pe => pe.Consultas)
                .HasForeignKey(pe => pe.EstoqueId);
        }
    }
}
