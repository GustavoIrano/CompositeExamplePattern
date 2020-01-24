using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternExample
{
    public interface IMessage
    {
        string Name { get; set; }
        void ShowMessages(int sub);
    }
}
