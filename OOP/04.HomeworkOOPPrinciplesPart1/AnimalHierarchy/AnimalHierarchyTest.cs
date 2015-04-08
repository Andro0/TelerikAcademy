/*Problem 3. Animal hierarchy
    Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals.
    All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age,
    name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
    Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method
    (you may use LINQ).
*/

namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class AnimalHierarchyTest
    {
        public static void Main()
        {
            Tomcat tomcat1 = new Tomcat("Pesho", 10);
            Tomcat tomcat2 = new Tomcat("Ivan", 20);
            Tomcat tomcat3 = new Tomcat("Kiro", 30);

            Kitten kitten1 = new Kitten("Mila", 20);
            Kitten kitten2 = new Kitten("Lila", 50);
            Kitten kitten3 = new Kitten("Cura", 20);

            Dog dog1 = new Dog("Sharo", 20, Gender.Male);
            Dog dog2 = new Dog("Hristo", 10, Gender.Male);
            Dog dog3 = new Dog("Ziko", 5, Gender.Male);

            Frog frog1 = new Frog("Kwak Kwak", 20, Gender.Female);
            Frog frog2 = new Frog("Kwaaaaak", 20, Gender.Female);
            Frog frog3 = new Frog("Kwak", 20, Gender.Female);

            Cat cat1 = new Cat("Frodo", 10, Gender.Male);
            Cat cat2 = new Cat("Obama", 40, Gender.Male);

            Animal[] animals = 
            {                    
                tomcat1, kitten1, frog1, dog1, cat1,
                tomcat2, kitten2, frog2, dog2, cat2,
                tomcat3, kitten3, frog3, dog3
            };

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("All animals:");
            Console.Write(new string('_', Console.WindowWidth));

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var animal in animals)
            {
                Console.Write(animal);
                animal.MakeSound();
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(new string('_', Console.WindowWidth));

            var kinds = Animal.CalculateAverageAge(animals);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nKinds and their average age:");
            Console.Write(new string('_', Console.WindowWidth));

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var kind in kinds)
            {
                Console.WriteLine("{0,-7} - {1:F2} years", kind.KindName, kind.AverageAge);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(new string('_', Console.WindowWidth));

            Console.WriteLine();

            Console.ResetColor();
        }
    }
}
