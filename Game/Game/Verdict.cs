using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Verdict : Item
    {
        private Opinion verdict = Opinion.Neutral;

        private void result()
        {
            Console.WriteLine("\nYour verdict: \n" +
                "1.Guilty\n" +
                "2.Guiltless\n" +
                "3.Quit\n");

            string state = Console.ReadLine();

            if (state.Equals("1"))
            {
                verdict = Opinion.Guilty;
            }else if (state.Equals("2"))
            {
                verdict = Opinion.Guiltyless;
            }else
            {
                return;
            }
        }

        public Opinion finalVerdict
        {
            get => verdict;
        }


        public void use()
        {
            result();
        }
    }
}
