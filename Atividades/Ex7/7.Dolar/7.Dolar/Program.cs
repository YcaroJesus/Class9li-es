using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            conversor coins = new conversor();
            float real;
            float dolar;

            Console.Write("Digite o valor em dólares: ");
            dolar = float.Parse(Console.ReadLine());
            real = coins.taxa(dolar);
            Console.WriteLine("Valor em reais: R${0}", real);
        }
    }
}
