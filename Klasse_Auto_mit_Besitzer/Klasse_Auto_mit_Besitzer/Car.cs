using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Auto_mit_Besitzer
{
    class Car //class Car von Fabian Erlacher inpliziert
    {
        #region staticFields
        //price loss per year and km 
        //serviceintervall every 15000km or once a year on 1.january
        public static int serviceintervallKm = 15000;
        public static int serviceintervallPerYear = 1;
        public static double percentLossPerKm = 0.03;
        public static double percentLossPerYear = 0.03;
        public static DateTime today = DateTime.Today;

        #endregion

        #region members

        //declare variables 
        Person _owner;
        int _km;
        int _bj;
        int _carAge;
        double _actualValue;
        double _listPrice;
        string _color;

        #endregion

        #region properties

        //km, Bj, Color, Listprice, owner
        public int Km { get; private set; }

        public int Bj { get; }

        public string Color { get; }

        public double Listprice { get; }

        public Person Owner { get; set; }

        #endregion

        #region constructor 

        public Car()
        {

        }

        //create a new Car 
        public Car(int km, int bj, double listprice, string color, Person owner)
        {
            _km = km;
            _bj = bj;
            _listPrice = listprice;
            _color = color;
            _owner = owner;
        }
        #endregion


        #region methods

        //methods for Drive, GetActualValue, ChangeOwner, DistanceToNextService, TimeToNextService and Print

        public int Drive(int newKm)
        {
            _km = _km + newKm;
            return _km;
        }

        public double GetActualValue()
        {
            //get actual age              
            int year = today.Year;
            _carAge = year - _bj;

            //car loses value per 10.000km (3%) and per year(3%)
            _actualValue = _listPrice - (_listPrice * percentLossPerKm * _km / 10000) - (_listPrice * percentLossPerYear * _carAge);

            if (_actualValue < 100)
            {
                _actualValue = 100;
            }
            return _actualValue;
        }

        public void ChangeOwner(Person newOwner)
        {
            _owner = newOwner;
        }

        //calculates km to next service
        public int DistanceToNextService()
        {
            return serviceintervallKm - _km % serviceintervallKm;
        }

        //service allways on first Day of the Year
        public int TimeToNextService()
        {
            int day = today.DayOfYear;
            int year = today.Year;
            if (DateTime.IsLeapYear(year))
            {
                return 366 - day;
            }
            else
            {
                return 365 - day;
            }
        }

        public string Print()
        {
            return _owner.Print() + " | " + _km + " km | " + _bj + " Bj | " + _listPrice + " Euro | Farbe " + _color;
        }

        #endregion

    }
}