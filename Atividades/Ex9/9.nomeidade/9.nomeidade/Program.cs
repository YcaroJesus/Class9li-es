using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.nomeidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome;
            bemvindo boasvindas = new bemvindo();
            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());
            boasvindas.vindo(idade, nome);
        }
    }
}
