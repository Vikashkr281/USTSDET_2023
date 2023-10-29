using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_29_oct
{
    internal interface IOrderable
    {
        public void PlaceOrder();
        public void ProcessPayment();
        public void DeliverProduct();
    }
}
