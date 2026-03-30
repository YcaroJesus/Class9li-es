using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Dobro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int dobrado;
            dobrar dobre = new dobrar();
            Console.WriteLine("Insira um Numero");
            num1 = int.Parse(Console.ReadLine());
            dobrado = dobre.dobro(num1);
            Console.WriteLine("O Numero Dobrado: {0}", dobrado);
        }
    }
}
