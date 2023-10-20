using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal abstract  class Vechicle
    {
        public int VechicleNumber {  get; set; }
        public string? Brand {  get; set; }
        public string? Model { get; set; }
        public string? Type {  get; set; }

        public abstract string? SetTypeForVechicle();

        public void Display()
        {
            Console.WriteLine("Vechicle  Number = {0} \t Vechicle Brand = {1} Vechicle Model {2}", )
        }

    }
}
