using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Government : Politics,IDelete
    {
        StrategyGovernment strategy = new GovernmentReact();

        private List<StrategyGovernment> strategies = new List<StrategyGovernment>()
        {
            new GovernmentReact(),
            new GovernmentReactFavourable(),
            new GovernmentReactAngry(),
            new GovernmentReactGetting_Nervous()
        };

        public Government(string _name, int _influence_level, Opinion opinion) : base(_name, _influence_level, opinion)
        {
        }

        public void deletePerson(Person person)
        {
            person.Deleted = true;
            Console.WriteLine(person.getName() + " is deleted by government");
        }

        public void modifyEvidences(Evidences evidence) { }

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
