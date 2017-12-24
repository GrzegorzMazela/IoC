using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Outs
{
    public class ConsoleOut : IOut
    {
        public void Write(string txt)
        {
            Console.WriteLine(txt);
        }
    }
}
