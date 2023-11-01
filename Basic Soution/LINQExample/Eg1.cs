using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace LINQExample
{
    internal class Eg1
    {
        public void eg1()
        {

            List<string> list = new List<string>();
            list.Add("dbms");
            list.Add("sql");
            list.Add("java");
            list.Add("c++");
            list.Add("c");

            var result=from c in list where c.Equals("c") select c;
            var x=list.Find(x=>x.Equals("c"));
            var y=list.Where(x=>x.Equals("c"));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }
        public void eg2()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "AA", "BB"));
            students.Add(new Student(2, "CC", "DD"));
            students.Add(new Student(3, "EE", "FF"));
            students.Add(new Student(4, "GG", "HH"));
            students.Add(new Student(4, "II", "JJ"));
            var std = students.Where(x => x.Id == 1);
            foreach (var student in std)

            {
                Console.WriteLine($"student Id = {student.Id} student name = {student.Name}");
            }

            // agar ye fix ho ke  humko ek he data milega tab us case me hum log var keyword ka use nahi kaernge ok
            // eg

            Student stud = (Student)students.FirstOrDefault(x => x.Id == 1);
            Console.WriteLine(stud.Id + " " + stud.Name);

            // aur agar humko object type deta type chachiye us case me hum student class type he use karenge var ke jagah par
            List<Student> st = (List<Student>)students.FindAll(x => x.Id == 2);
            foreach (var student in st)
            {
                Console.WriteLine(student.Id + " " + student.Name);
            }
        }
        }
    }

