using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    abstract class Group
    {
        protected int reputation_level = 60;
        protected string name;
        protected int influence_level;
        public Opinion suggestedVerdict = Opinion.Neutral;

        public Group(string _name,int _influence_level,Opinion opinion)
        {
            name = _name;
            influence_level = _influence_level;
            suggestedVerdict = opinion;
        }

        public Opinion SuggestedVerdict
        {
            get
            {
                return suggestedVerdict;
            }

            set
            {
                suggestedVerdict = value;
            }
        }

        public int Reputation
        {
            get => reputation_level;
            set { 
                reputation_level = value;
                if (reputation_level <= 100)
                {
                    favourable();
                }
                if(reputation_level <= 70)
                {
                    neutral();
                }
                if(reputation_level <= 50)
                {
                    gettingNervous();
                }else if(reputation_level <= 30)
                {
                    angry();
                }
            }
        }

        protected virtual void neutral()
        {
            Console.WriteLine("Neutral");
        }
        protected virtual void favourable()
        {
            Console.WriteLine("Favourable");
        }
        protected virtual void angry()
        {
            Console.WriteLine("Angry");
        }

        protected virtual void gettingNervous()
        {
            Console.WriteLine("GettingNervous");
        }

        public override string ToString()
        {
            return name + " : " + suggestedVerdict.ToString();
        }

        public string getName()
        {
            return name;
        }

        public int getInfluenceLevel()
        {
            return influence_level;
        }

        public virtual void getState()
        {
            Console.WriteLine("\nneutral\n");
        }
    }
}
