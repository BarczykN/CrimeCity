using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Mafia : Group,IDelete
    {
        private StrategyMafia strategy =  new MafiaStrategy();

        private List<StrategyMafia> strategies = new List<StrategyMafia>()
        {
            new MafiaStrategy(),
            new MafiaStrategyFavourable(),
            new MafiaStrategyAngry(),
            new MafiaStrategyGettingNervous()
        };

        public Mafia(string _name, int _influence_level,Opinion opinion) : base(_name, _influence_level, opinion)
        {
        }


        public void deletePerson(Person person)
        {
            throw new NotImplementedException();
        }

        protected override void neutral()
        {
            strategy = strategies[0];
        }
        protected override void favourable()
        {
            strategy = strategies[1];
        }
        protected override void angry()
        {
            strategy = strategies[2];
        }

        protected override void gettingNervous()
        {
            strategy = strategies[3];
        }

        public override void getState()
        {
            strategy.react();
        }
    }
}
