using System;

namespace Hierarchy
{
    public class Student : Person
    {
        private double _gpa;

        public Student(double gpa)
        {
            _gpa = gpa;
        }

        public double GPA
        {
            get { return _gpa; }
            set {_gpa = value; }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("GPA: {0}",_gpa);
        }
    }
}