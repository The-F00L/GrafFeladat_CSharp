using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafFeladat_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var graf = new Graf(6);

            graf.Hozzaad(0, 1);
            graf.Hozzaad(1, 2);
            graf.Hozzaad(0, 2);
            graf.Hozzaad(2, 3);
            graf.Hozzaad(3, 4);
            graf.Hozzaad(4, 5);
            graf.Hozzaad(2, 4);


            Console.WriteLine(graf);


            Console.WriteLine("\n");
            Console.WriteLine("Szélességi:");
            graf.SzelessegiBejar(3);
            Console.WriteLine("\n");
            Console.WriteLine("Mélységi:");
            graf.MelysegiBejar(5);
            Console.WriteLine("\n");
            Console.Write("Összefüggőség:");
            if (graf.Osszefuggo() == true)
            {
                Console.WriteLine(" Összefüggő.");
            }
            else
            {
                Console.WriteLine(" Nem összefüggő.");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Feszítőfa: ");
            graf.Feszitofa();
           // Console.WriteLine("\n");
           //Console.WriteLine("Mohoszinezes: ");
           //graf.Mohoszinezes()...;   HIBÁS


            Console.ReadLine();
        }
    }
}
