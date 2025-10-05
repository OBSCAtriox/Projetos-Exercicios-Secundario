using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10_02_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pauta Escolar");

            Random random = new Random();
            for (int i = 0; i < 2; i++) ;
            {
                int n1 = random.Next(21);
                int n2 = random.Next(21);
                int n3 = random.Next(21);
                int n4 = random.Next(21);
                int n5 = random.Next(21);
                int n6 = random.Next(21);
                int n7 = random.Next(21);
                int n8 = random.Next(21);
                int n9 = random.Next(21);
                int n10 = random.Next(21);
                int n11 = random.Next(21);
                int n12 = random.Next(21);
                int n13 = random.Next(21);
                int n14 = random.Next(21);
                int n15 = random.Next(21);
                int n16 = random.Next(21);
                int n17 = random.Next(21);
                int n18 = random.Next(21);


                Portugues nota1 = new Portugues(n1, n2);
                nota1.nota1 = n1;
                nota1.nota2 = n2;
                EducacaoFisica nota2 = new EducacaoFisica(n3, n4);
                nota2.nota1 = n3;
                nota2.nota2 = n4;
                AreaIntegracao nota3 = new AreaIntegracao(n5, n6);
                nota3.nota1 = n5;
                nota3.nota2 = n6;
                FisicaQuimica nota4 = new FisicaQuimica(n7, n8);
                nota4.nota1 = n7;
                nota4.nota2 = n8;
                ArquiteturaPC nota5 = new ArquiteturaPC(n9, n10);
                nota5.nota1 = n9;
                nota5.nota2 = n10;
                PSI nota6 = new PSI(n11, n12);
                nota6.nota1 = n11;
                nota6.nota2 = n12;
                Redes nota7 = new Redes(n13, n14);
                nota7.nota1 = n13;
                nota7.nota2 = n14;
                Ingles nota8 = new Ingles(n15, n16);
                nota8.nota1 = n15;
                nota8.nota2 = n16;
                Matematica nota9 = new Matematica(n17, n18);
                nota9.nota1 = n17;
                nota9.nota2 = n18;

               






                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|--------------------------------|");
                Console.WriteLine("||||||||||Pauta Escolar|||||||||||");
                Console.WriteLine("|--------------------------------|");

                Console.ForegroundColor = ConsoleColor.White;
            


                Console.WriteLine("|--------------------------------|");
                Console.WriteLine("|Portugues            |" + Cor(media(n1, n2)) + "|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|EducacaoFisica       |" + Cor(media(n3, n4)) + "|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|AreaIntegracao       |" + Cor(media(n5, n6)) + "|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|FisicaQuimica        |" + Cor(media(n7, n8)) + "|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|ArquiteturaComputador|" + Cor(media(n9, n10)) + "|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|PSI                  |" + Cor(media(n11, n12)) + "|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|Redes                |" + Cor(media(n13, n14)) + "|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|Ingles               |" + Cor(media(n15, n16)) + "|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|Matematica           |" + Cor(media(n17, n18)) + "|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|--------------------------------|");

                int not1 = media(n1, n2);
                int not2 = media(n3, n4);
                int not3 = media(n5, n6);
                int not4 = media(n7, n8);
                int not5 = media(n9, n10);
                int not6 = media(n11, n12);
                int not7 = media(n13, n14);
                int not8 = media(n15, n16);
                int not9 = media(n17, n18);
                Console.WriteLine("A Média Geral é: " + Cor(Mediageral(not1, not2, not3, not4, not5, not6, not7, not8, not9)));
                Console.ForegroundColor = ConsoleColor.White;
                int bolsa = Mediageral(not1, not2, not3, not4, not5, not6, not7, not8, not9);
                if (bolsa > 15)
                {
                    Console.WriteLine("Você tem direito á bolsa escolar. Para mais informações contactar o/a diretor/a de turma");
                }
                else
                {
                    Console.WriteLine("Você não tem direito á bolsa escolar");
                }
                Console.WriteLine("Gostaria de ver as notas dos testes ? Se sim digite sim se não digite nao");
              string decisao = Console.ReadLine();
                switch(decisao)
                {
                    case "sim":
                        Console.WriteLine("Notas de Portugues:  " + nota1.nota1 + " e " + nota1.nota2);
                        Console.WriteLine("Notas de Educacao Fisica: " + nota2.nota1 + " e " + nota2.nota2);
                        Console.WriteLine("Notas de AreaIntegracao:  " + nota3.nota1 + " e " + nota3.nota2);
                        Console.WriteLine("Notas de Fisica e Quimica:  " + nota4.nota1 + " e " + nota4.nota2);
                        Console.WriteLine("Notas de Arquitetura de Computadores:  " + nota5.nota1 + " e " + nota5.nota2);
                        Console.WriteLine("Notas de PSI:  " + nota6.nota1 + " e " + nota6.nota2);
                        Console.WriteLine("Notas de Redes:   " + nota7.nota1 + " e " + nota7.nota2);
                        Console.WriteLine("Notas de Ingles:  " + nota8.nota1 + " e " + nota8.nota2);
                        Console.WriteLine("Notas de matematica:  " + nota9.nota1 + " e " + nota9.nota2);
                        break;
                    case "nao":
                        Console.ReadLine();
                        Console.Clear();
                        break;

                }






            }
            Console.ReadLine();










        }
        static int media(int num1, int num2)
        {
            int resultado = (num1 + num2) /2 ;
            
            return resultado;
        }
        static int Mediageral(int num1, int num2, int num3, int num4,int num5, int num6, int num7, int num8, int num9 )
        {
            int resultado = (num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9) / 9;
            return resultado;
        }
        static int Cor(int result)
        {
            if (result > 9)
            {
               Console.ForegroundColor = ConsoleColor.Green;
                
            }
            else
            {
               Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            return result;

        }
            
            
            
                
            
                
            
                
         
          
            
                
        
        
            
          
        
      
            
        }
    }






