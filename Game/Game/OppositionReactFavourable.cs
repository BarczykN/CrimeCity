using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class OppositionReactFavourable : StrategyOpposition
    {
        public void react() {
            Console.WriteLine("\nOpposition is favourable\n");
        }
    }
}
