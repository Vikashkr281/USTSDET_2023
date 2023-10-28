using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_27_oct
{
    internal class Patient
    {    public static List<Patient> list = new List<Patient>();
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Diagnosis{ get; set; }
        public int Age {  get; set; }


        public void AddDetails(Patient patient)
        {
            try
            {
                if (string.IsNullOrEmpty(patient.Diagnosis))
                {
                    throw new Validate("Diagnosis Should not be null");
                }
                else if (patient.Age < 0 || patient.Age > 120)
                {
                    throw new Validate("Age Should not be negative and not more than 120");
                }
                else if (string.IsNullOrEmpty(patient.Name))
                {
                    throw new Validate("Name should not be null");
                }
                else { list.Add(patient); }
            }

            catch (Validate ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            
        }
        public void Display()
        {
            foreach (Patient patient in list)
            {
                Console.WriteLine("Id = {0} Age = {1}  Name = {2}  Diagnosis = {3} ", patient.Id, patient.Age, patient.Name, patient.Diagnosis);
            }
        }


    }
}
