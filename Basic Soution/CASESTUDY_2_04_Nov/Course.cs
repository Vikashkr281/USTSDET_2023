using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASESTUDY_2_04_Nov
{
    internal class Course : IEnrolable
    {
        public int CourseCode { get; set; }
        public string? CourseName { get; set; }
        public string? Instructor { get; set; }

        public int MaxCount { get; set; }

        public List<Student> Enrolment = new List<Student>();
        public static List<Course> Cources = new List<Course>();

        public void CourseRegistration()
        {
            Course course = new Course();
            Console.Write("\tEnter the Cource code:");
            course.CourseCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tEnter the Cource:");
            course.CourseName = Console.ReadLine();
            Console.Write("\n\tEnter the instructor Name:");
            course.Instructor = Console.ReadLine();
            Console.Write("\n\tEnter the Maximom Capacity:");
            course.MaxCount = Convert.ToInt32(Console.ReadLine());

            Course.Cources.Add(course);




        }

        public void Withdrawal()
        {
            if (Course.Cources.Count == 0)
            {
                Console.WriteLine("*******No Courses Found********");
            }
            else
            {


                foreach (var list in Course.Cources)
                {
                    Console.WriteLine("CorseId:{0}\tCourse Name:{1}\tInstructor Name:{2}\tCapacity:{3}", list.CourseCode,
                        list.CourseName, list.Instructor, list.MaxCount);

                }
                Console.WriteLine("Enter the Course id to remove the course");
                int courseId = Convert.ToInt32(Console.ReadLine());
                int countDel = Course.Cources.RemoveAll(x => x.CourseCode == courseId);
                if (countDel > 0)
                {
                    Console.WriteLine("Course deleted successfully");
                }
                else
                {
                    Console.WriteLine("Invalid Course code");
                }

            }
        }
        public void DisplayCourses()
        {

            if (Cources.Count > 0)
            {

                foreach (var list in Course.Cources)
                {
                    Console.WriteLine("CorseId:{0}\tCourse Name:{1}\tInstructor Name:{2}\tCapacity:{3}", list.CourseCode,
                           list.CourseName, list.Instructor, list.MaxCount);


                    if (list.Enrolment.Count > 0)
                    {
                        Console.WriteLine("Students registered for this course");
                        foreach (var enrolment in list.Enrolment)
                        {
                            Console.WriteLine("Student id:{0}\tstudent name:{1}\tEmail:{2}", enrolment.StudentId,
                                enrolment.Name, enrolment.Email);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No students registered for this course");
                    }
                }
            }
            else
            {
                Console.WriteLine("no courses Availble");
            }
        }
    }
}
