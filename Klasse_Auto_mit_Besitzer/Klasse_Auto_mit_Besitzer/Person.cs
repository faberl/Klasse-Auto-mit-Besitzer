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
        private string _name;
        private string _sureName;
        private int _personID, _age;
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
        //get and set Name
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
        //get PersonID
        public int PersonID
        {
            get => _personID;
        
        }
        //get age
        public int Age
        {
            get => _age;
        }
        #endregion
    }
}