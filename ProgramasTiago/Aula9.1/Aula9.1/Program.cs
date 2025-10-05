using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i<=5; i++)
            {
                Console.WriteLine(i);
            }
            int[] numeros = { 2, 6, 14, 17, 89, 99 };
            for (int i = 0; i < numeros.Length; i++ )
            {
                Console.WriteLine(numeros[i]);
            }
            Console.ReadLine();
        }
    }
}
