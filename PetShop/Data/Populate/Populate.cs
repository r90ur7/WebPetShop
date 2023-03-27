using Microsoft.EntityFrameworkCore;
using PetShop.Models;

namespace PetShop.Data.Populate
{
    public static class Populate
    {
        public static void PopulateDataBase(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id=  1, Nome= "Rallenson"},
                new Cliente { Id = 2, Nome = "João" },
                new Cliente { Id = 3, Nome = "Gabi" }
                );


            modelBuilder.Entity<Funcionario>().HasData(
                new Funcionario { Id = 1,Nome="Rosen",Funcao="Gerente" }
                );

            modelBuilder.Entity<Estoque>().HasData(
                new Estoque { Id = 1, Nome = "Shampoo", Data = new DateTime(2023, 03, 27, 12, 30, 0), Fornecedor = "Json Json", Preco = 5, Quantidade = 90 },
                new Estoque { Id = 2, Nome = "Condicionador", Data = new DateTime(2023, 07, 27, 12, 30, 0), Fornecedor = "Json Json", Preco = 5, Quantidade = 90 }

                );

        }
    }
}
