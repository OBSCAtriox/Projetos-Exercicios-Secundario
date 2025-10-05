using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacic_classes_atributes
{
    static class StaticClass //para nao mermitir criar novos objetos
    {
        public static void Hello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
