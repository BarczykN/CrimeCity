using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Questions
    {
        private Motivation pair;
        private string content;
        private bool canBeAsked = false;
        private bool lost = false;
        private bool locked = false;
        private int counter = 0;
        private string whoCanBeAsked = "";
        private int impact = 0;
        private Questions lockedQuestion;

        public Questions(Motivation _pair, string _content)
        {
            pair = _pair;
            content = _content;
        }

        public Questions(Motivation _pair,string _content,int _impact)
        {
            pair = _pair;
            content = _content;
            impact = _impact;
        }

        public Questions(Motivation _pair, string _content,string who)
        {
            pair = _pair;
            content = _content;
            whoCanBeAsked = who;
        }
        public Questions(Motivation _pair, string _content, string who, int _impact)
        {
            pair = _pair;
            content = _content;
            whoCanBeAsked = who;
            impact = _impact;
        }

        public int getImpact()
        {
            return impact;
        }


        public bool getState()
        {
            return canBeAsked;
        }

        public string getContent()
        {
            return content;
        }

        public string getWhoCanBeAsked()
        {
            return whoCanBeAsked;
        }

        public bool connect(Motivation motivation)
        {
            counter++;
            if(motivation == pair && lost != true) {
                canBeAsked = true;
                return true;
            }
            else if (counter == 4)
            {
                lost = true;
                content = content + " || You lost that question :(\n";
                Console.WriteLine("\nLost question\n");
            }
            return false;
        }

        public new string ToString()
        {
            return content;
        }

        public bool getIfLost()
        {
            return lost;
        }
        public void lockQuestion(Questions q)
        {
            lockedQuestion = q;
            q.Lock = true;
        }

        public void unlock()
        {
            if(lockedQuestion != null)
            {
                lockedQuestion.Lock = false;
                Console.WriteLine("\nYou have new potential question to match\n");
            }
            
        }
        public bool Lock
        {
            get 
            { 
                return locked; 
            }
            set
            {
                locked = value;
            }
        }

    }
}
