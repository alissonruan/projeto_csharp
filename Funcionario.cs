using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca1504
{
    public class Funcionario : Pessoa
    {
        protected double salario;
        protected int registro;
        Pessoa[] dependentes = new Pessoa[0];

        public void definirSalario()
        {
            this.salario = 1500;
        }

        public void exibirSalario()
        {
            Console.WriteLine(this.salario);
        }

        public void desconto()
        {
            Console.WriteLine("O desconto do salario é: ");
            this.salario = this.salario - (this.salario * 5 / 100);
        }
    }
}
