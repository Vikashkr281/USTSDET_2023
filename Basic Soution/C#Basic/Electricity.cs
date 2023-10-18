using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic
{
    public class Electricity
    {
      public  int consumernumber, prevoiusReading, currentReading;
       public     string? consumerName;

        public Electricity(int consumernumber, int prevoiusReading, int currentReading, string? consumerName)
        {
            this.consumernumber = consumernumber;
            this.prevoiusReading = prevoiusReading;
          this.currentReading = currentReading;
            this.consumerName = consumerName;
        }

        /*public  Electricity() 
        {
            consumernumber = 23456;
            prevoiusReading = 9000;
            CurrentReading = 9300;
            consumerName = "vikash";
        }*/


        public double CalculateNumber()
        {
            double billamount;
            int reading = currentReading - prevoiusReading;
            if (reading<=100)
            {
                billamount = reading * 2.00;
                
            }
            else if(reading<=201 )
            {
                billamount = 100 * 2 + (reading-100)*2.5;
            }
            else if (reading<=300)
            {
                billamount = 100 * 2 + 100 * 2.5 + (reading - 200) * 4;
            }
            else
            {
                billamount = 100 * 2 + 100 * 2.5 + 100*4 +(reading - 300) * 5;
            }
            return billamount;
        }

    }
}
