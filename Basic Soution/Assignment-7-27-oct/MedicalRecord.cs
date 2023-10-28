using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_27_oct
{
    internal class MedicalRecord : Patient
    {
        public static List<MedicalRecord> list1 = new List<MedicalRecord>();
        public int RecordId { get; set; }
        public string? PatientName { get; set; }
        public string? PatientDiagnosis { get; set; }
        public double TreatmentCost { get; set; }

        public void AddDetails(MedicalRecord medical)
        {
            try
            {
                if (medical.RecordId < 0)
                {
                    throw new InvalidMedicalException("It Should be in positive");
                }
                else if (medical.TreatmentCost < 0)
                {
                    throw new InvalidMedicalException("It shoud be in positive");
                }
                else
                {
                    list1.Add(medical);

                }
            }
            catch (InvalidMedicalException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
       
    }
}
        
