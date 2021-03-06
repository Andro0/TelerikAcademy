﻿namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        protected string name;
        protected Gender sex;
        protected ushort age;

        protected string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected ushort Age
        {
            get { return age; }
            set { age = value; }
        }

        protected Gender Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        protected Animal(string name, ushort age, Gender sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public abstract void MakeSound();

        public static dynamic CalculateAverageAge(IEnumerable<Animal> animals)
        {
            var averageAge =
                from animal in animals
                group animal by animal.GetType() into kind
                select new
                {
                    KindName = kind.Key.Name,
                    AverageAge = kind.Average(animal => animal.Age)
                };

            return averageAge;
        }

        public override string ToString()
        {
            return string.Format("My name is {0,-10} and I am {1,2} years old. My kind is {2,-6} and my gender is {3,-8}",
                this.name, this.age, this.GetType().Name, this.sex);
        }

    }
}