using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026b
{
    class Program
    {
        static void Main(string[] args)
        {
            /*poligon prvi = poligon.Unos();
            prvi.Stampa();*/

            /*poligon prvi = poligon.Unos();
            prvi.Stampa();
            prvi.Snimi();*/

            poligon drugi = poligon.Ucitaj();
            drugi.Stampa();
            Console.ReadKey();
        }
    }
}
