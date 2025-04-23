using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca1504
{
    public class ClienteVip : Cliente
    {
        protected double desconto;
        protected double cashback;


        public void calcularCashback(valorcompra: double)
        {
            Console.WriteLine("Digite o valor da Compra:");
            this.valorcompra = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o desconto do cashback:");
            this.desconto = double.Parse(Console.ReadLine());
            this.cashback = (this.valorcompra * this.desconto / 100);
        }
        public void exibirCashback()
        {
            Console.WriteLine("Cashback: {0}", this.cashback);
            this.cashback = double.Parse(Console.ReadLine());
        }

        public void calcularDesconto()
        {
            Console.WriteLine("Digite o desconto que deseja calcular");
            this.desconto = double.Parse(Console.ReadLine());
            this.desconto = (this.valorcompra * this.desconto / 100);
        }
        public void exibirDesconto()
        {
            Console.WriteLine("Desconto: {0}",this.desconto);
        }
    }
}
