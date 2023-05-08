using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    abstract class Person
    {
        protected string name;
        protected string function;
        protected bool deleted = false;

        public Person(string _name,string _function)
        {
            name = _name;
            function = _function;
        }

        public bool Deleted
        {
            get
            {
                return deleted;
            }

            set
            {
                deleted = value;
            }
        }


        public string getFunction()
        {
            return function;
        }

        public string getName()
        {
            return name;
        }

        public new string ToString()
        {
            return name + " - " + function;
        }
    }
}
