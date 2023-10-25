using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_25_oct
{
    internal abstract class InsurancePoliceAbstract
    {
        public string? policyName; 
        public int  policyId;
        public double premimumAmount;

        public abstract double CalculatePremium();
    }
}
