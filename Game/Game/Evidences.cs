using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Evidences : Item
    {
        protected List<Evidence> evidences;

        public Evidences(List<Evidence> _evidences){
            evidences = _evidences;
        }

        public List<Evidence> Evidence
        {
            get => evidences;
            set => evidences = value;
        }

        public void addEvidence(Evidence evidence)
        {
            evidences.Add(evidence);
        }

        public new string ToString()
        {
            string result = "";

            foreach(Evidence e in evidences){
                result = result + e.ToString();
            }

            return result;
        }

        public void use()
        {
            Console.WriteLine(ToString());
        }
    }
}
