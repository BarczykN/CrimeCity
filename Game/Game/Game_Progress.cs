using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Game_Progress
    {
        private static Game_Progress _instance;

        private Opinion verdict;
        private Judge judge = new Judge("Alex Mercer", "judge");
        private Jury jury = new Jury();
        private List<Group> groups = new List<Group>()
        {
            new Mafia("Corleone",20,Opinion.Guilty),
            new Mafia("Aligator",20,Opinion.Guiltyless),
            new Government("Republicans",70,Opinion.Guilty),
            new Opposition("Democrats",30,Opinion.Guiltyless),
            new Poor("poor",10,Opinion.Neutral),
            new Rich("rich",50,Opinion.Guilty)
        };

        public static Game_Progress GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Game_Progress();
            }
            return _instance;
        }

        //--------------------------------------------------------------------------------------SCENE 1---------------------------------------------------------------------
        private List<Person> people = new List<Person>()
        {
            new Suspect("Edward Black","suspect",new Dictionary<string,string>(){
                {"Did you know a victim?","Yes,he was a mafia boss. We've met twice." },
                {"Do you recognise this knife?","Yes,it's my knife but I lost it about 2 weeks ago.\nI swear,I didnt kill him." },
                {"Can you tell us something about yourself?","My name is Edward Black. I am a butcher.\n I run a small shop in the suburbs" },
                {"Some people claim that you are a member of \"Aligator\" group. It looks like your revenge", "They lie! I am not a member of any gang." }

            }),
            new Witness("Alan White","witness",new Dictionary<string, string>()
            {
                {"Did you know a victim?","Unfortunately yes." },
                {"Do you recognise this knife?","Not,your honor" },
                {"Can you tell us something about yourself?","My name is Alan White. I am a small bussinesman. \nI am 35 years old,married with two children. " },
                {"You owed victim a money,didn't you?", "I owe him 100k bucks." }
            })

        };


        private Evidences evidences = new Evidences(
             new List<Evidence>() {
            new Evidence("Knife", "This knife contains fingerprints od Edward Black. It's covered in victim's blood"),
            new Evidence("Debts", "Maybe victim was killed by someone who owe him some money?"),
            new Evidence("Victim Reputation", "Victim was known as ruthless \"Golden Eye\" boss. There are some evidences that this company was only a cover for some illegal bussiness"),
            new Evidence("Victim Body", "Victim was found without head on the bottom of river. It looks like mafia revenge"),
            new Evidence("Suspect","Suspect is know as \"Aligator\" executioner")
        });

        private Document document = new Document("Preliminary Report\n", "\nMan without head\nA victim was found on the bottom of the city river. \nHis head was cut off.Suspect is Edward Black,we found" +
            " a knife containing Black's fingerprints and victim's blood.\nOf course, there are other possibilities but it looks like a mafia revenge,Black is know as \"Aligator\" executioner\n", "Detective Alex Morgan");

        private static List<Motivation> motivations = new List<Motivation>()
        {
            new Motivation("Person"),
            new Motivation("Debts"),
            new Motivation("Murder weapon"),
            new Motivation("Victim Body"),
            new Motivation("Victim Reputation"),
        };

        private List<Questions> questions = new List<Questions>()
        {        
            new Questions(motivations[1], "You owed victim a money,didn't you?","witness",-30),
            new Questions(motivations[0], "Can you tell us something about yourself?"),          
            new Questions(motivations[3], "Some people claim that you are a member of \"Aligator\" group. It looks like your revenge", "suspect", 25),
            new Questions(motivations[2], "Do you recognise this knife?",-10),
            new Questions(motivations[4], "Did you know a victim?",10)
        };

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //----------------------------------------------------------------------------------------------SCENE 2-------------------------------------------------------------------
        private List<Person> people2 = new List<Person>()
        {
            new Suspect("Frank Water","suspect",new Dictionary<string,string>(){
                {"Did you do that?","Yes and I'm proud of that. You sent innocent guy to jail for 25 years. Shame on you!! " },
                {"Can you tell us something about yourself?","I'm not gonna tell you anything. You know who I am." },
                {"Does someone forced you to do it?","You! You forced me to do that after you made such stupid choice." }

            }),
            new Witness("Peter Gunderson","guard",new Dictionary<string, string>()
            {
                {"Can you tell us more about what happened","Yes,I caught this guy while he was devastating a court house. He also write some inappropriate things on the wall" },
                {"Can you tell us something about yourself?","My name is Peter Gunderson and I am a guard here,in court house." },
            })
        };

        private List<Opinion> opinions2 = new List<Opinion>()
        {
            Opinion.Guilty,
            Opinion.Guiltyless,
            Opinion.Guilty,
            Opinion.Guilty,
            Opinion.Guilty,
            Opinion.Guilty
        };

        private Evidences evidences2 = new Evidences(
             new List<Evidence>() {
            new Evidence("Caught red-handed", "Guard caught Frank Water while he was devastating court house")
        });

        private Document document2 = new Document("Report\n", "On 12 July at 12pm Frank Water broke into court house and commited an act of vandalism.\n" +
            "He wrote \"FREE BLACK,YOU ****\". He was finally caught by a guard. These riots are a result of mr.Black process. \"Aligator\" gang claims he was innocent." +
            "Gang members are really mad. Punish him your honor,don't show any weakness.", "Police Department");

        private static List<Motivation> motivations2 = new List<Motivation>()
        {
            new Motivation("Person"),
            new Motivation("Motivation")
        };

        private List<Questions> questions2 = new List<Questions>()
        {
            new Questions(motivations2[1], "Did you do that?","suspect",80),
            new Questions(motivations2[1], "Does someone forced you to do it?","suspect",0),
            new Questions(motivations2[0], "Can you tell us something about yourself?")
        };

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        //---------------------------------------------------------------------------------------------------SCENE 2 GUITYLESS----------------------------------------------------

        private List<Person> people22 = new List<Person>()
        {
            new Suspect("Alan White","suspect",new Dictionary<string,string>(){
                {"Did you know a victim?","Unfortunately yes" },
                {"Do you recognise this knife?","No." },
                {"Can you tell us something about yourself?","My name is Alan White. I am a small bussinessman.\nI am 35 years old,married with two children. " },
                {"What do you know about mr.Tuck's death?", "I know that he was found in the river without his head." },
                {"Mr.White.What did you do on June 28 at 9 pm?", "I really dont remember...Maybe I was watching TV with my friend Quentin Oat after a long day at work." },
                {"Mr.White.Is that your car?", "Yes, it's my car. Sorry, I lied. I killed that guy." }

            }),
            new Witness("Quentin Oat","witness",new Dictionary<string, string>()
            {
                {"Did you know a victim?","Yes,he was a ruthless mafia boss" },
                {"Do you recognise this knife?","Not,your honor" },
                {"Can you tell us something about yourself?","My name is Quentin Oat. I am a friend of Alan White" },
                {"What do you know about mr.Tuck's death?", "Nothing special,you really think he did it?." },
                {"Mr.Oat.What did you do on June 28 at 9 pm?", "I was watching TV with Alan" },
                {"Mr.Oat.Do you remember something more?","No."}
            }),
             new Witness("Maria Carter","witness2",new Dictionary<string, string>()
            {
                {"Did you know a victim?","No, I dont" },
                {"Do you recognise this knife?","Not,your honor" },
                {"Can you tell us something about yourself?","My name is Maria Carter. I am 65 years old. I live near the river." },
                {"Ms.Carter.What did you do on June 28 at 9 pm?", "I was smoking a cigarette on my balcony and then I saw mr.Alan White and another man. They looked really frightened. They were looking around " +
                     " nervosly. They quickly jumped into a black mercedes" },
                 {"What do you know about mr.Tuck's death?", "I know that he was found in the river without his head." },
                {"Ms.Carter.Do you remember something more?","I made a photo of castle on June 28 at 9pm, because it looked so beautifull from my balcony. After that crime came out " +
                     "I remembered their weird behavior so I decided to take a look at that photo and I found out that I captured that black mercedes on my photo. Please,your honor."},
            })

        };

        private List<Opinion> opinions22 = new List<Opinion>()
        {
            Opinion.Neutral,
            Opinion.Neutral,
            Opinion.Guilty,
            Opinion.Guilty,
            Opinion.Guiltyless,
            Opinion.Guilty
        };

        private Evidences evidences22 = new Evidences(
             new List<Evidence>() {
            new Evidence("Debts", "Suspect needed to pay victim a lot of money"),
            new Evidence("Victim Reputation", "Victim,Robert Tuck,was known as ruthless \"Golden Eye\" boss. There are some evidences that this company was only a cover for some illegal bussiness"),
            new Evidence("Victim Body", "Victim was found without head on the bottom of river. Death time: 28 June between 7-11 pm."),
            new Evidence("Car","Black mercedes photo"),
            new Evidence("Situation","Ms.Carter said she saw mr.White near the river on June 28 at 9 pm.")
        });

        private Document document22 = new Document("Preliminary Report\n", "\nAfter mr.Black process we decided to take closer look at Alan White. The case concerns Robert Tuck's death.\n" +
            "As suspect said,he owed Tuck 100k american dollars. After preliminary questions to mr.White I think that he may be a murderer.", "Detective Alex Morgan");

        private static List<Motivation> motivations22 = new List<Motivation>()
        {
            new Motivation("Person"),
            new Motivation("Situation"),
            new Motivation("Car"),
            new Motivation("Weapon"),
            new Motivation("Victim Reputation"),
            new Motivation("Victim")
        };

        private List<Questions> questions22 = new List<Questions>()
        {
            new Questions(motivations22[0], "Can you tell us something about yourself?"),
            new Questions(motivations22[2], "Mr.White.Is that your car?", "suspect", 80),
            new Questions(motivations22[1], "Ms.Carter.What did you do on June 28 at 9 pm?","witness2",30),
            new Questions(motivations22[1], "Mr.Oat.What did you do on June 28 at 9 pm?","witness",-10),
            new Questions(motivations22[1], "Mr.White.What did you do on June 28 at 9 pm?","suspect",-10),
            new Questions(motivations22[5], "Did you know a victim?",0),
            new Questions(motivations22[1], "Ms.Carter.Do you remember something more?","witness2",40),
            new Questions(motivations22[1], "Mr.Oat.Do you remember something more?","witness",0),
            new Questions(motivations22[3], "Do you recognise this knife?",0),
            new Questions(motivations22[4], "What do you know about mr.Tuck's death?",0),
        };

        

        public void startGame()
        {

            //Scene 2 guiltyless
            questions22[2].lockQuestion(questions22[6]);
            questions22[6].lockQuestion(questions22[1]);
            questions22[3].lockQuestion(questions22[7]);

            //Scene 2
            questions2[0].lockQuestion(questions2[0]);

            
            System.Random random = new System.Random();
            Poor poor = (Poor)groups[4];
            Rich rich = (Rich)groups[5];

            List<Scene> scenes = new List<Scene>()
            {
                new Scene(groups,judge,jury,people,evidences,document,motivations,questions,new List<String>(){
                    "\n \"Aligator\" mafia members claim that Black was innocent. They decisively responded to your absurd verdict.\n" +
                    "They started riots. Civils are afraid of their safety. They blame you for the situation. Such strong mafia reaction makes you think that maybe you overlooked" +
                    " some important facts. \n",
                    "\n You decided to free Edward Black. It doesnt look like he did it...\n" +
                    "You suggested detectives to make closer look at the witness Alan White. He owed Tuck 100k dollars. To be honest he is a beneficient of that crime.\n"
                }),
            };
            
      
          //  Console.WriteLine("Starting...\n");
            verdict = scenes[0].openScene();

            foreach (Group g in groups)
            {

                if (g.SuggestedVerdict == verdict)
                {
                    g.Reputation = g.Reputation + 10;
                }
                else if(g.SuggestedVerdict != Opinion.Neutral)
                {
                    g.Reputation = g.Reputation - 20;
                }
                Console.WriteLine(g.getName());
                g.getState();
            }

            if (verdict == Opinion.Guilty)
            {
                scenes.Add(new Scene(groups, judge, jury, people2, evidences2, document2, motivations2, questions2, new List<String>(){
                    "\nI decided that there is no place for such behaviour. Frank Water must be punished\n" +
                    "\"Aligator\" will be really mad right now but I am on my way to talk with police to allow them to arrest any potential \"Aligator\" member\n" +
                    "Let the war start...\n",
                    "\nI decided to let Mr.Water free. We don't need war with \"Aligator\". I hope that they will soon forget about case. Maybe should I start Tuck's death process once again?\n" +
                    "I will decide tomorrow..."
                },
                opinions2
                )) ;

            }
            else
            {
                scenes.Add(new Scene(groups, judge, jury, people22, evidences22, document22, motivations22, questions22,
                new List<String>()
                {
                    "\n We finally found a murderer of Tuck. Moreover we found out that a second man was Quentin Oat. They both got 25 years in jail." +
                    "\nRight now they are heading to special closed mental house because some people suggest they are mentally ill. We will find out." +
                    "\nThey said that Mr.Tuck was intimidating them, he was continuosly increasing their debts. They were really afraid of their lives and families." +
                    "\nPersonally I somehow understand why they did it but there is no explanation for that kind of crime.\nI believe they will behave good in jail so they get a parole.\n",
                    "\nI decided that there are no unambiguous evidences to say if Alan White was guilty. Maybe if there will be some other evidences we will get back to that case,but right now we leave it...\n"
                    

                },opinions22
                ));
             
            }


            for(int i = 1; i < scenes.Count;i++)
            {
                int number = random.Next(1, 5);

                if (number == 3)
                {
                    poor.unite(rich);
                    Console.WriteLine("\nSociety is united now and have " + (poor.getInfluenceLevel() + rich.getInfluenceLevel()) + " influence \n");
                }

                verdict = scenes[i].openScene();

                foreach (Group g in groups)
                {

                    if (g.SuggestedVerdict == verdict)
                    {
                        g.Reputation = g.Reputation + 10;
                    }
                    else if (g.SuggestedVerdict != Opinion.Neutral)
                    {
                        g.Reputation = g.Reputation - 20;
                    }
                    Console.WriteLine(g.getName());
                    g.getState();
                }

                Jury.GuiltyScore = 50;
            }
            
            
        }
    }
}
