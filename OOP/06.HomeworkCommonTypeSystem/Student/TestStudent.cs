
namespace Student
{
    using System;
    class TestStudent
    {
        static void Main(string[] args)
        {
            Student student = new Student("Acho", "A", "Achov", 22222222, "Telerik", "+359 222222", "achoachev@telerik.com");
            student.FillUniversityInfo(Student._University.SofiaUniversity, 7, Student._Faculty.Mathematics, Student._Speciality.IT);
            Console.WriteLine(student.GetHashCode());
            Student student2 = new Student("Pencho", "P", "Penchev", 99999999, "Telerik", "+359 999999", "pencho.penchev@telerik.com");
            student2.FillUniversityInfo(Student._University.TechnicalUniversity, 8, Student._Faculty.Mathematics, Student._Speciality.IT);
            Console.WriteLine(student2.GetHashCode() + Environment.NewLine);

            Console.WriteLine(student);
            Console.WriteLine(student2);
            Console.WriteLine(student == student2);
            Console.WriteLine(student.Equals(student));
            Console.WriteLine(student.Equals(student2));
            Console.WriteLine(student != student2);
        }
    }
}
