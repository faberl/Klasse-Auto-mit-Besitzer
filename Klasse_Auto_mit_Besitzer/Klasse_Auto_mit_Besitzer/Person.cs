using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erlacher_Fabian_PersoneneingabeMitKlassen
{
    public class Person
    {
        #region members
        private string _name, _sureName;
        private int _mNumber, _age;
        #endregion


        #region constructor
        public Person()
        {
            _name = " ";
            _sureName = " ";
            _mNumber = '0';
            _age = '0';
        }
        public Person(string name, string surename, int mNumber, int age)
        {           
            _name = name;
            _sureName = surename;
            _mNumber = mNumber;
            _age = age;
        }
        #endregion


        #region properties
        //set Name
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {           
                _name = value;        
            }
        }
        //set surename
        public string SureName
        {
            get
            {
                return _sureName;
            }
            set
            {
                _sureName = value;
            }
        }
        //set MNumber
        public int MNumber
        {
            get
            {
                return _mNumber;
            }
            set
            {
                _mNumber = value;
            }
        }
        //set age
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        #endregion

      
        #region methods
        //hands over properties to PrintArray
        public string Print()
        {            
                return Name +" "+ _sureName +"  "+ _mNumber +"  "+ _age;                
        }
        #endregion


    }
}
