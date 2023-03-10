using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Student : Person
    {
        private double gpa;

        public Student(double gpa)
        {
            this.gpa = gpa;
        }

        public double GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("GPA: {0}", gpa);
        }
    }
}