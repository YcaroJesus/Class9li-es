using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.nomeidade
{
    internal class bemvindo
    {
        public void vindo()
        {
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Bem Vindo(a) {0}, {1} anos",nome,idade);
        }
    }
}
