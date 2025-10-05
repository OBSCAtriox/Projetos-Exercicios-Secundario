using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacic_classes_atributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fruta.quantidade);
            Fruta maca = new Fruta("TipoA");
            Console.WriteLine(Fruta.quantidade);
            Fruta pera = new Fruta("TipoB");
            Console.WriteLine(Fruta.quantidade);

            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");

            Console.WriteLine("Digite seu nome");
            string n = Console.ReadLine();
            StaticClass.Hello(n);
            Console.ReadLine();
        }
    }
}
