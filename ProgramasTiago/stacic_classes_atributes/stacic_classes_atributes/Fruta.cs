using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacic_classes_atributes
{
    class Fruta
    {
        public string tipo_fruta;
        public static int quantidade = 0;


        public Fruta(string umtipo_fruta)
        {
            tipo_fruta = umtipo_fruta;
            //sempre que e adicionada uma fruta este method e chamado garantidamente
            quantidade++;
        }
    }
}
