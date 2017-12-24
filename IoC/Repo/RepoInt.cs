using System;
using System.Collections.Generic;
using System.Text;
using IoC.Entitites;
using IoC.Outs;

namespace IoC.Repo
{
    public class RepoInt : IRepo
    {
        private IOut OutObj { get; set; }
        private ObjInt ObjInt { get; set; }

        public RepoInt(IOut outObj, ObjInt objInt)
        {
            OutObj = outObj;
            ObjInt = objInt;
        }

        public void Show()
        {
            OutObj.Write(ObjInt.GetObj());
        }
    }
}
