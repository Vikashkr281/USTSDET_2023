using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_25_oct
{
    internal class InsurancePolicy
    {
        public string? policyName;
        public int policyID;
        public double premiumAmount;

        public InsurancePolicy(string? policyName, int policyID, double premiumAmount)
        {
            this.policyName = policyName;
            this.policyID = policyID;
            this.premiumAmount = premiumAmount;
        }
        public Double RenewPolicy()
        {
            premiumAmount = premiumAmount + premiumAmount * 1.1;
            return premiumAmount;
        }
        public Double RenewPolicy(double perimum )
        {
           double premiumAmount = perimum;
            return premiumAmount;
        }

    }
}
