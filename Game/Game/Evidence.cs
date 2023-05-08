using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Evidence
    {
        private string name;
        private string note;

        public Evidence(string _name,string _note)
        {
            name = _name;
            note = _note;
        }

        public new string ToString()
        {
            return name + "\n"
                + "\t" + note + "\n\n";
        }

    }
}
