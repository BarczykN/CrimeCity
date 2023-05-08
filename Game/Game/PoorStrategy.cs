using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class PoorStrategy : StrategyPoor
    {
        public void react() {
            Console.WriteLine("\nThe Mob is neutral\n");
        }
    }
}
