using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Entitites
{
    public class ObjDateTime : IObj
    {
        public string GetObj()
        {
            return DateTime.Now.ToLongDateString();
        }
    }
}
