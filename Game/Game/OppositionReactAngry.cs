using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class OppositionReactAngry : StrategyOpposition
    {
        public void react() {
            Console.WriteLine("\nOpposition is angry\n");
        }
    }
}
