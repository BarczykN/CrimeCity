using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class RichStrategyAngry : StrategyRich
    {
        public void react() {
            Console.WriteLine("\nWealthy class is angry\n");
        }
    }
}
