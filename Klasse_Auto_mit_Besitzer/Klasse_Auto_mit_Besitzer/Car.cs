using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Auto_mit_Besitzer
{
    class Car
    {
        #region members

        //declare variables 
        int _km;
        int _bj;  
        int _personID;
        int[] _carArray  = new int[10];
        int _carID;
        int _ageOfCar;
        int _kmLimit;
        int _distanceToNextService;
        int _serviceintervall;
        double _percentLossPerKm;
        double _actualValue;
        double _listprice;
        string _color;
        bool _success;

        #endregion


        #region properties

        //km, Bj, Color, Listprice
        public int Km
        {
            get
            {
                return _km;
            }
            set
            {
                _km = value;
            }
        }

        public int Bj
        {
            get
            {
                return _bj;
            }
        }

        public string Color
        { 
            get
            {
                return _color;
            }
        }

        public double Listprice
        {
            get
            {
                return _listprice;
            }         
        }
        #endregion


        #region constructor 
        //create a new Car
        public Car()
        {

        }

        //create a new Car 
        public Car(int km, int bj, double listprice, string color, int personID)
        {
            _km = km;
            _bj = bj;
            _listprice = listprice;
            _color = color;
            _personID = personID;
        }
        #endregion


        #region methods

        //methods for "GetActualValue", "ChangeOwner", "TimeToNextService" 
        public double GetActualValue(int carID) 
        {
            DateTime actual = DateTime.Now;
            int year = actual.Year;

            _ageOfCar = year - _bj;
            _kmLimit = 10000;
            _percentLossPerKm = 0.00;
            _success = false;
           
            do
            {
                if (_km <= _kmLimit && _km > (_kmLimit - 10000))
                {
                    _actualValue = _listprice - (_percentLossPerKm * _listprice) - (_ageOfCar * 0.03 * _listprice);

                    if (_actualValue <= 300)
                    {
                        _actualValue = 300;
                    }
                    _success = true;
                }
                else
                {
                    _kmLimit = _kmLimit + 10000;
                    _percentLossPerKm = _percentLossPerKm + 0.04;
                }
            } while (!_success);

            Console.WriteLine(_actualValue); //Ausgabe oder Rückgabewert? ---> Ausgabe!
            return _actualValue;
        }

        public void ChangeOwner(string newOwner)
        {
            Person besitzer = new Person();            
        }

        public void DistanceToNextService(int carID) //Bemerkung von Philipp: In der Eingabemaske wird nur die AutoID eingegeben.d.h. du müsstest dir den KM-Stand aus dem Autoarray holen von von dem ausgehend die Zeit berechnen.
        {
                _success = false;
                _distanceToNextService = 0;
                _serviceintervall = 15000;

                do
                {
                    if (_km <= _serviceintervall && _km >= (_serviceintervall - 15000))
                    {
                        _distanceToNextService = _serviceintervall - _km;
                        _success = true;
                    }
                    else
                    {
                        _serviceintervall = _serviceintervall + 15000;
                    }
                } while (!_success);

                Console.WriteLine("Next Service in {0} km", _distanceToNextService);
        }

        public void TimeToNextService() 
        {

        }

        //print history
        public void PrintAllCars()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(_carArray[_carID]);
            }
        }
        #endregion


        #region private methods
        //Fill the history with the results
        private void FillCarArray()
        {

            _carArray[_carID] = _personID;
            _carID++;

            if (_carID == 9)
            {
                Console.WriteLine("Verzeichnis ist voll");
            }
        }
        #endregion
    }
}