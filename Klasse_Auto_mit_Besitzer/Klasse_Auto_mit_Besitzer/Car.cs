using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Auto_mit_Besitzer
{
    class Car
    {
        #region staticFields
        
        public static int serviceintervall = 15000;
        public static double percentLossPerKm = 0.03;
        public static double percentLossPerYear = 0.3;

        #endregion
        #region members

        //declare variables 
        int _km;
        int _bj;
        Person _owner;
        int _carID;
        int _ageOfCar;
        int _kmLimit;
        int _distanceToNextService;
        double _percentLossPerKm;
        double _actualValue;
        double _listprice;
        string _color;


        #endregion


        #region properties

        //km, Bj, Color, Listprice, owner
        public int Km { get; private set; } //privat setzen?

        public int Bj { get; }

        public string Color { get; }  

        public double Listprice { get; }

        public Person Owner { get; set; }

        #endregion

        #region constructor 
        //create a new Car
        public Car()
        {

        }

        //create a new Car 
        public Car(int km, int bj, double listprice, string color, Person owner)
        {
            _km = km;
            _bj = bj;
            _listprice = listprice;
            _color = color;
            _owner = owner;         
        }
        #endregion


        #region methods

        //methods for Drive GetActualValue, ChangeOwner, DistanceToNextService, TimeToNextService
        public int Drive(int newKm)
        {
            _km = _km + newKm;
            return _km;          
        }
        

        public double GetActualValue() //darf nicht 0 werden
        {       
            DateTime actual = DateTime.Now;           
            int year = actual.Year;
            _ageOfCar = year - _bj;

            return _listprice - (_listprice * percentLossPerKm * _km / 10000) - (_listprice * percentLossPerYear * _ageOfCar);
        }

        public void ChangeOwner(Person newOwner)
        {
            _owner = newOwner;
        }

        public int DistanceToNextService()
        { 
            return serviceintervall - _km % serviceintervall;                   
        }

        public void TimeToNextService() 
        {
          
          
        }

        public string Print()
        {
            return _owner + " | " + _km + " km | " + _bj + " Bj | " + _listprice + " Euro | Farbe " + _color;
        }
        #endregion

    }
}