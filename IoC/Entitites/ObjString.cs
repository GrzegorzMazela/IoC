using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Entitites
{
    public class ObjString : IObj
    {
        public string GetObj()
        {
            return "Test!";
        }
    }
}
