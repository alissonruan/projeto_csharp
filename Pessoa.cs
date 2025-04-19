using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ca1504
{
    internal class Pessoa
    {
        protected string nome;
        public string Nome
        {
            get
            {
                return nome.ToUpper();
            }
            set
            {
                if (value.Length > 3)
                {
                    nome = value.ToUpper();
                } else
                {
                    Console.WriteLine("nome inválido");
                }
            }
        }
        protected string email;
        public string Email
        {
            get {
                return email.ToUpper();
            }
            set { 
                email = value.ToUpper();
            }
            
        }
       
        public virtual void cadastrar()
        {
            Console.WriteLine("Digite seu nome:");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu e-mail:");
            this.Email = Console.ReadLine();
        }

        public void exibirDados()
        {
            Console.WriteLine("Nome:{0}",this.Nome);
            Console.WriteLine("E-Mail:{0}",this.Email);
        }
    }
}
