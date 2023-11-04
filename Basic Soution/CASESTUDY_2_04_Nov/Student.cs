using CASESTUDY_2_04_Nov.Exception1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASESTUDY_2_04_Nov
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }

        public static List<Student> Students = new List<Student>();

        public async Task Registration()
        {
            Student student = new Student();
            Console.Write("Enter the Student id\n");
            student.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Student name\n");
            student.Name = Console.ReadLine();
            Console.Write("Enter Email id\n");
            student.Email = Console.ReadLine();

            Students.Add(student);


            Console.WriteLine("****student added successfully****");
            await Task.Delay(1000);
        }



        public async Task AddCourse()
        {
            Console.WriteLine("\tchoose option\n\t 1.Existing student\n\t2.register new student");
            int studentoption = Convert.ToInt32(Console.ReadLine());
            if (studentoption == 1)
            {
                Console.Write("Enter the Student id\n");
                int studentid = Convert.ToInt32(Console.ReadLine());
                if (Students.Find(x => x.StudentId == studentid) == null)
                {
                    throw new StudentException("Invalid Student id");
                }
                else
                {
                    foreach (var list in Course.Cources)
                    {
                        Console.WriteLine("CorseId:{0}\tCourse Name:{1}\tInstructor Name:{2}\tCapacity:{3}", list.CourseCode,
                            list.CourseName, list.Instructor, list.MaxCount);
                    }
                    if (Course.Cources.Count == 0)
                    {
                        Console.WriteLine("Courses are empty");
                    }
                    else
                    {


                        Console.WriteLine("Enter the Course id to select the course");
                        int courseid = Convert.ToInt32(Console.ReadLine());
                        var checkobjcourse = Course.Cources.Find(x => x.CourseCode == courseid);
                        int count = checkobjcourse.Enrolment.Count;
                        bool checkCourseCount = checkobjcourse.MaxCount >= count;
                        if (checkobjcourse == null)
                        {
                            throw new CourceException("id not found in the Course list");
                        }
                        else if (!checkCourseCount)
                        {
                            throw new CourceException("Maximom count reached for the course");
                        }
                        else
                        {
                            var studentcheckCourse = checkobjcourse.Enrolment.Find(x => x.StudentId == studentid);
                            var studobj = Student.Students.Find(x => x.StudentId == studentid);
                            if (studentcheckCourse == null && studobj != null)
                            {
                                checkobjcourse.Enrolment.Add(studobj);
                                Console.WriteLine("student enrolled successfully");

                                ;
                            }
                            else
                            {
                                throw new StudentException("student already registered in the same course");
                            }
                        }
                    }
                }
            }
            else if (studentoption == 2)
            {
                await Registration();
                await AddCourse();
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
        public void RemoveCourseFromStudent()
        {
            Console.WriteLine("Enter the Student id");
            int studentid = Convert.ToInt32(Console.ReadLine());
            if (Students.Find(x => x.StudentId == studentid) == null)
            {
                Console.WriteLine("Invalid Student id");
            }
            else
            {
                var studobj = Students.Find(x => x.StudentId == studentid);
                var courseObj = Course.Cources.FindAll(x => x.Enrolment.FirstOrDefault(z => z.StudentId == studentid) == Students.Find(a => a.StudentId == studentid));
                Console.WriteLine("Courses selected by {0}", studobj.Name);
                foreach (var list in courseObj)
                {
                    Console.WriteLine("CorseId:{0}\tCourse Name:{1}\tInstructor Name:{2}\tCapacity:{3}", list.CourseCode,
                        list.CourseName, list.Instructor, list.MaxCount);
                }
                Console.WriteLine("Enter the Course id to remove");
                int courseid = Convert.ToInt32(Console.ReadLine());
                int a = courseObj.RemoveAll(x => x.CourseCode == courseid);
                if (a > 0)
                {
                    Console.WriteLine("Course removed successfully");
                }
                else
                {
                    Console.WriteLine("invalid course id");
                }

            }
        }
    }
}
