using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro();
            livro1.Titulo = "Harry Poter";
            livro1.autor = "JK Rowling";
            livro1.paginas = 400;

            Livro livro2 = new Livro();
            livro2.Titulo = "Seigneur des Aneaux";
            livro2.autor = "Tolkein";
            livro2.paginas = 700;

            Console.WriteLine(livro1.paginas);
            Console.WriteLine(livro2.autor);

            Console.ReadLine();


        }
    }
}
