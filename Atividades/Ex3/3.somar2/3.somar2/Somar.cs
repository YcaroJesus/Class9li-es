using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.somar2
{
    internal class Somar
    {
        public int tomar() 
        {
            Console.WriteLine("Insira um numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 + num2;
            Console.WriteLine("A Soma é Igual á:{0}", resultado);

            return resultado;
        }
    }
}
