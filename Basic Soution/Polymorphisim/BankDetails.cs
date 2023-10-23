using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Polymorphisim
{
    internal class BankDetails
    {
       /* public BankDetails() 
        {
            CustId = 0;
            Accno = 0;
            Name = "o";
            Status = "0";

        }
        public BankDetails(int custId, long accno, string? name)
        {
            CustId = custId;
            Accno = accno;
            Name = name;
        }*/

        public BankDetails(int custId, long accno, string? name, string? status)
        {
            CustId = custId;
            Accno = accno;
            Name = name;
            Status = status;
        }

        public int CustId {  get; set; }
        public long Accno { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }

        public void GetAccDetails(int custid)
        {
            if(CustId == custid) 
            {
                Console.WriteLine("Accno : {0} \t Name : {1} \t Status : {2}", CustId, Name, Status);

            }
            else
            {
                Console.WriteLine("Account NUmber not exit");
            }
        }
        public void GetAccDetails(long  accountNumber)
        {
            if (Accno == accountNumber)
            {
                Console.WriteLine("Accno : {0} \t Name : {1} \t Status : {2}", CustId, Name, Status);

            }
            else
            {
                Console.WriteLine("Account NUmber not exit");
            }
        }

        public void GetAccDetails(string? name)
        {
            if (Name==name)
            {
                Console.WriteLine("Accno : {0} \t Name : {1} \t Status : {2}", CustId, Name, Status);

            }
            else
            {
                Console.WriteLine("Account NUmber not exit");
            }
        }
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome");
        }

    }
}
