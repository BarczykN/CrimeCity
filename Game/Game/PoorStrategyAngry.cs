using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class PoorStrategyAngry : StrategyPoor
    {
        public void react() {
            Console.WriteLine("\nThe Mob is angry\n");
        }
    }
}
