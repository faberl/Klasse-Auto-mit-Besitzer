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
        double _actualValue;
        double _listprice;
        string _color;
        string _brand;
        string[] _carArray  = new string[10];
        int _carID;


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
        public Car(int km, int bj, double listprice, string color, string brand)
        {
            _km = km;
            _bj = bj;
            _listprice = listprice;
            _color = color;
            _brand = brand;
        }
        #endregion


        #region methods

        //methods for "GetActualValue", "ChangeOwner", "TimeToNextService"
        public double GetActualValue()
        {
            int _age;
            _age = 2020 - _bj;
           
            if (_km > 20000)
            {
                _listprice = _listprice - (0.10 * _listprice);
            }
            else if (_km > 40000)
            {
                _listprice = _listprice - (0.20 * _listprice);
            }
            else if (_km > 60000)
            {
                _listprice = _listprice - (0.30 * _listprice);
            }

            _actualValue = _listprice - (_age * 0.05*_listprice);

            if (_actualValue <= 500)
            {
                _actualValue = 500;
            }

            return _actualValue;
        }

        public void ChangeOwner(string newOwner)
        {
            Person Besitzer = new Person();
            
        }

        public void TimeToNextService()
        {
            int _nextService;
            _nextService = 15000 - _km; 
            Console.WriteLine("Ihr nächstes Servie ist in {0} km fällig");
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

            _carArray[_carID] = ;
            _carID++;

            if (_carID == 9)
            {
                Console.WriteLine("Verzeichnis ist voll");
            }
        }
        #endregion
    }
}