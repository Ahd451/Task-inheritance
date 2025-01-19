using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_inheritance.Interface_Task
{
    internal class OnlineOrderProcessor : IOrderProcessor
    {
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * .1M; 
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Process Order OnLine");
        }
    }
}
