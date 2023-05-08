using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class MafiaStrategy : StrategyMafia
    {
        public void react() {
            Console.WriteLine("\nMafia is neutral\n");
        }
    }
}
