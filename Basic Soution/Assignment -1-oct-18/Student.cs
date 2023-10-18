using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__1_oct_18
{
    public class Student
    {
        public string name;char grades;
        public int marks1, marks2, marks3;

        public Student(string name,int marks1,int marks2,int marks3)
        {
            this.name = name;
            this.marks1 = marks1;
            this.marks2 = marks2;
            this.marks3 = marks3;
        }

        public char calculateAverage()
        {   double Average=(marks1 + marks2 +marks3)/3;

            if(Average > 89)
            {
                return 'A';
            }
            if(Average > 79)
            {
                return 'B';
            }
            if (Average > 69)
            {
                return 'C';
            }
            if (Average > 59)
            {
                return 'D';
            }
           return 'E';
        }
    }
}
