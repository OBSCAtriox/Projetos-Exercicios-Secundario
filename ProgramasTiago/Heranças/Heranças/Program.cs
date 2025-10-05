using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças
{
    class Program
    {
        static void Main(string[] args)
        {
            Principal principal1 = new Principal();
            principal1.Auto();
            principal1.Special();

            SubClass subclass1 = new SubClass();
            subclass1.Auto();
            subclass1.Special();
            subclass1.Block();

            Console.ReadLine();
        }
    }
}
