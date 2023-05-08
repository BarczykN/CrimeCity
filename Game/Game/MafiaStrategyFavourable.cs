using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class MafiaStrategyFavourable : StrategyMafia
    {
        public void react() {
            Console.WriteLine("\nMafia is favourable\n");
        }
    }
}
