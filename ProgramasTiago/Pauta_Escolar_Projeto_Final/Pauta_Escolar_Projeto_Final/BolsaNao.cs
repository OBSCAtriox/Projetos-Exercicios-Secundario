using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pauta_Escolar_Projeto_Final
{
    internal class BolsaNao : Bolsa
    {
        public override string SimNao()
        {
            string Nao = "Não tem direito á bolsa escolar";
            return Nao;
        }




    }
}
