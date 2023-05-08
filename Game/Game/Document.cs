using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Document : Evidence,Item
    {
        protected string content;
        protected string name;
        protected string author;

        public Document(string _name,string _content,string _author) : base(_name,_content)
        {
            Content = _content;
            name = _name;
            author = _author;
        }

        public string Content
        {
            get => content;
            set => content = value;
        }

        public void use()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(name+"\n");
            Console.WriteLine(Content);
            Console.WriteLine("\t\t\t\t\t\t\t" + author);
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------");
        }
    }
}
