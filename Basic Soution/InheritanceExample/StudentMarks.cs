using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal class StudentMarks : StudentDetails
    {
        /*public StudentMarks(int roll, string name, string city, int marks1, int marks2, int marks3, int total, double average) : base(roll, name, city)
        {
            Marks1 = marks1;
            Marks2 = marks2;
            Marks3 = marks3;
            Total = total;
            Average = average;
        }*/

        public int Marks1 { get; set; }
        public int Marks2 { get; set; }
        public int Marks3 { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }

        public void TotalMarks()
        {
            int sum = 0;
            sum += Marks1 + Marks2 + Marks3;
            Console.WriteLine("Total Marks is {0}", sum);
        }
        public void AVERAGEOFStudent()
        {
            Average = (Marks3 + Marks2 + Marks1) / 3;
        }


    }
}