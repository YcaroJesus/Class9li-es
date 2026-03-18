using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Dolar
{
    class conversor
    {
        public void Converter()
        {
            Console.Write("Digite o valor em dólares: ");
            float dolar = float.Parse(Console.ReadLine());
            float taxa = 5.4f;
            float real = dolar * taxa;
            Console.WriteLine("Valor em reais: R${0}",real);
        }
    }
}
