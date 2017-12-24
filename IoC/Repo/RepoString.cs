using System;
using System.Collections.Generic;
using System.Text;
using IoC.Entitites;
using IoC.Outs;

namespace IoC.Repo
{
    public class RepoString : IRepo
    {
        private IOut OutObj { get; set; }
        private ObjString ObjString { get; set; }

        public RepoString(IOut outObj, ObjString objString)
        {
            OutObj = outObj;
            ObjString = objString;
        }

        public void Show()
        {
            OutObj.Write(ObjString.GetObj());
        }
    }
}
