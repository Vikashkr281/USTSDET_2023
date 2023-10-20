using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_19_oct
{
    internal class Student
    {
        String name;
        int[] marks = new int[3];
        char grade;
        int sum = 0;

        public Student(string name, int[] marks)
        {
            this.name = name;
            this.marks = marks;
        }
        public void TotalMarks()
        {
            foreach (int mark in marks) 
            {
                 sum=sum+mark;
            }
        }
        public void Display()
        {
            Console.Write("Student Name = {0}", name);
            for(int i = 0; i < marks.Length; i++) 
            {
                Console.Write("  Marks = {0}\t",marks[i]);
            }
            TotalMarks();
            Console.Write("  Total = {0}",sum);
            Console.WriteLine("\t Average = {0}\t",sum/3);
    
        }
    }
}
