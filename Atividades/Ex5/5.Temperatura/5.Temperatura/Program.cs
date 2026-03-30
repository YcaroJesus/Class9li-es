using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Celsius;
            float Fahrenheit;
            Temperatura Calculo = new Temperatura();
            Console.WriteLine("Insira uma temperatura em Celsius");
            Celsius = float.Parse(Console.ReadLine());
            Fahrenheit = Calculo.celsius(Celsius);
            Console.WriteLine("{0} Fahrenheit", Fahrenheit);
        }
    }
}
