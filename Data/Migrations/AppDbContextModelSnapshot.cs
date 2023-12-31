﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("nvarchar(127)");

                    b.Property<int?>("Saldo")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("nvarchar(127)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cpf = "18283245921",
                            Email = "rogerinho@gmail.com",
                            Nome = "Rogerio Santos",
                            Senha = "123Change"
                        },
                        new
                        {
                            Id = 2,
                            Cpf = "39295697000",
                            Email = "ronaldin@gmail.com",
                            Nome = "Ronaldo Silva",
                            Senha = "1234Car"
                        },
                        new
                        {
                            Id = 3,
                            Cpf = "45830285829",
                            Email = "joseluiz@gmail.com",
                            Nome = "Jose Luiz",
                            Senha = "shiruleibe"
                        },
                        new
                        {
                            Id = 4,
                            Cpf = "08266643761",
                            Email = "Amaral3333@gmail.com",
                            Nome = "Amaral Hernandez",
                            Senha = "@##$1oi1ooo"
                        },
                        new
                        {
                            Id = 5,
                            Cpf = "49320595022",
                            Email = "Pedrinho@gmail.com",
                            Nome = "Pedro Joao",
                            Senha = "fjqwo33o%GEE33"
                        },
                        new
                        {
                            Id = 6,
                            Cpf = "49333984844",
                            Email = "Johny@gmail.com",
                            Nome = "Johny Pinheiro",
                            Senha = "f22jeeewwE33"
                        },
                        new
                        {
                            Id = 7,
                            Cpf = "1",
                            Email = "teste",
                            Nome = "teste",
                            Senha = "teste"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
