namespace AnimalHierarchy
{
    using System;

    class Kitten : Cat
    {
        public Kitten(string name, ushort age)
            : base(name, age, Gender.Female)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Kitten Miaw!");
        }
    }
}
