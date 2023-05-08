using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Rich : Society
    {
        StrategyRich strategy = new RichStrategy();

        private List<StrategyRich> strategies = new List<StrategyRich>()
        {
            new RichStrategy(),
            new RichStrategyFavourable(),
            new RichStrategyAngry(),
            new RichStrategyGettingNervous()
        };

        public Rich(string _name, int _influence_level,Opinion opinion) : base(_name, _influence_level,opinion)
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
