using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    interface IInherit
    {
        void Method1();
    }

    interface IChild : IInherit
    {
        void Method2();
    }

    class MyClass : IChild
    {
        public void Method1()
        {
            throw new NotImplementedException();
        }

        public void Method2()
        {
            throw new NotImplementedException();
        }
    }

    public interface A
    {
        void Method();
        void MethodA();
    }

    public interface B
    {
        void Method();
        void MethodB();
    }
    public interface C : A, B
    {

    }

    public class ClassC : C
    {
        public void Method()
        {
            Console.WriteLine("Class Method");
        }

        void A.Method()
        {
            Console.WriteLine("Inteface A Method");
        }

        void B.Method()
        {
            Console.WriteLine("Inteface B Method");
        }

        public void MethodA()
        {
            Console.WriteLine("Class Method A");
        }

        public void MethodB()
        {
            Console.WriteLine("Class Method B");
        }
    }

}
