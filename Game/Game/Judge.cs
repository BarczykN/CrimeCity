using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Judge : Person
    {
        public Judge(string _name, string _function) : base(_name, _function)
        {
        }

        public void askSomeone(Person person,Questions questions) { }

        public void unlockQuestions(Questions question, List<Motivation> motivations)
        {
            while (true)
            {
                int i = 1;
                foreach (Motivation m in motivations)
                {
                    Console.WriteLine("\n" + i + " - " + m.ToString());
                    i++;
                }
                Console.WriteLine("\n" + i + " quit\n");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice != i)
                {
                    Console.Clear();
                    bool result = question.connect(motivations[choice - 1]);
                    if (result)
                    {
                        Console.WriteLine("\nYou unlocked a question\n");
                        return;
                    }
                    else Console.WriteLine("\nWrong\n");
                }
                else
                {
                    Console.Clear();
                    return;
                }
            }
            

        }
    }
}
