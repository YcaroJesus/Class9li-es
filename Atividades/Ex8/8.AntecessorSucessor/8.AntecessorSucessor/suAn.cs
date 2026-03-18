using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.AntecessorSucessor
{
    internal class suAn
    {
        public void antecesorSucessor() 
        {
            Console.WriteLine("Digite um Numero");
            int num = int.Parse(Console.ReadLine());
            int ante = num - 1;
            int suce = num + 1;
            Console.WriteLine("Antecessor: {0}",ante);
            Console.WriteLine("Numero: {0}",num);
            Console.WriteLine("Sucessor: {0}",suce);
        }
    }
}
