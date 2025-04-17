using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca1504
{
    public class Gerente : Funcionario
    {
        protected string setor;

        public override void cadastrar()
        {
            base.cadastrar();
            Console.WriteLine("setor: ");
            setor = Console.ReadLine();
        }
    }
}
