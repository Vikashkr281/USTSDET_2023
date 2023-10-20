// See https://aka.ms/new-console-template for more information
// Inheritance Example //

using InheritanceExample;

GradeOfStudent marks =new();
marks.name = "Vikash";
marks.roll = 1;
marks.city = "Hajipur";
marks.Marks1 = 48;
marks.Marks2 = 54;
marks.Marks3 = 56;
marks.Display();
marks.TotalMarks();
Console.WriteLine("Grade of Student is {0}",marks.CalculateGrade());

