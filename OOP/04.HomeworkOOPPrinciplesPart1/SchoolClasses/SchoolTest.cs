/*Problem 1. School classes
    We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches
    a set of disciplines. Students have name and unique class number. Classes have unique text identifier. Teachers have name.
    Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. Students, classes,
    teachers and disciplines could have optional comments (free text block).
    Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define
    the class hierarchy and create a class diagram with Visual Studio.
*/

namespace SchoolClasses
{
    using System;
    using System.Text;

    internal class SchoolTest
    {
        public static void Main()
        {
            School school = LoadSchool();
            Console.WriteLine(PrintSchoolInfo(school));
        }

        private static School LoadSchool()
        {
            School school = new School("Hristo Botev");

            Class sixA = new Class("6a");
            sixA.Comment = "Comment for 6a";
            Class sixB = new Class("6b");


            Student pesho = new Student("Pesho");
            pesho.Comment = "The best";
            Student ivancho = new Student("Ivancho");
            ivancho.Comment = "Very smart";
            Student dragan = new Student("Dragan");
            dragan.Comment = "Average level";
            Student petkan = new Student("Petkan");
            petkan.Comment = "Sub zero";
            Student maria = new Student("Maria");
            maria.Comment = "Top model";
            Student stanka = new Student("Stanka");
            stanka.Comment = "Heavy duty";


            Discipline math = new Discipline("Math", 8, 8);
            Discipline physics = new Discipline("Physics", 6, 6);
            Discipline biology = new Discipline("Biology", 3, 3);
            Discipline chem = new Discipline("Chemistry", 2, 2);
            Discipline english = new Discipline("English", 6, 6);

            Teacher goshkova = new Teacher("Goshkova");
            goshkova.Comment = "Every student will have mark 2";
            Teacher petrova = new Teacher("Petrova");
            Teacher ivanova = new Teacher("Ivanova");
            Teacher baltieva = new Teacher("Baltieva");
            baltieva.Comment = "Big jigsaw";

            petrova.AddDiscipline(math);
            ivanova.AddDiscipline(physics);
            baltieva.AddDiscipline(chem);
            goshkova.AddDiscipline(english);

            sixA.AddStudent(pesho);
            sixA.AddStudent(ivancho);
            sixA.AddStudent(maria);
            sixA.AddTeacher(goshkova);
            sixA.AddTeacher(petrova);

            sixB.AddStudent(dragan);
            sixB.AddStudent(petkan);
            sixB.AddStudent(stanka);
            sixB.AddTeacher(ivanova);
            sixB.AddTeacher(baltieva);

            school.AddClass(sixA);
            school.AddClass(sixB);

            return school;
        }

        private static string PrintSchoolInfo(School school)
        {
            StringBuilder builder = new StringBuilder("School: " + school.Name).AppendLine("\n");

            foreach (Class classes in school.Classes)
            {
                builder.AppendLine("Class " + classes.TextID + " // " + (classes.Comment == null ? "No comment" : classes.Comment));
                foreach (Teacher teacher in classes.Teachers)
                {
                    builder.AppendLine("  " + teacher.ToString() + " // " + (teacher.Comment == null ? "No comment" : teacher.Comment));
                }

                foreach (Student student in classes.Students)
                {
                    builder.AppendLine("  " + student.ToString() + " // " + (student.Comment == null ? "No comment" : student.Comment));
                }
                builder.AppendLine();
            }

            return builder.ToString();
        }
    }
}
