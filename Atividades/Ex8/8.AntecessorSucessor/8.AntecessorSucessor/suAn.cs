using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.AntecessorSucessor
{
    internal class suAn
    {
        public int antecesor(int n) 
        {
            int ante = n - 1;
            return ante;
        }
        public int Sucessor(int n)
        {
            int suce = n + 1;
            return suce;
        }
    }
}
