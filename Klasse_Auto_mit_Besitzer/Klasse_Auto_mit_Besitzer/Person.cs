using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Auto_mit_Besitzer
{
    public class Person
    {
        #region members
        private string _name, _sureName;
        private int _personID, _age;
        int[] _personArray = new int[10];
        #endregion


        #region constructor
        public Person()
        {
            _name = " ";
            _sureName = " ";
            _personID = ' ';
            _age = ' ';
        }
        public Person(string name, string surename, int personID, int age)
        {
            _name = name;
            _sureName = surename;
            _personID = personID;
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
        //get MNumber
        public int PersonID
        {
            get
            {
                return _personID;
            }

        }
        //get age
        public int Age
        {
            get
            {
                return _age;
            }
        }
        #endregion


        #region methods
        //hands over properties to PrintArray
        public string Print()
        {
            return Name + " " + _sureName + "  " + _personID + "  " + _age;
        }



        private void FillPersonArray()
        {
            for (int i = 0; i < _personArray.Length; i++)
            {
                Person newPerson = new Person();
                newPerson.Name = "Muster";
                newPerson.SureName = "Test";
                _personArray[i] = PersonID;


            }
            
            Person Besitzer = new Person();
            
        }
        #endregion


    }
}
