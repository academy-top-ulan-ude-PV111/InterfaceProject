using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    interface IMovable
    {
        void Move();
    }
    class Transport : IMovable
    {
        public virtual void Move()
        {
            Console.WriteLine("Transport is move!");
        }
    }

    class Car : Transport, IMovable
    {
        public override void Move()
        {
            Console.WriteLine("Car as Transport is move!");
        }
        void IMovable.Move()
        {
            Console.WriteLine("Car is move!");
        }
    }
}
