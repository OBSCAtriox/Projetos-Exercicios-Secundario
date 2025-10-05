using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças
{
    class SubClass : Principal // diz a classe que tem heranca da outra
    {
        public void Block()
        {
            Console.WriteLine("ataque bloqueado");
        }
        public override void Special() //permite mudar o valor de Special
        {
            Console.WriteLine("Usou especial");
        }
    }
}
