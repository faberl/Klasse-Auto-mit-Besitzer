using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Auto_mit_Besitzer
{
    class Program
    {
        //Main von Philipp Herbst inpliziert.
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen in der Fuhrparkverwaltung von Herbst und Erlacher.");
            GetCommadns();
        }

        public static void GetCommadns()
        {          
            bool succsess = true;
            do
            {
                Console.WriteLine("Geben Sie einen Befehl ein.");
                Console.WriteLine("Drücken Sie 'h' um alle Befehle zu sehen.");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "h": ShowAllCommands(); break;
                    case "H": ShowAllCommands(); break;
                    case "s": ShowAllCars(); break;
                    case "S": ShowAllCars(); break;
                    case "c": ListPrice(); break;
                    case "C": ListPrice(); break;
                    case "d": UpdateCarData(); break;
                    case "D": UpdateCarData(); break;
                    case "n": TimeToNextService(); break;
                    case "N": TimeToNextService(); break;
                    case "v": ValueOfCar(); break;
                    case "V": ValueOfCar(); break;
                    default: Console.WriteLine("Ungültige Eingabe!"); succsess = false; break;
                }
            } while (!succsess);
        }

        public static void ShowAllCommands()
        {
            Console.WriteLine("s: Zeigt alle Fahrzeuge an.");
            Console.WriteLine("c: Berechnet den Listenpreis ihres neuen Autos.");
            Console.WriteLine("d: Hier werden die akutellen Daten eines Fahrzeuges eingegeben.");
            Console.WriteLine("n: Hier wird die Zeit bis zum nächsten Service berechnet.");
            Console.WriteLine("v: Berechnet den aktuellen Wert Ihres Autos.");
            GetCommadns();
        }

        public static void ShowAllCars()
        {

        }

        public static void ListPrice()
        {

        }

        public static void UpdateCarData()
        {

        }

        public static void TimeToNextService()
        {

        }

        public static void ValueOfCar()
        {

        }
    }
}
