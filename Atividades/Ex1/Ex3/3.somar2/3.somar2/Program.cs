using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3.somar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Somar somar = new Somar();
            int num1;
            int num2;
            int resultado;
            Console.WriteLine("Insira um numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero");
            num2 = int.Parse(Console.ReadLine());
            resultado = somar.tomar(num1, num2);
            Console.WriteLine("A Soma é Igual á: {0}", resultado);
        }
    }
}
