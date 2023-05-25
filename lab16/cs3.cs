using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string School { get; set; }
    }
    internal class cs3
    {
        public static void task_3()
        {
            Student[] students =
            {
                new Student { FirstName = "John", LastName = "Doe", Age = 21, School = "HPLE" },
                new Student { FirstName = "Jane", LastName = "Smith", Age = 19, School = "Oxford" },
                new Student { FirstName = "Boris", LastName = "Johnson", Age = 20, School = "Oxford" },
                new Student { FirstName = "Alice", LastName = "Brown", Age = 22, School = "HPLE" },
                new Student { FirstName = "Peter", LastName = "Brooks", Age = 18, School = "Harvard" }
            };  

            //Отримати весь масив студентів
            var allStudents = from student in students
                              select student;

            //список студентів з ім'ям "Boris"
            var studentsWithNameBoris = from student in students
                                        where student.FirstName == "Boris"
                                        select student;

            //список студентів з прізвищем, яке починається з "Bro"
            var studentsLastNameWithBro = from student in students
                                                      where student.LastName.StartsWith("Bro")
                                                      select student;

            //список студентів, старших 19 років
            var studentsOlderThan19 = from student in students
                                      where student.Age > 19
                                      select student;

            //список студентів, старших 20 років і молодших 23 років
            var studentsBetween20And23 = from student in students
                                         where student.Age > 20 && student.Age < 23
                                         select student;

            //список студентів, які навчаються в HPLE
            var studentsInHPLE = from student in students
                                where student.School == "HPLE"
                                select student;

            //список студентів, які навчаються в Oxford і вік яких старше 18 років. Результат відсортований за віком, за спаданням
            var studentsInOxfordOver18 = from student in students
                                         where student.School == "Oxford" && student.Age > 18
                                         orderby student.Age descending
                                         select student;

            // Вивід результатів
            Console.WriteLine("Task 3:");
            Console.WriteLine("All Students:");
            foreach (var student in allStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, School: {student.School}");
            }

            Console.WriteLine("\nStudents with name Boris:");
            foreach (var student in studentsWithNameBoris)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, School: {student.School}");
            }

            Console.WriteLine("\nStudents with last name starting with Bro:");
            foreach (var student in studentsLastNameWithBro)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, School: {student.School}");
            }

            Console.WriteLine("\nStudents older than 19:");
            foreach (var student in studentsOlderThan19)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, School: {student.School}");
            }

            Console.WriteLine("\nStudents between 20 and 23 years old:");
            foreach (var student in studentsBetween20And23)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, School: {student.School}");
            }

            Console.WriteLine("\nStudents in HPLE:");
            foreach (var student in studentsInHPLE)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, School: {student.School}");
            }

            Console.WriteLine("\nStudents in Oxford over 18 (Descending Age):");
            foreach (var student in studentsInOxfordOver18)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, School: {student.School}");
            }
        }
    }
}
