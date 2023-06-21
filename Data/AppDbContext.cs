using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Cliente> Cliente { get; set; }
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Cpf = "18283245921", Nome = "Rogerio Santos", Email = "rogerinho@gmail.com", Senha = "123Change" },
                new Cliente { Id = 2, Cpf = "39295697000", Nome = "Ronaldo Silva", Email = "ronaldin@gmail.com", Senha = "1234Car" },
                new Cliente { Id = 3, Cpf = "45830285829", Nome = "Jose Luiz", Email = "joseluiz@gmail.com", Senha = "shiruleibe" },
                new Cliente { Id = 4, Cpf = "08266643761", Nome = "Amaral Hernandez", Email = "Amaral3333@gmail.com", Senha = "@##$1oi1ooo" },
                new Cliente { Id = 5, Cpf = "49320595022", Nome = "Pedro Joao", Email = "Pedrinho@gmail.com", Senha = "fjqwo33o%GEE33" },
                new Cliente { Id = 6, Cpf = "49333984844", Nome = "Johny Pinheiro", Email = "Johny@gmail.com", Senha = "f22jeeewwE33" },
                new Cliente { Id = 7, Cpf = "1", Nome="teste", Email="teste", Senha="teste"}

                            



            );
        }
    }


}
