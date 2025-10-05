using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string anos;
            string escola;
            string disciplinaA;
            string disciplinaB;
            Console.WriteLine("Complete a seguinte frase");
            Console.WriteLine("Óla eu sou o _________ tenho ___________ anos e tenho aulas na escola _____________ . A Minha disciplina favorita é ____________ e a que menos gosto é ____________");
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Nome:" + nome);
            Console.WriteLine("Digite a sua idade:");
            anos = Console.ReadLine();
            Console.WriteLine("Idade:" + anos);
            Console.WriteLine("Digite o nome da sua Escola");
            escola = Console.ReadLine();
            Console.WriteLine("Escola:" + escola);
            Console.WriteLine("Digite a sua disciplina favorita");
            disciplinaA = Console.ReadLine();
            Console.WriteLine("Disciplina favorita:" + disciplinaA);
            Console.WriteLine("Digite a sua disciplina que menos gosta");
            disciplinaB = Console.ReadLine();
            Console.WriteLine("Disciplina que menos gosta:" + disciplinaB);
            
            Console.WriteLine("Aqui está a frase completada");

            Console.WriteLine("Óla eu sou o " + nome + " tenho " + anos + " anos e tenho aulas na escola " + escola + ". A Minha disciplina favorita é " + disciplinaA + " e a que menos gosto é " + disciplinaB + ".");

            

            
            
            
            Console.ReadLine();

        }
    }
}
