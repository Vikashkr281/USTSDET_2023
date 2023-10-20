using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal class StudentDetails
    {
        /*public StudentDetails(int roll, string name, string city)
        {
            this.roll = roll;
            this.name = name;
            this.city = city;
        }*/

        public  int roll { get; set; }
        public string name { get; set; }
        public string city { get; set; }  
        
        public void Display()
        {
            Console.WriteLine("Name = {0} \t Roll = {1} \t City = {2} ",name,roll,city);
        }

    }
}
