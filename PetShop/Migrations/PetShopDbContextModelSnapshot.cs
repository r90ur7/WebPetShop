﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShop.Data;

#nullable disable

namespace PetShop.Migrations
{
    [DbContext(typeof(PetShopDbContext))]
    partial class PetShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PetShop.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Rallenson"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "João"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Gabi"
                        });
                });

            modelBuilder.Entity("PetShop.Models.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Atividade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("EstoqueId")
                        .HasColumnType("int");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EstoqueId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("PetShop.Models.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Preco")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Estoques");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Data = new DateTime(2023, 3, 27, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            Fornecedor = "Json Json",
                            Nome = "Shampoo",
                            Preco = 5,
                            Quantidade = 90
                        },
                        new
                        {
                            Id = 2,
                            Data = new DateTime(2023, 7, 27, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            Fornecedor = "Json Json",
                            Nome = "Condicionador",
                            Preco = 5,
                            Quantidade = 90
                        });
                });

            modelBuilder.Entity("PetShop.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Funcao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Funcao = "Gerente",
                            Nome = "Rosen"
                        });
                });

            modelBuilder.Entity("PetShop.Models.Consulta", b =>
                {
                    b.HasOne("PetShop.Models.Cliente", "Clientes")
                        .WithMany("Consultas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetShop.Models.Estoque", "Estoques")
                        .WithMany("Consultas")
                        .HasForeignKey("EstoqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetShop.Models.Funcionario", "Funcionarios")
                        .WithMany("Consultas")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clientes");

                    b.Navigation("Estoques");

                    b.Navigation("Funcionarios");
                });

            modelBuilder.Entity("PetShop.Models.Cliente", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("PetShop.Models.Estoque", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("PetShop.Models.Funcionario", b =>
                {
                    b.Navigation("Consultas");
                });
#pragma warning restore 612, 618
        }
    }
}
