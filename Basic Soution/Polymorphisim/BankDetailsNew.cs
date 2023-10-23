using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisim
{
    internal class BankDetailsNew : BankDetails
    {
        public BankDetailsNew(int custId, long accno, string? name, string? status) : base(custId, accno, name, status)
        {


        }
        public  void WelcomeMessage()
        {
            Console.WriteLine("Welcome To New World");
        }
    }
}
