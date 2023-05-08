using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Motivation
    {
        private string name;

        public Motivation(string _name){
            name = _name;
        }

        public new string ToString()
        {
            return name;
        }
    }
}
