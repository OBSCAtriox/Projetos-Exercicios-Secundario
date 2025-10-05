using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_e_Metodos
{
    internal class Jogo
    {
        public string title;
        public string genre;
        public int sales;

        public Jogo(string atitle, string agenre, int asales) 
        {
            title = atitle;
            genre = agenre;
            sales = asales;



        }
        public bool BreaKeven()
        {
            if (sales >= 10000)
            {
                return true;
            }
            return false;
        }
        public string WhichGenre()
        {
            string ChangeGenre = "Change Genre";
            string CorrectGenre = "Correct Genre";
            if (ChangeGenre == "FPS")
            {
                return ChangeGenre;
            }
            return CorrectGenre;
        }
    }
}
