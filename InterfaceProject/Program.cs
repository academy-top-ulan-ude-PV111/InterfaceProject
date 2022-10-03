using System.Collections;

namespace InterfaceProject
{
    interface ISend
    {
        const int Max = 100;
        void Send();
        string Text { set; get; }
        delegate void MessageSend(string message);
        event MessageSend OnSend;
        void Method()
        {
            Console.WriteLine("interface method");
        }
    }

    class SmsSend : ISend
    {
        public string Text { set; get; }
        public void Send() 
        {
            Console.WriteLine("Sms: " + Text);
            OnSend?.Invoke(Text);
        }

        public event ISend.MessageSend OnSend;
    }

    class EmailSend : ISend
    {
        public string Text { set; get; }
        public void Send()
        {
            Console.WriteLine("Email: " + Text);
            OnSend?.Invoke(Text);
        }

        public event ISend.MessageSend OnSend;
    }

    class PersonNameComparer : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            return String.Compare(x.Name, y.Name);
        }
    }

    class PersonAgeComparer : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            return x.Age - y.Age;
        }
    }

    class Person //: IComparable
    {
        public string Name { set; get; }
        public int Age { set; get; }

        //public int CompareTo(object? obj)
        //{
        //    return this.Name.CompareTo((obj as Person).Name);
        //}
    }
    internal class Program
    {

        static void MessageSend(ISend send)
        {
            send.Send();
        }
        static void Main(string[] args)
        {
            //ISend send1 = new SmsSend();
            //SmsSend send2 = new SmsSend();


            //send1.Method();
            //((ISend)send2).Method();
            //(send2 as ISend).Method();

            //List<ISend> sendList = new List<ISend>() 
            //{ 
            //    new SmsSend(),
            //    new EmailSend()
            //};

            //MessageSend(new SmsSend());
            //MessageSend(new EmailSend());

            //ClassC obj = new();

            //obj.Method();
            //obj.MethodA();
            //obj.MethodB();

            //(obj as A).Method();
            //(obj as B).Method();

            //Console.WriteLine(obj is A);
            //Console.WriteLine(obj is B);
            //Console.WriteLine(obj is C);
            //Console.WriteLine(obj is ISend);

            //List<IMovable> movables = new List<IMovable>()
            //{
            //    new Transport(),
            //    new Car()
            //};
            //foreach (IMovable item in movables)
            //    item.Move();

            //IId<int> user1 = new User<int>();
            //IId<int> user2 = new UserIntId();

            //List<IId<int>> listUsers = new();
            //listUsers.Add(user1);
            //listUsers.Add(user2);

            List<Person> people = new()
            {
                new Person(){ Name = "Sam", Age = 34 },
                new Person(){ Name = "Tim", Age = 22 },
                new Person(){ Name = "Bob", Age = 41 },
                new Person(){ Name = "Joe", Age = 32 },
                new Person(){ Name = "Jim", Age = 29 },
            };
            people.Sort(new PersonNameComparer());
            foreach (Person person in people)
                Console.WriteLine($"{person.Name} {person.Age}");

            Console.WriteLine("\n-------------\n");

            people.Sort(new PersonAgeComparer());
            foreach (Person person in people)
                Console.WriteLine($"{person.Name} {person.Age}");
        }
    }
}