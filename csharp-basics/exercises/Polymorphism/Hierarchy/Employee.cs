using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Employee : Person
    {
        private string jobTitle;

        public Employee(string jobTitle)
        {
            jobTitle = jobTitle;
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Job title: {0}", jobTitle);
        }
    }
}