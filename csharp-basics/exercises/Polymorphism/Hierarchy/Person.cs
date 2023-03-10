using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string adress;
        private int id;

        public Person()
        {
            
        }

        public Person(string firstName, string lastName, string adress, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.adress = adress;
            this.id = id;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual void Display()
        {
            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Adress: {0}", adress);
            Console.WriteLine("ID: {0}", id);
        }
    }
}
