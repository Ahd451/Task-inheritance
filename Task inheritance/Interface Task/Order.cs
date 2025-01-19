using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_inheritance.Interface_Task
{
    internal class Order
    {
        #region Feilds
        int OrderId;
        string CustomerName;
        decimal OrderAmount;
        IOrderProcessor OrderProcessor;
        #endregion

        #region Constructor
        public Order(int orderid, string customername, decimal orderamount, IOrderProcessor orderprocessor)
        {
            this.OrderId = orderid;
            this.CustomerName = customername;
            this.OrderAmount = orderamount;
            this.OrderProcessor = orderprocessor;
        }
        #endregion
        
        #region Methods
        public void Processor()
        {
            OrderProcessor?.ProcessOrder();
        }

        public void ShowDiscount ()
        {
            Console.WriteLine( $"Order {OrderId} Processed for {CustomerName}. Final Amount after discount: ${ (OrderAmount - OrderProcessor.CalculateDiscount(OrderAmount)):c}" ) ; 
        }
        #endregion
    }
}
