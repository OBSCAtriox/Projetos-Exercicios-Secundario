using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getters_setters
{
    class Site
    {
        public string nome;
        public string dono;
        private string estado;

        public Site(string umNome, string umDono, string umEstado)
        {
            nome = umNome;
            dono = umDono;
            Estado = umEstado;

        }
        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                if (value == "Online" || value == "Offline" || value == "Manutencao")
                {
                    estado = value;
                }

                else
           
                {
                    estado = "Offline";
                }
            }
        }
    }
}
