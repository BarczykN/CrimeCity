using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Scene
    {
        private Verdict verdict =  new Verdict();
        private Report report = new Report();
        private Judge judge;
        private Jury jury;
        private List<Group> groups;
        private List<Person> people;
        private Evidences evidences;
        private Document document;
        private List<Motivation> motivations;
        private List<Questions> questionsF;
        private List<String> results; 
       



        public Scene(List<Group> _groups,Judge _judge,Jury _jury,List<Person> _people,Evidences _evidences,Document _document,List<Motivation> _motivations,List<Questions> _questions,List<String> _results)
        {
            groups = _groups;
            judge = _judge;
            jury = _jury;
            people = _people;
            evidences = _evidences;
            document = _document;
            motivations = _motivations;
            questionsF = _questions;
            results = _results;
        }

        public Scene(List<Group> _groups, Judge _judge, Jury _jury, List<Person> _people, Evidences _evidences, Document _document, List<Motivation> _motivations, List<Questions> _questions, List<String> _results,List<Opinion> opinions)
        {
            groups = _groups;
            judge = _judge;
            jury = _jury;
            people = _people;
            evidences = _evidences;
            document = _document;
            motivations = _motivations;
            questionsF = _questions;
            results = _results;

            int i = 0;
            foreach(Group g in groups)
            {
                g.SuggestedVerdict = opinions[i];
                i++;
            }
        }




        public Opinion openScene()
        {

            do
            {
                List<Questions> questions = new List<Questions>();
                foreach(Questions q in questionsF)
                {
                    if(q.Lock != true)
                    {
                        questions.Add(q);
                    }
                }

                Console.WriteLine(showConsole());
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        document.use();
                        break;

                    case 2:
                        evidences.use();
                        break;

                    case 3:
                        bool progress = true;

                        


                        while (progress)
                        {
                            int i = 1;
                            foreach (Questions q in questions)
                            {

                                Console.WriteLine("\n" + i + " - " + q.ToString());
                                i++;
                            }

                            Console.WriteLine("\n" + i + " quit\n");

                            int option = Convert.ToInt32(Console.ReadLine());



                            if (option != i)
                            {
                                Questions question = questions[option - 1];
                                if (!question.getIfLost())
                                {
                                    judge.unlockQuestions(question, motivations);
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n You cant use this question \n");
                                }
                                
                              
                            }
                            else
                            {
                                Console.Clear();
                                progress = false;
                            }
                        }

                        break;

                    case 4:
                        progress = true;
                        while (progress)
                        {
                            int i = 1;
                            foreach (Person p in people)
                            {
                                Console.WriteLine("\n" + i + " - " + p.ToString());
                                i++;
                            }

                            Console.WriteLine("\n" + i + " quit\n");

                            int option = Convert.ToInt32(Console.ReadLine());



                            if (option != i)
                            {
                                bool progress2 = true;
                                while (progress2)
                                {
                                   // Console.Clear();
                                    Person person = people[option - 1];
                                    i = 1;
                                    List<Questions> possibleQuestions = new List<Questions>();
                                    foreach (Questions q in questions)
                                    {
                                        if (q.getState() && (q.getWhoCanBeAsked().Equals(person.getFunction()) || q.getWhoCanBeAsked().Equals("")))
                                        {
                                            Console.WriteLine("\n" + i + " - " + q.ToString());
                                            possibleQuestions.Add(q);
                                            i++;
                                        }
                                    }


                                    Console.WriteLine("\n" + i + " quit\n");

                                    int option2 = Convert.ToInt32(Console.ReadLine());



                                    IAnswer answer = (IAnswer)person;

                                    if (option2 != i)
                                    {
                                        Questions question = possibleQuestions[option2 - 1];
                                        string result = answer.answer(question);
                                        TYPE(result);

                                        report.addText("Judge:");
                                        report.addText(question.getContent() + "\n");
                                        report.addText(person.getName() + ":");
                                        report.addText(result + "\n");

                                    }
                                    else
                                    {
                                        progress2 = false;
                                        Console.Clear();
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                progress = false;
                            }
                            
                            
                            
                        }
                        break;
                    case 5:
                        verdict.use();
                        break;

                    case 6:
                        report.use();
                        break;

                    case 7:
                        Console.WriteLine(showOpinions());
                        break;

                    case 8:
                        Console.WriteLine(Jury.SuggestedVerdict.GetString()+"\n");
                        break;

                    default:
                        Console.WriteLine("nothing");
                        break;
                }
            } while (verdict.finalVerdict == Opinion.Neutral);
            Console.Clear();
            if (verdict.finalVerdict == Opinion.Guilty)
            {
                TYPE(results[0]);
            }
            else
            {
                TYPE(results[1]);
            }
            
            return verdict.finalVerdict;
        }

        private static void TYPE(String s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
                System.Threading.Thread.Sleep(40); 
            }
        }

        private string showConsole()
        {
            return "1.Documents\n" +
                "2.Evidences\n" +
                "3.Questions\n" +
                "4.Ask someone\n" +
                "5.Verdict\n" +
                "6.Report\n"+
                "7.Show opinions\n"+
                "8.Jury Opinion\n";
        }

        private string showOpinions()
        {
            string result = "";

            foreach(Group g in groups)
            {
                result = result + g.ToString()+"\n";
            }
            return result;
        }
    }
}
