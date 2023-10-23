using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_23_oct
{
    internal class Employee : Person, IDisplayable
    {
        public Employee(string? firstName, string? lastName, int age) : base(firstName, lastName, age)
        {
        }

        public void DisplayInfo()
        {
            Console.WriteLine("First Name = {0} \t Last Name = {1} \t Age = {2} ",FirstName,LastName,Age);
        }
    }
}
