using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public enum Opinion
    {
        Guilty,
        Guiltyless,
        Neutral
    }

    public static class OpinionConvert
    {
        public static string GetString(this Opinion op)
        {
            switch (op)
            {
                case Opinion.Guilty:
                    return "guilty";

                case Opinion.Guiltyless:
                    return "guiltyless";

                case Opinion.Neutral:
                    return "neutral";

                default:
                    return "no opinion";

            }
        }
    }


    public class Jury
    {
        private static  Opinion suggestedVerdict;
        private static int reputationLevel;
        private static int guiltyScore = 50;


        public static Opinion SuggestedVerdict
        {
            get { return suggestedVerdict; }
        }

        public static int ReputationLevel
        {
            get
            {
                return reputationLevel;
            }

            set
            {
                reputationLevel = value;
            }
        }

        public static int GuiltyScore
        {
            get
            {
                return guiltyScore;
            }

            set
            {
                guiltyScore = value;
                if(guiltyScore >= 50)
                {
                    suggestedVerdict = Opinion.Guilty;
                }
                else
                {
                    suggestedVerdict = Opinion.Guiltyless;
                }
            }
        }



    }
}
