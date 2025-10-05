using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_e_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            
            Jogo jogo1 = new Jogo("Halo Master Chief Collection", "FPS", 9000);
            Jogo jogo2 = new Jogo("Grand Thef Auto 5", "RockStar", 90000);
            jogo1.title = "HALO 5";
            Console.WriteLine(jogo1.title);
            Console.WriteLine(jogo2.genre);
            

            Console.WriteLine(jogo1.BreaKeven());
            Console.WriteLine(jogo2.BreaKeven());
            Console.WriteLine(jogo1.WhichGenre());
            Console.WriteLine(jogo2.WhichGenre());

            Console.ReadLine();

        }
    }
}
