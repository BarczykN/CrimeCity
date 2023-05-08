using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class PoorStrategyFavourable : StrategyPoor
    {
        public void react() {
            Console.WriteLine("\nThe Mob is friendly\n");
        }
    }
}
