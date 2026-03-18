using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OlaNome
{
    internal class Nome
    {
        public void classe()
        {
            Console.WriteLine("Insira Seu Nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Olá {0}", nome);
        }
    }
}
