using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Auto_mit_Besitzer
{
    class Program
    {
        static Person[] personArray = new Person[10000000];
        static Car[] carArray = new Car[10000000];
        static Person[] ownerHistoryArray = new Person[10];
        static int curCarNum = -1; 
        static int curHistoryNu = 0;
        static void createNewPersons()
        {           
            personArray[0] = new Person("Muster0", "Mayr0", 0, 28);
            personArray[1] = new Person("Muster1", "Mayr1", 1, 20);          
            personArray[2] = new Person("Muster2", "Mayr2", 2, 21);           
            personArray[3] = new Person("Muster3", "Mayr3", 3, 22);          
            personArray[4] = new Person("Muster4", "Mayr4", 4, 23);           
            personArray[5] = new Person("Muster5", "Mayr5", 5, 24);            
            personArray[6] = new Person("Muster6", "Mayr6", 6, 25);         
            personArray[7] = new Person("Muster7", "Mayr7", 7, 26);          
            personArray[8] = new Person("Muster8", "Mayr8", 8, 27);           
            personArray[9] = new Person("Muster9", "Mayr9", 9, 28);           
            personArray[10] = new Person("Muster10", "Mayr10", 10, 29);
        } 

        //Main von Philipp Herbst inpliziert.
        static void Main(string[] args)
        {
            bool yesOrNo = false;

            createNewPersons();

            Console.WriteLine("Willkommen in der Fuhrparkverwaltung von Herbst und Erlacher.");
            GetCommands();

            //query of another operation
            do
            {
                Console.WriteLine("Möchten Sie weitere Aktionen tätigen? y/n.");
                string anotherTry = Console.ReadLine();

                switch (anotherTry)
                {
                    case "y": GetCommands(); break;
                    case "Y": GetCommands(); break;
                    case "n": yesOrNo = true; break;
                    case "N": yesOrNo = true; break;
                    default: Console.WriteLine("Ungültige Eingabe!"); break;
                }
            } while (!yesOrNo);
        }

        //input of commands
        public static void GetCommands()
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

        //Shows all commands
        public static void ShowAllCommands()
        {
            Console.WriteLine("s: Zeigt alle Fahrzeuge an.");
            Console.WriteLine("c: Legt ein neuen Autos an.");
            Console.WriteLine("d: Hier werden die akutellen Daten eines Fahrzeuges eingegeben.");
            Console.WriteLine("n: Hier wird die Zeit bis zum nächsten Service berechnet.");
            Console.WriteLine("v: Berechnet den aktuellen Wert Ihres Autos.");
            GetCommands();
        }

        //shows all cars
        public static void ShowAllCars()
        {
            if (curCarNum == -1)
            {
                int j = 1;
                for (int i = 0; i <= curCarNum; i++)
                {
                    Console.WriteLine("{0}) {1}", j++, carArray[i].Print());
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Es befinden sich keine Autos in der Verwaltung");
            }
        }

        //generates a new car
        public static void InsertNewCar()
        {           
            int personID;
            double convertedListPrice;
            int convertedMileAge;
            int convertedConstructionYear;
            System.DateTime date = DateTime.Now;
            int year = date.Year;
            bool check = false;

            do
            {
                Console.WriteLine("Die Personen ID eingeben.");
                check = int.TryParse(Console.ReadLine(), out personID);
            } while (!check);

            do
            {
                Console.WriteLine("Den Listenpreis eingeben.");
                double.TryParse(Console.ReadLine(), out convertedListPrice);
            } while (convertedListPrice < 0 || convertedListPrice > 100000);

            do
            {
                Console.WriteLine("Den Kilometerstand eingeben.");
                int.TryParse(Console.ReadLine(), out convertedMileAge);
            } while (convertedMileAge > 1000000 || convertedMileAge < 0);

            do
            {
                Console.WriteLine("Baujahr eingeben.");
                int.TryParse(Console.ReadLine(), out convertedConstructionYear);
            } while (convertedConstructionYear > year || convertedConstructionYear < 0);

            Console.WriteLine("Farbe eingeben.");
            string color = Console.ReadLine();

            
            carArray[++curCarNum] = new Car(convertedMileAge, convertedConstructionYear, convertedListPrice, color, personArray[personID]);
            FillHistory(personArray[personID], personID);
            if (curCarNum == carArray.Length)
            {
                Console.WriteLine("Der Fuhrpark ist nun voll, es können keine zusätzlichen Autos mehr hinzugefügt werden");
            }
            else
            {
                Console.WriteLine("Die AutoID des neuen Autos lautet: " + curCarNum );
            }
        }

        //query if the customer would like update the owner or the mile age
        public static void UpdateCarData()
        {
            int desicion;

            Console.WriteLine("Möchten Sie den Besitzer des Autos ändern (1) oder den Kilometerstand aktuallisieren(2)?");
            int.TryParse(Console.ReadLine(), out desicion);

            switch (desicion)
            {
                case 1: ChangeOwner(); break;
                case 2: ChangeMileAge(); break;
                default: UpdateCarData(); break;
            }
        }

        //Update mile age
        public static void ChangeMileAge()
        {
            int newMileAgeConverted;
            int carIDconverted;
            do
            {
                Console.WriteLine("Die gefahrenen Kilomenter eingeben.");
                string newMileAge = Console.ReadLine();
                int.TryParse(newMileAge, out newMileAgeConverted);
            } while (newMileAgeConverted < 0 || newMileAgeConverted > 1000000);

            do
            {
                Console.WriteLine("Die Auto-ID eingeben.");
                string carID = Console.ReadLine();
                int.TryParse(carID, out carIDconverted);
            } while (carIDconverted < 0 || carIDconverted > 10);

            int newKm = carArray[carIDconverted].Drive(newMileAgeConverted);

            Console.WriteLine("Die Kilometeranzahl wurde aktualisiert.");
        }

        //Change owner
        public static void ChangeOwner()
        {
            int carID;
            bool correktName = false;
            int newPersonID;
            int newAge;
            string firstName;
            string secoundName;
            bool goAhead = false;

            do
            {
                Console.WriteLine("Die AutoID eingeben.");
                int.TryParse(Console.ReadLine(), out carID);
            } while (carID < 0 || carID > 100000000);

            do
            {
                Console.WriteLine("Den Vornamen eingeben.");
                firstName = Console.ReadLine();
                Console.WriteLine("Den Nachnamen eingeben.");
                secoundName = Console.ReadLine();
                Console.WriteLine("{0} {1} ist korrekt? y/n", firstName, secoundName);
                string query = Console.ReadLine();
                switch (query)
                {
                    case "y": correktName = true; break;
                    case "n": break;
                    default: break;
                }
            } while (!correktName);

            do
            {
                Console.WriteLine("Das Alter eingeben.");
                int.TryParse(Console.ReadLine(), out newAge);
            } while (newAge < 17 || newAge > 90);

            int i = 0;
            do
            {
                i++;
                if (personArray[i] == null)
                {
                    goAhead = true;
                }
                newPersonID = i;
            } while (!goAhead);

            Person newOwner = new Person(firstName, secoundName, newPersonID, newAge);
            carArray[carID].ChangeOwner(newOwner);

            Console.WriteLine("Die neue Person wurde angelegt und dem Auto zugewiesen.");
            Console.WriteLine(carArray[carID].Print());
        }

        //Calculates tim eto next service
        public static void TimeToNextService()
        {
            Console.WriteLine("Die Auto-ID eingeben.");
            string carID = Console.ReadLine();
            int.TryParse(carID, out int carIDconverted);

            int nextService = carArray[carIDconverted].DistanceToNextService();
            Console.WriteLine(nextService);
            carArray[carIDconverted].TimeToNextService();
        }

        //Calculates value of car
        public static void ValueOfCar()
        {
            Console.WriteLine("Die Auto-ID eingeben.");
            string carID = Console.ReadLine();
            int.TryParse(carID, out int carIDconverted);

            double value = carArray[carIDconverted].GetActualValue();
            Console.WriteLine("Der aktuelle Wert ihres Autos beträgt" + value + " Euro");
        }

        //Fill History
        private static void FillHistory(Person person, int personID)
        {
            ownerHistoryArray[curHistoryNu++] = personArray[personID];

            if (personID == 9)
            {
                personID = 0;
            }
        }
    }
}
