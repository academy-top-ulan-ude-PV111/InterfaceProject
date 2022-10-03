using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    interface IId<T>
    {
        T Id { get; }
    }

    class User<T> : IId<T>
    {
        public T Id { get; private set; }
        public string? Name { set; get; }
    }

    class UserIntId : IId<int>
    {
        public int Id { get; private set; }
        public string? Name { set; get; }
    }
}
