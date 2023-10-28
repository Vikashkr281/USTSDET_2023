// See https://aka.ms/new-console-template for more information

using Assignment_7_27_oct;
using System.Linq.Expressions;

Console.WriteLine("Enter how many patient detail u wish to store");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter PatientId  Name Age Diagnosis");

    for (int i = 0; i < n; i++)
    {
        Patient patient = new Patient();
        patient.Id = Convert.ToInt32(Console.ReadLine());

        patient.Name = Console.ReadLine();
        
        patient.Age = Convert.ToInt32(Console.ReadLine());
        
        patient.Diagnosis = Console.ReadLine();
        
        patient.AddDetails(patient);

    MedicalRecord record = new MedicalRecord(); 
    record.RecordId = Convert.ToInt32(Console.ReadLine());
    record.TreatmentCost = Convert.ToInt32(Console.ReadLine());
    record.AddDetails(record);
    }




Patient patient1 = new Patient();
patient1.Display();
