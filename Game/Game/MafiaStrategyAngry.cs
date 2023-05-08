using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class MafiaStrategyAngry : StrategyMafia
    {
        public void react() {
            Console.WriteLine("\nMafia is angry\n");
        }
    }
}
