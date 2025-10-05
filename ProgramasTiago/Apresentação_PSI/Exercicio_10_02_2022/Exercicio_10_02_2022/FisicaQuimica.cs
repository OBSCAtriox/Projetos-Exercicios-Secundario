using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10_02_2022
{
    internal class FisicaQuimica
    {
        public int nota1;
        public int nota2;


        public FisicaQuimica(int anota1, int anota2)
        {
            nota1 = anota1;
            nota2 = anota2;
        }


        public void FQ()
        {
            if (nota1 <= 20 && nota2 <= 20)
            {
                Console.WriteLine((nota1 + nota2) / 2);
            }
            else
            {
                Console.WriteLine("Valores Invalidos");
            }

        }
    }
}
