using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_25_oct
{
    internal class LifeInsurance : InsurancePoliceAbstract
    {    
       public int age {  get; set; }
        public override double CalculatePremium()
        {
            if (age > 60)
            {
                premimumAmount = premimumAmount + premimumAmount * 2.5;
                return premimumAmount;
            }
            else
            {
                premimumAmount = premimumAmount + premimumAmount * 4;
                return premimumAmount;
            }
        }
    }
}
