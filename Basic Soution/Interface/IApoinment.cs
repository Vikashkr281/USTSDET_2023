using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IApoinment
    {
        void BookApoinment(int Id,string name);
        void DeleteAppoinment(string name);
        
    }
}
