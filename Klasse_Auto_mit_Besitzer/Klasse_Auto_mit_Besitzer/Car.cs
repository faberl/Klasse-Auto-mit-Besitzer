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
        int _currentprice;
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
        //create a new Calculater
        public Car()
        {

        }

        //get firstNumber and secondNumber
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

        //methods for add, subtract, divide, multiply
        public decimal Add()
        {
            _result = _firstNumber + _secondNumber;
            Fillhistory(_result);
            return _result;
        }

        public decimal Subtract()
        {
            _result = _firstNumber - _secondNumber;
            Fillhistory(_result);
            return _result;
        }

        public decimal Divide()
        {
            _result = _firstNumber / _secondNumber;
            Fillhistory(_result);
            return _result;
        }

        public decimal Multiply()
        {
            _result = _firstNumber * _secondNumber;
            Fillhistory(_result);
            return _result;
        }
                   
        //print history
        public void PrintHistory()
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