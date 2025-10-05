using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool istall = true;
            bool isalmada = true;
            bool istudent = true;
            bool isalmada2 = false;
            bool istudent2 = false;
            bool isalmada3 = false;
            bool istudent3 = true;

            if (istall)
            {
                Console.WriteLine("You´re tall");

            }else
            {
                Console.WriteLine("You´re not tall");
            }
            Console.ReadLine();
            if (isalmada && istudent)
            {
                Console.WriteLine("És um estudante de Almada");

            }else
            {
                Console.WriteLine("Não és estudante ou não és de Almada ou ambos");
            }
            if (isalmada2 ||  istudent2)
            {
                Console.WriteLine("És estudante ou és de Almada ou ambos");
            }else
            {
                Console.WriteLine("Não és estudante de Almada");
            }
            Console.ReadLine();
            if (isalmada3 && istudent)
            {
                Console.WriteLine("És estudante de Almada");

            }else if(isalmada3 && !istudent3)
            {
                Console.WriteLine("És de Almada mas não és estudante");
            }else if (isalmada3 && istudent3)
            {
                Console.WriteLine("Não és de Almada mas és estudante");

            }
            else
            {
                Console.WriteLine("Não és estudante e não és de Almada");
            }


                
            Console.ReadLine();
           
        }
    }
}
