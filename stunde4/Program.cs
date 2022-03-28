using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stunde4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arbeiten mit string.");
            string wiederholen;

            do
            {
                //Menü
                int auswahl;
                Console.WriteLine("1: zeichnen ersetzen.");
                Console.WriteLine("2: Vokale entfernen.");
                Console.WriteLine("3: Beenden.");

                Console.Write("Auswahl");
                auswahl = Convert.ToInt32( Console.ReadLine() );

                switch(auswahl)
                {
                    case  1:
                        Console.WriteLine("1: zeichnen ersetzt werden.");
                        string zuErsetzen, zeichen, ersatz; ;
                        Console.WriteLine("zeichenkette eingeben:");
                        zuErsetzen = Console.ReadLine();
                        Console.WriteLine("Welches Zeichen soll ersetzt werden?");
                        zeichen = Console.ReadLine();
                        Console.WriteLine("Wodurch soll" + zeichen + "ersetzt werden?");
                        ersatz = Console.ReadLine();
                        Console.WriteLine("Es wird " + zeichen + " durch " + ersatz + " ersetzt:");

                        string ersetzt = "";
                        ersetzt = zuErsetzen.Replace(zeichen, ersatz);
                        //for (int i = 0; i < zuErsetzen.Length; i++)
                        //{
                        //    if(zuErsetzen[i].ToString() == zeichen )
                        //    {
                        //        ersetzt += ersatz;
                        //    }
                        //    else
                        //    {
                        //        ersetzt += zuErsetzen[i];

                        //    }

                        //}
                        Console.WriteLine(zuErsetzen + " wird zu " + ersetzt);







                        break;
                     case 2:
                        Console.WriteLine("2: Vokale entfernen.");
                        string zeichenkette;
                        Console.WriteLine("zeichenkette eingeben:");
                        zeichenkette = Console.ReadLine();
                        string ergebnis = "";



                        Console.WriteLine(zeichenkette + " wird zu " + ergebnis);
                        break;
                     case 3:
                        Console.WriteLine("3:Programm wird beendet.");
                        


                        break;


                     default:
                        Console.WriteLine("Auswahl ungültig.");


                        break;

                }
                Console.WriteLine("Neue Auswahl? (j/n)");
                wiederholen = Console.ReadLine();

            } while (wiederholen == "j" || wiederholen == "J");
        }
    }
}
