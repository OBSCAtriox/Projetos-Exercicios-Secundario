using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 numero de 1 a 100");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Para ver seus resultados prima enter");
            Console.ReadLine();
            
            while (index<=100)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.ReadLine();
        }
    }
}
