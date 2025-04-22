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

        public void bonus()
        {
            Console.WriteLine("O bônus do seu salario é: ");
            this.salario = this.salario + (this.salaro * this.salario / 10);
        }

        public void cadastrarRegistro()
        {
            Console.WriteLine("Digite o seu Nome:");
            Pessoa.nome = Console.ReadLine();
            Console.WriteLine("Digite o seu Email:);
            Pessoa.email = Console.ReadLine();
        }
        
        

        public void consultarRegistro()
        {
            Console.WriteLine("O seu Nome é: {0}", Pessoa.nome);
            Console.WriteLine("O seu Email é: {0}", Pessoa.email);
        }

        public void dependente()
        {
            Console.WriteLine("Digite o nome do seu Dependente: ");
            Pessoa.dependente = Console.ReadLine();
        }
}
