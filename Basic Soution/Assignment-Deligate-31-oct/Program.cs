// See https://aka.ms/new-console-template for more information
using Assignment_Deligate_31_oct;
class Program
{

    public delegate double BonusCalculation(Employee employee);

    public static void Main(string[] args)
    {
        Employee employee = new Employee(1, "Vikash", 3.5);
        Employee employee1 = new Employee(2, "aromal", 4.6);
        Employee employee2 = new Employee(3, "vysanav", 7.9);

         BonusCalculation bonus = Employee.CalculateGenralBonus;
        BonusCalculation bonus1 = Employee.DiwaliBonus;

        Console.WriteLine("ID = {0} Name = {1} Rating = {2} Bonus general bonus {3}  Diwali bonus {4}", employee.EmployeeID, employee.Name, employee.PerformanceRating, bonus(employee),bonus1(employee));
        Console.WriteLine("ID = {0} Name = {1} Rating = {2} Bonus general bonus {3}  Diwali bonus {4}", employee1.EmployeeID, employee1.Name, employee1.PerformanceRating, bonus(employee1), bonus1(employee1));
        Console.WriteLine("ID = {0} Name = {1} Rating = {2} Bonus general bonus {3}  Diwali bonus {4}", employee2.EmployeeID, employee2.Name, employee2.PerformanceRating, bonus(employee2), bonus1(employee2));


    }
}
