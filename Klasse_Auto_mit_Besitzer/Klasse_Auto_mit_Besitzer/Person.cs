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

        public string Name { get; set; }

        public string SureName { get; set; }

        public int PersonID { get; }

        public int Age { get; set; }

        #endregion

        #region methods
        public string Print()
        {
            return _name + " " + _sureName;
        }

        #endregion
    }
}