using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Outs
{
    public class TextOut : IOut
    {
        public void Write(string txt)
        {
            Console.WriteLine($"Dupa blada: {txt}");
        }
    }
}
