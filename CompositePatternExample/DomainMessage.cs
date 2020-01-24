using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternExample
{
    public class DomainMessage : IMessage
    {
        public DomainMessage(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void ShowMessages(int sub)
        {
            Console.WriteLine(new string('-', sub) + Name);
        }
    }
}
