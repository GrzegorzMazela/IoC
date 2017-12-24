using System;
using System.Collections.Generic;
using System.Text;
using IoC.Entitites;
using IoC.Outs;

namespace IoC.Repo
{
    public class RepoDateTime : IRepo
    {
        private IOut OutObj { get; set; }
        private ObjDateTime ObjDateTime { get; set; }

        public RepoDateTime(IOut outObj, ObjDateTime objDateTime)
        {
            OutObj = outObj;
            ObjDateTime = objDateTime;
        }

        public void Show()
        {
            OutObj.Write(ObjDateTime.GetObj());
        }
    }
}
