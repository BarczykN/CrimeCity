using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GovernmentReactAngry : StrategyGovernment
    {
        public void react()
        {
            Console.WriteLine("\nGovernment is angry\n");
        }
    }
}
