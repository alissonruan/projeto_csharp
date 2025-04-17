using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ca1504
{
    public class Pessoa
    {
        protected string nome;

        public string Nome
        {
            get
            {
                return Nome.ToUpper();

            }
            set
            {
                if (value.Length > 3)
                {
                    nome = value.ToUpper();
                }
                else
                {
                    Console.WriteLine("Nome inválido");
                }
            }
        }


        protected string email;

        public string Email
        {
            get; set;
        }


        public virtual void cadastrar()
        {
            /*Console.WriteLine("Cadastre seus dados: ");
            this.nome = Console.ReadLine();
            this.email = Console.ReadLine();*/

            Console.WriteLine("Digite o seu nome");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Digite o seu e-mail");
            this.Email = Console.ReadLine();
        }
        public void exibirDados()
        {
            /*Console.WriteLine("Digite os seus dados: ");
            this.nome = Console.ReadLine();
            this.email = Console.ReadLine();*/

            Console.WriteLine("Nome: {0}", this.Nome);
            Console.WriteLine("Email: {0}", this.Email);
            
        }
    }
}
