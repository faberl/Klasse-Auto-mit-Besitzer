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
        private const int serviceintervallKm = 15000;
        private const double percentLossPerKm = 0.03;
        private const double percentLossPerYear = 0.03;
        


        #endregion

        #region members

        //declare variables //privat
        private Person _owner;
        private int _km;
        private int _carAge;
        private double _actualValue;
        private string _color;
        private Person[] ownerHistoryArray = new Person[10];
        private int placeInHistory = 0;
        #endregion

        #region properties

        //km, Bj, Color, Listprice, owner
        public int Km
        {
            get
            {
                return _km;
            }
            private set
            {
                _km = value;
            }
        }

        public int Bj { get; }

        public string color
        {
            get
            {
                return _color;
            }
            private set
            {
                _color = value;
            }
        }

        public double Listprice { get; }

        public Person Owner
        {
            get
            {
                return _owner;
            }
        }

        #endregion

        #region constructor 

        public Car()
        {

        }

        //create a new Car 
        public Car(int km, int bj, double listprice, string color, Person owner)
        {
            _km = km;
            Bj = bj;
            Listprice = listprice;
            _color = color;
            _owner = owner;
        }
        #endregion


        #region methods

        //methods for Drive, GetActualValue, ChangeOwner, DistanceToNextService, TimeToNextService and Print

        public void Drive(int newKm) 
        {
            _km = _km + newKm;
        }

        public double GetActualValue()
        {
            //get actual age              
            int year = DateTime.Now.Year;
            _carAge = year - Bj;

            //car loses value per 10.000km (3%) and per year(3%)
            _actualValue = Listprice - (Listprice * percentLossPerKm * _km / 10000) - (Listprice * percentLossPerYear * _carAge);

            if (_actualValue < 100)
            {
                _actualValue = 100;
            }
            return _actualValue;
        }

        public void ChangeOwner(Person newOwner)
        {
            FillOwnerHistory();
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
            int day = DateTime.Now.DayOfYear;
            int year = DateTime.Now.Year;
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
            return _owner.ToString() + " | " + _km + " km | " + Bj + " Bj | " + Listprice + " Euro | Farbe " + _color;
        }

        private void FillOwnerHistory()
        {
            if (placeInHistory == 9)
            {
                placeInHistory = 0;
            }
            else
            {
                ownerHistoryArray[placeInHistory++] = _owner;
            }          
        }
        #endregion
    }
}