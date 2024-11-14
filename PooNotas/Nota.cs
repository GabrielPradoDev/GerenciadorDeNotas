using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooNotas
{
    public class Nota
    {
        public string Descricao { get ; set; }

        public void Exibir()
        {
            Console.WriteLine(Descricao);
            Console.WriteLine("---------------------------------");
        }
    }
}
