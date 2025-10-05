using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 0 a 6 que correspondem a um dia da semana");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(VerDia(n1));
            Console.ReadLine();


            


        }
        static string VerDia(int DiaNum)
        {
            string DiaNome;
            switch(DiaNum)
            {
                case 0:
                    DiaNome = "Domingo";
                    break;
                case 1:
                    DiaNome = "Segunda";
                    break;
                case 2:
                    DiaNome = "Terça";
                    break;
                case 3:
                    DiaNome = "Quarta";
                    break;
                case 4:
                    DiaNome = "Quinta";
                    break;
                case 5:
                    DiaNome = "Sexta";
                    break;
                case 6:
                    DiaNome = "Sábado";
                    break;
                default:
                    DiaNome = "Numero invalido";
                    break;
            }
            return DiaNome;
        }
            
        



               

        }
    }
