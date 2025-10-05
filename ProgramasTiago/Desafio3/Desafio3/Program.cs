using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Potencia(4, 3));
            Console.ReadLine();

        }

        static int Potencia(int pownum, int basenum)
        {
            int i;
            int result = 1;
            for(i = 0; i<pownum; i++)
            {
                result = result + basenum;
                 
                 
            }
            return result;

        }
    }
}
