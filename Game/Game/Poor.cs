using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Poor : Society
    {
        StrategyPoor strategy = new PoorStrategy();

        private List<StrategyPoor> strategies = new List<StrategyPoor>()
        {
            new PoorStrategy(),
            new PoorStrategyFavourable(),
            new PoorStrategyAngry(),
            new PoorStrategyGettingNervous()
        };

        public Poor(string _name, int _influence_level,Opinion opinion) : base(_name, _influence_level,opinion)
        {
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

        public override void unite(Society uniteWith)
        {
            base.unite(uniteWith);
        }
    }
}
