using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic
{
    internal class Employees
    {
        int eid;
        string? ename, dept;
        double basicPay;
        private readonly int bonus =10;
       

        public Employees(int eid, string? ename, string? dept, double basicPay)
        {
            Eid = eid;
            Ename = ename;
            Dept = dept;
            BasicPay = basicPay;
        }

        public int Eid { get => eid; set => eid = value; }
        public string? Ename { get => ename; set => ename = value; }
        public string? Dept { get => dept; set => dept = value; }
        public double BasicPay { get => basicPay; set => basicPay = value; }

        public int Bonus => bonus;

        public double CalculateSalary()
        {    
            double netSalary, grossalary;
            double allowances = BasicPay * 0.3 + BasicPay * 0.2 + BasicPay * 0.15;
            grossalary = BasicPay+allowances;
            double deducation = BasicPay * 0.1;
            netSalary = grossalary - deducation;
            return netSalary;
        }
    }
}
