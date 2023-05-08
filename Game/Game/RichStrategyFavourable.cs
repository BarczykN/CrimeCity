using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class RichStrategyFavourable : StrategyRich
    {
        public void react() {
            Console.WriteLine("\nWealthy class is friendly\n");
        }
    }
}
