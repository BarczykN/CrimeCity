using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class PoorStrategyGettingNervous : StrategyPoor
    {
        public void react() {
            Console.WriteLine("\nThe Mob is getting nervous\n");
        }
    }
}
