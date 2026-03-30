using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Media3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            float resultado;
            Media media = new Media();
            Console.WriteLine("Insira uma nota");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira uma nota");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira uma nota");
            num3 = int.Parse(Console.ReadLine());
            resultado = media.Calculo(num1,num2,num3);
            if (resultado >= 7)
            {
                Console.WriteLine("Seu numero foi: {0} Aprovado!", resultado);
            }
            else
            {
                Console.WriteLine("Seu numero foi: {0} Reprovado!", resultado);
            }

        }
    }
}
