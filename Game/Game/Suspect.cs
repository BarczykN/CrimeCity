using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Suspect : Person,IAnswer
    {
        private Dictionary<String, String> answers;

        public Suspect(string _name, string _function,Dictionary<string,string> ans) : base(_name, _function)
        {
            answers = ans;
        }

        public string answer(Questions questions)
        {
            questions.unlock();
            if (questions.getImpact() != 0)
            {
                Jury.GuiltyScore = Jury.GuiltyScore + questions.getImpact();
            }
            return answers[questions.ToString()];
        }


        public new string ToString()
        {
            return name + " - " + function;
        }
    }
}
