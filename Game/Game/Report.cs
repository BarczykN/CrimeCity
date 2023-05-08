using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Report : Item
    {
        private string content = "";

        public void addText(string text)
        {
            content = content + "\n" + text;
        }

        public void use()
        {
            Console.WriteLine(content);
        }
    }
}
