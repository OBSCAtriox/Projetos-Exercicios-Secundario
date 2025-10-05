using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int n1 = Convert.ToInt32(Console.ReadLine());
            for(int i = n1; i <=10; i++ )
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
