using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GovernmentReactFavourable : StrategyGovernment
    {
        public void react()
        {
            Console.WriteLine("\nGovernment is friendly\n");
        }
    }
}
