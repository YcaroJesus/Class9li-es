using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Temperatura
{
    internal class Temperatura
    {
        public float celsius()
        {
            Console.WriteLine("Insira uma temperatura em Celsius");
            float Celsius = float.Parse(Console.ReadLine());
            float Fahrenheit = Celsius * 9 / 5 + 32;
            Console.WriteLine("{0} Fahrenheit", Fahrenheit);
                return Fahrenheit;
        }
    }
}
