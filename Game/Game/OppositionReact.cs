using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class OppositionReact : StrategyOpposition
    {
        public void react() {
            Console.WriteLine("\nOpposition is neutral\n");
        }
    }
}
