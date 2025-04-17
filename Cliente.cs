using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca1504
{
    public class Cliente : Pessoa
    {
        protected int id;

        public override void cadastrar()
        {
            base.cadastrar();
            Console.WriteLine("Digite o seu ID: ");
            this.id = int.Parse(Console.ReadLine());
        }
    }
}
