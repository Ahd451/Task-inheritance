using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_inheritance.Interface_Task
{
    internal class InStoreOrderProcessor : IOrderProcessor
    {
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * .05M;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Processes orders placed in physical stores");
        }
    }
}
