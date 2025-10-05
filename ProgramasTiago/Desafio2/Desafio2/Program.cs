using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esnter a Number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter anotehr number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetMax(n1, n2, n3));
            Console.ReadLine();

        }
        static int GetMax(int num1, int num2, int num3)

        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;

            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;

            }
            else
            {
                result = num3;
            }
            return result;













        }

    }
}