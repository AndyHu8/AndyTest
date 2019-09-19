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
            int Fall = 1;

            switch (Fall)
            {
                case 1:
                    Console.WriteLine("Fall 1");
                    break;
                case 2:
                    Console.WriteLine("Fall 2");
                    break;
                case 3:
                    Console.WriteLine("Fall 3");
                default:
                    Console.WriteLine("Ein Fehler ist aufgetreten");
                    break;
            }

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
            int zahl = 0;
            while (zahl < 50)
            {
                Console.WriteLine(zahl);
                zahl++;
            }

            //NORMALE BERECHNUNGEN
            int ersteZahl = 10;
            int zweiteZahl = 3;
            Console.WriteLine(ersteZahl + zweiteZahl);
            Console.WriteLine(ersteZahl - zweiteZahl);
            Console.WriteLine(ersteZahl / zweiteZahl);
            Console.WriteLine(ersteZahl * zweiteZahl);
            Console.WriteLine(ersteZahl % zweiteZahl);
        }

            //OBJEKTORIENTE PROGRAMMIERUNG
            public class Hund
            {
            public string Name;
            public DateTime Bday;
            public bool IstBissig;

            public string Bellen()
            {
                return "Wuff";
            }

            }
            
    

        
    }
}
