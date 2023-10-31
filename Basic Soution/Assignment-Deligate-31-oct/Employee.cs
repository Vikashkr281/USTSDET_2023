using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Deligate_31_oct
{
    internal class Employee
    {
        public Employee(int employeeID, string? name, double performanceRating)
        {
            EmployeeID = employeeID;
            Name = name;
            PerformanceRating = performanceRating;
        }

        public int EmployeeID { get; set; }
        public string? Name { get; set; }
        public double PerformanceRating {  get; set; }

        public static double CalculateGenralBonus(Employee employee)
        {
            double total = employee.PerformanceRating * 500;
            return total;
        }
        public  static double DiwaliBonus(Employee employee) 
        {
        double totals= employee.PerformanceRating * 900;
            return totals;
        }
    }
}
