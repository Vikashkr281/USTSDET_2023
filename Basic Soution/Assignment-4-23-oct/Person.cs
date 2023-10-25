using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_23_oct
{
    internal class Person
    {
        string? firstName;
        string? lastName;
        int age;

        public Person(string? firstName, string? lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string? FirstName
        {
            get {
                
                return firstName; }
            set
            {

                firstName = value;
            }
               
        }
       public string? LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set {
                if (age > 18 && age < 100)
                    age = value;
               


             else
             Console.WriteLine("Enter the age between 18-100");
            }
        }
        }

    }

