using System;

namespace diesdas
{
    class Program
    {
        static void Main(string[] args)
        {
            //AUSGABE
            Console.WriteLine("Hello World!");

            //IF - ELSE
            bool eiskalt = true;
            bool esregnet = true;
            bool istWinter = eiskalt && esregnet;

            if (eiskalt == false)
            {
                Console.WriteLine("EISKALT!");
            }
            else if (esregnet == false)
            {
                Console.WriteLine("ESREGNET!");
            }
            else if (istWinter == true)
            {
                Console.WriteLine("ES IST WINTER");
            }
            else Console.WriteLine("KEINS VON DENEN AMK!");

            //SWITCH-STATEMENT

            //ARRAY
            int[] listeVonZahlen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(listeVonZahlen[9]);

            //FOR SCHLEIFE
            int zahl;
            for (zahl = 0; zahl < 100; zahl++)
            {
                Console.WriteLine(zahl + 1);
            }

            //WHILE SCHLEIFE

            //NORMALE BERECHNUNGEN
            int ersteZahl = 10;
            int zweiteZahl = 3;
            Console.WriteLine(ersteZahl + zweiteZahl);
            Console.WriteLine(ersteZahl - zweiteZahl);
            Console.WriteLine(ersteZahl / zweiteZahl);
            Console.WriteLine(ersteZahl * zweiteZahl);
            Console.WriteLine(ersteZahl % zweiteZahl);

            //OBJEKTORIENTE PROGRAMMIERUNG


        }
    }
}
