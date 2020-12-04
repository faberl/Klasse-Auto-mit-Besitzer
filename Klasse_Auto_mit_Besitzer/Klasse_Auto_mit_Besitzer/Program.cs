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
            bool yesOrNo = false;

            Console.WriteLine("Willkommen in der Fuhrparkverwaltung von Herbst und Erlacher.");
            GetCommadns();

            do
            {
                Console.WriteLine("Möchten Sie weitere Aktionen tätigen? y/n.");
                string anotherTry = Console.ReadLine();

                switch (anotherTry)
                {
                    case "y": GetCommadns(); break;
                    case "Y": GetCommadns(); break;
                    case "n": yesOrNo = true; break;
                    case "N": yesOrNo = true; break;
                    default: Console.WriteLine("Ungültige Eingabe!"); break;
                }
            } while (!yesOrNo);
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
                    case "c": InsertNewCar(); break;
                    case "C": InsertNewCar(); break;
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
            Car print = new Car();
            print.PrintAllCars();
        }

        public static void InsertNewCar()
        {
            Console.WriteLine("Die Personen ID eingeben.");
            string personID = Console.ReadLine();
            Console.WriteLine("Den Listenpreis eingeben.");
            string listPrice = Console.ReadLine();
            Console.WriteLine("Den Kilometerstand eingeben.");
            string mileage = Console.ReadLine();
            Console.WriteLine("Baujahr eingeben.");
            string constructionYear = Console.ReadLine();
            Console.WriteLine("Farbe eingeben.");
            string color = Console.ReadLine();

            int.TryParse(personID, out int convertedPersonID);
            double.TryParse(listPrice, out double convertedListPrice);
            int.TryParse(mileage, out int convertedMileAge);
            int.TryParse(constructionYear, out int convertedConstructionYear);

            Car newCar = new Car(convertedMileAge, convertedConstructionYear, convertedListPrice, color, convertedPersonID);
        }

        public static void UpdateCarData()
        {
            Console.WriteLine("Die gefahrenen Kilomenter eingeben.");
            string newMileAge = Console.ReadLine();
            int.TryParse(newMileAge, out int newMileAgeConverted);

            Car mileAge = new Car();
            mileAge.[... fehlt nocht](newMileAgeConverted);
        }

        public static void TimeToNextService()
        {
            Console.WriteLine("Die Auto-ID eingeben.");
            string carID = Console.ReadLine();

            int.TryParse(carID, out int carIDconverted);

            Car nextService = new Car();
            nextService.TimeToNextService(carIDconverted);
        }

        public static void ValueOfCar()
        {

        }
    }
}
