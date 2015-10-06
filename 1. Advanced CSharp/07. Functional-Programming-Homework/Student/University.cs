namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class University
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
          
            var IvanIvanov = new Student("Ivan", "Ivanov", 18, 21408134, 0884179846, "vaankata@yahoo.com", new List<int>() { 6, 3, 2, 4, 5 }, 1);
            var PeturPetrov = new Student("Petur", "Petrov", 25, 21106133, 089996678, "pesho@abv.bg", new List<int>() { 5, 4, 6, 4, 2, 4, 3, }, 2);
            var GeorgiGeorgiev = new Student("Georgi", "Georgiev", 21, 21106315, 0887495831, "gosho@gmail.com", new List<int>() { 6, 4, 5, 5, 3, 4, 3, }, 2);
            var AndreiAndreev = new Student("Andrei", "Andreev", 19, 21106134, 0794135464, "andreev@abv.bg", new List<int>() { 3, 5, 4, 6, 2 }, 3);

            students.Add(IvanIvanov);
            students.Add(PeturPetrov);
            students.Add(GeorgiGeorgiev);
            students.Add(AndreiAndreev);

            //  Problem 2.	Students by Group
            var groupTwoStudents =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (var student in groupTwoStudents)
            {
                Console.WriteLine("First name = {0}, Last name = {1}, Age = {2}, Faculty number = {3}, Phone = {4}, Email = {5}, Marks = {6}, Group number = {7}", student.FirstName, student.LastName, student.Age, student.FacultyNumber, student.Phone, student.Email, string.Join(", ", student.Marks), student.GroupNumber);
            }

            // Problem 3.	Students by First and Last Name
            var studentsFirstAndLastName =
               from st in students
               where st.FirstName.CompareTo(st.LastName) < 0
               select st;

            foreach (var st in studentsFirstAndLastName)
            {
                Console.WriteLine("First name = {0}, Last name = {1}, Age = {2}, Faculty number = {3}, Phone = {4}, Email = {5}, Marks = {6}, Group number = {7}", st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone, st.Email, string.Join(" ", st.Marks), st.GroupNumber);
            }

            // Problem 4.   Student by Age
            var studentsByAge =
               from student in students
               where (student.Age >= 18 && student.Age <= 24)
               select new { student.FirstName, student.LastName, student.Age };

            foreach (var student in studentsByAge)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Age);
            }

            // Problem 5.	Sort Students
            var sortedStudents = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName).Select(st => (string.Format(st.FirstName + st.LastName)));
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            // Problem 6. Filter Students by email address
            var studentsByEmails =
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;

            foreach (var student in studentsByEmails)
            {
                Console.WriteLine("{0} {1} - {2}", student.FirstName, student.LastName, student.Email);
            }
        }

    }
}
