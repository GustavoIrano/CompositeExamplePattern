using System;

namespace CompositePatternExample
{
    public class InputFormMessage : IMessage
    {
        public InputFormMessage(string name)
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
