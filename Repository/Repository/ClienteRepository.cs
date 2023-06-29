using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Models;
using Repository.Interfaces;

namespace Repository.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public readonly AppDbContext _db;
        public ClienteRepository(AppDbContext db)
        {
            _db = db;
        }

        public Cliente GetCliente(int id)
        {
            var cli =_db.Cliente.FirstOrDefault(x => x.Id == id);
            return cli;
        }

        public IEnumerable<Cliente> clientes()
        {
            var Clientes = _db.Cliente.ToList();
            return Clientes;
        }

        public Cliente LogCliente(string cpf, string Password)
        {
            var cliente = _db.Cliente.Where(c => c.Cpf == cpf && c.Senha == Password).FirstOrDefault();
            return cliente;
        }
    }
}
