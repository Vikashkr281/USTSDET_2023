// See https://aka.ms/new-console-template for more information

using Assignment_5_25_oct;

InsurancePolicy insurancePolicy = new("LIC", 1, 4000);
Console.WriteLine("premimum amount"+insurancePolicy.RenewPolicy());
Console.WriteLine("Updated amount"+ insurancePolicy.RenewPolicy(5000));
CarInsurance carInsurance = new();
carInsurance.vechicleType = "private";
carInsurance.policyName = "Easy by";
carInsurance.policyId = 1;
carInsurance.premimumAmount = 456778;

double amount = carInsurance.CalculatePremium();
Console.WriteLine("Vechicle Type ={0}\t PolicyName ={1}\t Policy Id{2}",carInsurance.vechicleType, carInsurance.policyName,carInsurance.policyId);
Console.WriteLine("Total amount = {0}", amount);

LifeInsurance lifeInsurance = new();
lifeInsurance.age = 50;
lifeInsurance.policyName = "dfgh";
lifeInsurance.policyId = 1;
lifeInsurance.premimumAmount = 4567;

double amountOfLife = lifeInsurance.CalculatePremium();
Console.WriteLine("Age={0}\t PolicyName=  {1}\t policy Id {2} ", lifeInsurance.age, lifeInsurance.policyName, lifeInsurance.policyId);
Console.WriteLine("total amount={0}", amountOfLife);

