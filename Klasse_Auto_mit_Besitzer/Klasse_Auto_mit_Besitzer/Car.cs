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
            _actualValue = _listprice;

            return _actualValue;
        }

        public void ChangeOwner(string newOwner)
        {
            
        }

        public void TimeToNextService()
        {
            
            Console.WriteLine("Ihr nächstes Servie ist in {0} km fällig");
        }

        
                   
        //print history
        public void PrintAllCars()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(_historyArray[i]);
            }
        }
        #endregion


        #region private methods
        //Fill the history with the results
        private void Fillhistory(decimal newResult)
        {
            _historyArray[_placeInArray] = newResult;
            _placeInArray++;

            if (_placeInArray == 9)
            {
                _placeInArray = 0;
            }
        }
        #endregion
    }
}