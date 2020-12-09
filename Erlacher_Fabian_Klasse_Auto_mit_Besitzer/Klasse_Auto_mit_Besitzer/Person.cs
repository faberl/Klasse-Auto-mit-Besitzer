using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Auto_mit_Besitzer
{
    public class Person  //class Person von Fabian Erlacher inpliziert
    {
        //members of each Person
        #region members
        private string _name;
        private string _sureName;
        private int _personID;
        private int _age;
        #endregion

        //Create a new Person 
        #region constructor
        public Person()
        {
           
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
        public int PersonID
        {
            get
            {
                return _personID;
            }
        }

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



        #region overload methods
        public override string ToString()
        {
            return _name + " " + _sureName;
        }
        #endregion
    }
}