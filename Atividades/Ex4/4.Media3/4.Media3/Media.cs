using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Media3
{
    internal class Media
    {
        public float Calculo() 
        {
            Console.WriteLine("Insira uma nota");
            float num1=float.Parse(Console.ReadLine());
            Console.WriteLine("Insira uma nota");
            float num2=float.Parse(Console.ReadLine());
            Console.WriteLine("Insira uma nota");
            float num3=float.Parse(Console.ReadLine());
            float resultado = (num1 + num2 + num3) / 3;
            if(resultado >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }

            return resultado;

        }
    }
}
