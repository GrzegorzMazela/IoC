using System;
using System.Collections.Generic;
using System.Text;
using IoC.Entitites;
using IoC.Outs;

namespace IoC.Repo
{
    public class Repo<T> : IRepo<T> where T : IObj, new()
    {
        private IOut OutObj { get; set; }
        private T Tobj { get; set; }

        public Repo(IOut outObj)
        {
            OutObj = outObj;
            Tobj = new T();
        }


        public void Show()
        {
            OutObj.Write(Tobj.GetObj());
        }
    }
}
