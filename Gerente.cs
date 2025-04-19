using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca1504
{
    internal class Gerente : Funcionario
    {
        protected string setor;

        public override void cadastrar() { 
         base.cadastrar();
            Console.WriteLine("Setor:");
            setor = Console.ReadLine();
        }

       
    }
}
