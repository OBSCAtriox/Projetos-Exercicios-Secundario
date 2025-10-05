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



                Console.WriteLine("----");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|Portugues|EducacaoFisica|AreaIntegracao|");
                









           
            }









        }
    }
}



