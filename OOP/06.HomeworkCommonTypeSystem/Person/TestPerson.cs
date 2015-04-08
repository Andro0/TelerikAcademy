
namespace Person
{
    using System;
    class TestPerson
    {
        static void Main(string[] args)
        {
            Person pperson1 = new Person("Stanka", 18);
            Person person2 = new Person("Penka");

            Console.WriteLine(pperson1);
            Console.WriteLine(person2);
        }
    }
}
