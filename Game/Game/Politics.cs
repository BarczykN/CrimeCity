using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    abstract class Politics : Group
    {
        protected Politics(string _name, int _influence_level, Opinion opinion) : base(_name, _influence_level, opinion)
        {
        }
    }
}
