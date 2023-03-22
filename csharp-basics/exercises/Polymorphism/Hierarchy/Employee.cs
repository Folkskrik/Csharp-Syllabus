using System;

namespace Hierarchy
{
    public class Employee : Person
    {
        private string _jobTitle;

        public Employee(string jobTitle)
        {
            _jobTitle = jobTitle;
        }

        public string JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Job title: {0}", _jobTitle);
        }
    }
}