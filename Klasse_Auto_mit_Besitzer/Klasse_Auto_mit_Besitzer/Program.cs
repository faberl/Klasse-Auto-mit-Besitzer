using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Auto_mit_Besitzer
{
    class Program //dir fehlt noch die changeOwner Methode bzw Option / wir ändern qausi nur die Personen ID im Autoarray
    {               //am besten fragst du Auto ID vom zu ändernden autos ab und dann die neue Besitzer ID 
                    //und mittels carArray[carIDconverted].Change Owner wird der Wechsel dann durchgeführt

        static Person[] personArray = new Person[11];
        static Car[] carArray = new Car[11];
        static Person[] ownerHistoryArray = new Person[10];
        static int curCarNum = 0; //current Car number
        static int curHistoryNu = 0;
        static void createNewPersons()
        {
            Person newPerson0 = new Person("Muster0", "Mayr0", 0, 28);
            personArray[0] = newPerson0;
            Person newPerson1 = new Person("Muster1", "Mayr1", 1, 20);
            personArray[1] = newPerson1;
            Person newPerson2 = new Person("Muster2", "Mayr2", 2, 21);
            personArray[2] = newPerson2;
            Person newPerson3 = new Person("Muster3", "Mayr3", 3, 22);
            personArray[3] = newPerson3;
            Person newPerson4 = new Person("Muster4", "Mayr4", 4, 23);
            personArray[4] = newPerson4;
            Person newPerson5 = new Person("Muster5", "Mayr5", 5, 24);
            personArray[5] = newPerson5;
            Person newPerson6 = new Person("Muster6", "Mayr6", 6, 25);
            personArray[6] = newPerson6;
            Person newPerson7 = new Person("Muster7", "Mayr7", 7, 26);
            personArray[7] = newPerson7;
            Person newPerson8 = new Person("Muster8", "Mayr8", 8, 27);
            personArray[8] = newPerson8;
            Person newPerson9 = new Person("Muster9", "Mayr9", 9, 28);
            personArray[9] = newPerson9;
            Person newPerson10 = new Person("Muster10", "Mayr10", 10, 29);
            personArray[10] = newPerson10;
        } //steht in der Aufgabenstellung das wir die Personen bei Programmstart angelegt werden sollen
        
        //Main von Philipp Herbst inpliziert.
        static void Main(string[] args)
        {
            bool yesOrNo = false;
            
            Console.WriteLine("Willkommen in der Fuhrparkverwaltung von Herbst und Erlacher.");
            GetCommands();

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
                    case "c": InsertNewCar(); break;//auf c tust du hier ein neues Kfz hinzufügen unten allerdings den listenpreis berrechnen 
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
            Console.WriteLine("c: Berechnet den Listenpreis ihres neuen Autos."); // hier meine ich 
            Console.WriteLine("d: Hier werden die akutellen Daten eines Fahrzeuges eingegeben.");
            Console.WriteLine("n: Hier wird die Zeit bis zum nächsten Service berechnet.");
            Console.WriteLine("v: Berechnet den aktuellen Wert Ihres Autos.");
            GetCommands();
        }

        public static void ShowAllCars() //evtl noch Beschriftung (Reihenfole ist in der Funktion Print in Car
        {
            int j = 1;
            for (int i = 0; i < curCarNum; i++)
            {
                Console.WriteLine("{0}) {1}" , j++, carArray[i].Print());
                Console.WriteLine();
            }              
        }

        public static void InsertNewCar()
        {
            if (curCarNum == 9) //wennn das Array bereits voll ist bricht es ab...hab das jetzt mal so gemacht evtl hast noch eine bessere Idee
                return;     //nicht das ma an error bekommen weil ma zu viel ins array schreiben und überschreiben sollen wir denk ich auch nicht
                            //also vermutlich am besten das man hier nicht mehr rein kommt sobald der fuhrpark voll ist
            Console.WriteLine("Die Personen ID eingeben."); //Personen ID ist gleichzeitig Platz im PersonenArray also zwischen 1 und 10 ansonst error
            int.TryParse(Console.ReadLine(), out int personID); //kannst wennsd willst alle so schreiben, ist kürzer
            Console.WriteLine("Den Listenpreis eingeben.");
            string listPrice = Console.ReadLine();
            Console.WriteLine("Den Kilometerstand eingeben.");
            string mileage = Console.ReadLine();
            Console.WriteLine("Baujahr eingeben.");
            string constructionYear = Console.ReadLine();
            Console.WriteLine("Farbe eingeben.");
            string color = Console.ReadLine();

            
            double.TryParse(listPrice, out double convertedListPrice);
            int.TryParse(mileage, out int convertedMileAge);
            int.TryParse(constructionYear, out int convertedConstructionYear);

            carArray[curCarNum++] = new Car(convertedMileAge, convertedConstructionYear, convertedListPrice, color, personArray[personID]);
            FillHistory(personArray[personID], personID);
            if (curCarNum == 10)
            {
                Console.WriteLine("Der Fuhrpark ist nun voll, es können keine zusätzlichen Autos mehr hinzugefügt werden");
            }
            }

        public static void UpdateCarData()
        {
            Console.WriteLine("Die gefahrenen Kilomenter eingeben.");
            string newMileAge = Console.ReadLine();
            int.TryParse(newMileAge, out int newMileAgeConverted);

            Console.WriteLine("Die Auto-ID eingeben."); //hab die AutoID eingabe noch hinzugefügt, die brauch ich auch //Überprüfung wie unten
            string carID = Console.ReadLine();
            int.TryParse(carID, out int carIDconverted);

            int newKm = carArray[carIDconverted].Drive(newMileAgeConverted); //auf den newKm sind dann die neuen Km drauf falls du was damit machen möchtest
        }

        public static void TimeToNextService()
        {
            Console.WriteLine("Die Auto-ID eingeben."); //hier muss noch überprüft werden ob der Eingegebene wert kleiner als die curCarNum ist sonst error
            string carID = Console.ReadLine();
            int.TryParse(carID, out int carIDconverted);

            int nextService = carArray[carIDconverted].DistanceToNextService();
            Console.WriteLine(nextService); 
            //carArray[carIDconverted].TimeToNextService(); //muss ich noch schreiben die Methode..      
        }

        public static void ValueOfCar()
        {
            Console.WriteLine("Die Auto-ID eingeben."); //Ebenfalls eingabe überprüfen ob Eingabe kleiner curCarNum ist 
            string carID = Console.ReadLine();
            int.TryParse(carID, out int carIDconverted);

            double value = carArray[carIDconverted].GetActualValue();
            Console.WriteLine("Der aktuelle Wert ihres Autos beträgt"+ value +" Euro"); //vorschlag von mir
        }

        private static void FillHistory(Person person, int personID) //optional aber ich denke es schadet nicht...
        {
            ownerHistoryArray[curHistoryNu++] = personArray[personID];

            if (personID == 9)
            {
                personID = 0;
            }
        }
    }
}
