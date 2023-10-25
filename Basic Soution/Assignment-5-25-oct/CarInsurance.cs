using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_25_oct
{
    internal class CarInsurance : InsurancePoliceAbstract
    {
        public string? vechicleType { get; set; }
        public override double CalculatePremium()
        {
            if(vechicleType == "private")
            {
                premimumAmount = premimumAmount + premimumAmount * 1.5;
                return premimumAmount;
            }
            else
            {
                premimumAmount = premimumAmount + premimumAmount * 2.5;
                return premimumAmount;
            }
            
        }
    }
}
