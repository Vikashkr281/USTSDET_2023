using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Doctor : IDoctor, IApoinment
    {
        public void AddDoctor()
        {
            
        }

        public void BookApoinment(int Id, string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteAppoinment(string name)
        {
            throw new NotImplementedException();
        }

        public void ModifyDoctor()
        {
            throw new NotImplementedException();
        }
    }
}
