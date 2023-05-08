using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Opposition : Politics
    {
        StrategyOpposition strategy = new OppositionReact();

        private List<StrategyOpposition> strategies = new List<StrategyOpposition>()
        {
            new OppositionReact(),
            new OppositionReactFavourable(),
            new OppositionReactAngry(),
            new OppositionReactGettingNervous()
        };

        public Opposition(string _name, int _influence_level, Opinion opinion) : base(_name, _influence_level, opinion)
        {
        }


        public string reportEvidencesModification(Evidence evidence) { return "Evidences modified"; }

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
