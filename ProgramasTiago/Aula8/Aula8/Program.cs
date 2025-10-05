using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavrasecreta = "programar";
            string tentativa = "";
            int contador = 0;
            int limiteContador = 3;
            bool semTentativas = false;
            while(tentativa != palavrasecreta && !semTentativas)
            {
                if(contador < limiteContador)
                {
                    Console.Write("Inserir tentativa");
                    tentativa = Console.ReadLine();
                    contador++;

                }
                else
                {
                    semTentativas = true;
                }
            }
            if(semTentativas)
            {
                Console.Write("Perdeu");
            }
            else
            {
                Console.Write("Ganhou");
            }
            Console.ReadLine();

          

        }

    }
}
