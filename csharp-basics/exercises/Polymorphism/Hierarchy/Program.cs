using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(4.9);
            student.FirstName = "Peter";
            student.LastName = "Parker";
            student.Adress = "20 Ingram St";
            student.Id = 1;

            Console.WriteLine("Student:");
            student.Display();
            Console.WriteLine();

            Employee employee = new Employee("The Boss");
            employee.FirstName = "J. Jonah";
            employee.LastName = "Jameson";
            employee.Adress = "39th Street and Second Avenue";
            employee.Id = 2;
            employee.JobTitle = "CEO";

            Console.WriteLine("Employee:");
            employee.Display();

        }
    }
}