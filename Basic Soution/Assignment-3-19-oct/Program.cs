// See https://aka.ms/new-console-template for more information
using Assignment_3_19_oct;

Student[] students = new Student[3];
for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine("enter the Name");
    string name = Console.ReadLine();
    int[] marks = new int[3];
    for (int j = 0; j < marks.Length; j++)
    {
        marks[j] = Convert.ToInt32(Console.ReadLine());
    }
    students[i]=new Student(name, marks);

    if(i<2)
    {
        Console.WriteLine("enter the New Data");
    }
}



for(int i = 0;i<3;++i)
{
    students[i].Display();
}