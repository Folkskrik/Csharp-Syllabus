using System;
namespace Hierarchy
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _adress;
        private int _id;

        public Person()
        {
            
        }

        public Person(string firstName, string lastName, string adress, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _firstName = adress;
            _id = id;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set {_lastName = value; }
        }

        public string Adress
        {
            get { return _adress; }
            set {_adress = value; }
        }

        public int Id
        {
            get { return _id; }
            set {_id = value; }
        }

        public virtual void Display()
        {
            Console.WriteLine("First name: {0}",_firstName);
            Console.WriteLine("Last name: {0}",_lastName);
            Console.WriteLine("Adress: {0}",_adress);
            Console.WriteLine("ID: {0}",_id);
        }
    }
}