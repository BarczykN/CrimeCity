using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    abstract class Society : Group
    {
        protected bool united = false;

        public Society(string _name,int _influence_level,Opinion opinion) : base(_name, _influence_level,opinion)
        {

        }


        public virtual void unite(Society uniteWith)
        {
            united = true;
            influence_level = uniteWith.influence_level + influence_level + 70;
            uniteWith.influence_level = uniteWith.influence_level + influence_level + 70;
        }
    }
}
