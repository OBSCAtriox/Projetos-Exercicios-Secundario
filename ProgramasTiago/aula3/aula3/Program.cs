using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Inteiros e Décimais");
            Console.WriteLine(5.0 + 2.5);
            Console.WriteLine(5 + 2.5);
            Console.WriteLine(5 / 2);
            Console.WriteLine(5 / 2.0);
            Console.WriteLine(9 % 5);

            Console.WriteLine("varáveis");
            int num = 5;
            Console.WriteLine(num);//substrai 1 á variável 
            num--;
            Console.WriteLine(num);//adiciona 1 á variável
            num++;
            Console.WriteLine(num);

            //Maths Methods
            Console.WriteLine(Math.Abs(-40));//absolute numeber distancia de -40 para 0
            Console.WriteLine(Math.Pow(3, 2));// 3 elevado a 2
            Console.WriteLine(Math.Sqrt(36));//Raiz quadrada
            Console.WriteLine(Math.Max(4, 90));// Higher number
            Console.WriteLine(Math.Min(4, 90));//lower number
            Console.WriteLine(Math.Round(3.5, MidpointRounding.ToEven));//aredonda para o número par mais próximo
            Console.WriteLine(Math.Round(3.5, MidpointRounding.AwayFromZero));//aredonda para o número mais próximo que esteja distante de Zero

            //User Input
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Age");
            string age = Console.ReadLine();
            Console.WriteLine("Hello" + name + "you're" + age);


            Console.ReadLine();
           

                }
    }
}
