using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.AntecessorSucessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            suAn suceante = new suAn();
            int ante;
            int suce;
            int num;
            Console.WriteLine("Digite um Numero");
            num = int.Parse(Console.ReadLine());
            ante = suceante.antecesor(num);
            suce = suceante.Sucessor(num);
            Console.WriteLine("Antecessor: {0}", ante);
            Console.WriteLine("Numero: {0}", num);
            Console.WriteLine("Sucessor: {0}", suce);
        }
    }
}
