using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getters_setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Site record = new Site("Record", "Cofina", "teste");
            Site sapo = new Site("Sapo", "Empresa Sapo", "Online");

            //definir valores especificos, cortar acesso para forçar valores que deseja
            //online, Ofline, manutenção

            Console.WriteLine(record.Estado);
            Console.WriteLine(sapo.Estado);
            Console.ReadLine();
        }
    }
}
