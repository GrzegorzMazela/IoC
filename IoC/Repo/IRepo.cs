using System;
using System.Collections.Generic;
using System.Text;
using IoC.Entitites;

namespace IoC.Repo
{
    public interface IRepo
    {
        void Show();
    }

    public interface IRepo<T> where T: IObj
    {
        void Show();
    }
}
