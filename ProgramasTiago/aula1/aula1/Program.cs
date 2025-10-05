using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            string charactername = "Jackie";
            int characterAge = 35;
            double decimalnumber = 5.99;
            bool raining = false;

            Console.WriteLine("Era uma vez uma vaca");
            Console.WriteLine("Ela tinha " + characterAge);
            charactername = "Michel";
            Console.WriteLine("Ele adorou o nome" + charactername);
            Console.WriteLine("Mas não gostou de ter" + characterAge);
            Console.WriteLine(decimalnumber);

            Console.ReadLine();
;
        }
    }
}
