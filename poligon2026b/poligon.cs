using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace poligon2026b
{
    class poligon
    {
        int br_temena;
        tacka[] teme;
        public poligon(int n)
        {
            br_temena = n;
            teme = new tacka[n];
        } 
        public static poligon Unos()
        {
            Console.WriteLine("Unesite broj temena:");
            int br = Convert.ToInt32(Console.ReadLine());
            poligon novi = new poligon(br);
            for(int i=0; i<br; i++)
            {
                Console.WriteLine("Teme A({0}).x=", i + 1);
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Teme A({0}).y=", i + 1);
                double y = Convert.ToDouble(Console.ReadLine());
                novi.teme[i] = new tacka(x, y);
            }
            return novi;
        }
        public void Stampa()
        {
            Console.WriteLine("Poligon sa " + br_temena + " temena:");
            for (int i = 0; i < br_temena; i++)
            {
                Console.WriteLine("x={0} y={1}", teme[i].x, teme[i].y);
            }
        }
        public void Snimi()
        {
            StreamWriter izlaz = new StreamWriter("poligon.txt");
            izlaz.WriteLine(br_temena);
            for (int i = 0; i < br_temena; i++)
            {
                izlaz.WriteLine(teme[i].x);
                izlaz.WriteLine(teme[i].y);
            }
            izlaz.Close();
        }
        
        public static poligon Ucitaj()
        {
            StreamReader ulaz = new StreamReader("poligon.txt");
            int br = Convert.ToInt32(ulaz.ReadLine());
            poligon novi = new poligon(br);
            for (int i = 0; i < br; i++)
            {
                double x = Convert.ToDouble(ulaz.ReadLine());
                double y = Convert.ToDouble(ulaz.ReadLine());
                novi.teme[i] = new tacka(x, y);
            }
            ulaz.Close();
            return novi;
        }
    }
}
