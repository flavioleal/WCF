using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteDAO
    {
        public static List<Cliente> clientes = new List<Cliente>();

        public void Add(Cliente c)
        {
            ClienteDAO.clientes.Add(c);
        }
        public Cliente Buscar(string nome)
        {
            var resultado = ClienteDAO.clientes.FirstOrDefault(x => x.Nome.Equals(nome));
            return (Cliente) resultado;
        }
    }
}
