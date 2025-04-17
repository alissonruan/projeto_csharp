using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca1504
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "tio";
            pessoa.Email = "teste@teste.com";
            Console.WriteLine("Nome: {0}", pessoa.Nome);
            Console.WriteLine("Email: {0}", pessoa.Email);
            Cliente c = new Cliente();
            c.cadastrar();
            pessoa.cadastrar();
        }
    }
}
