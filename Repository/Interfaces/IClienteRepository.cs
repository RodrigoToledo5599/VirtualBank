using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repository.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> clientes();
        Cliente GetCliente(int id);
        Cliente LogCliente(string cpf, string Password);


    }
}
