using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 40.30;
            double numero2 = 30.56;
            int[] numeros = new int [5];
            string[] players = new string[5];

            Console.WriteLine(Math.Max(numero1, numero2));
            Console.WriteLine(Math.Min(numero1, numero2));
            Console.WriteLine(Math.Cos(numero1));
            Console.WriteLine(Math.Sin(numero2));
            Console.WriteLine(Math.Sqrt(numero2));
            Console.WriteLine(Math.Tan(numero1));

            Console.WriteLine("Digite um número");
            numeros[0] = Convert.ToInt16(numeros[0]);
          
            Console.WriteLine(numeros[0]);

            Console.WriteLine("Digite 5 nomes de jogadores de futeból");
            players[0] = Console.ReadLine();
            players[1] = Console.ReadLine();
            players[2] = Console.ReadLine();
            players[3] = Console.ReadLine();
            players[4] = Console.ReadLine();
            Console.WriteLine("Aqui estão os jogadores que escolheu respetivamente");
            Console.WriteLine(players[0]);
            Console.WriteLine(players[1]);
            Console.WriteLine(players[2]);
            Console.WriteLine(players[3]);
            Console.WriteLine(players[4]);
           
            

            Console.ReadLine();
            
            
        }
    }
}


//Arraiz
/*int[] luckyNumbers = ( 8, 2, 9, 5, 22, 90, 105, 60);
 * string[] players = new string[5]; (guarda 5 valores)
 * 
 * Console.WriteLine(luckynNumbers[0]);
 * 
 * luckyNumbers[1] = 1000; (muda o valor da variavel escolhida)
 * 
 * Console.WriteLine(luckyNumbers[1]);
 * 
 * players[0] = "Ronaldo"
 * players[1] = "Messi"
 * players[2] = "Mbappe"
 * players[3] = "Levandoski"
 * players[4] = "neymar"
 * 
 * Console.WriteLine(players[4]);
 * 
 * Console.ReadLine();*/
 
