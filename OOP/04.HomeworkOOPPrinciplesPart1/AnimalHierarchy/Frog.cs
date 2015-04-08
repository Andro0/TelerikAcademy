namespace AnimalHierarchy
{
    using System;

    class Frog : Animal
    {
        public Frog(string name, ushort age, Gender sex)
            : base(name, age, sex)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Kvak-kvak!");
        }
    }
}
