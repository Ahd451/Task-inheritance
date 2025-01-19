
using Task_inheritance.Interface_Task;

namespace Task_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance Task 
            //Books book = new Books("Programming", "Ahmed Ramzy", "1254");
            //BorrowedBook borrowedBook = new BorrowedBook(book, "Ahd Ahmed", new DateTime(2025, 1, 1), 11, true);
            //borrowedBook.CheckOut();
            //borrowedBook.ReturnItem();
            //Console.WriteLine(borrowedBook.CalcualteBorrowDuration()); 
            #endregion

            #region Interface Task 

            OnlineOrderProcessor onlineOrderProcessor = new OnlineOrderProcessor();
            Order order= new Order(1,"Ahd", 1500, onlineOrderProcessor) ;

            order.Processor();
            order.ShowDiscount();

            Console.WriteLine("\n=========================================================\n");
            order = new Order(2, "Ahmed", 2000, new InStoreOrderProcessor()); 
            order.Processor();
            order.ShowDiscount();
            
            #endregion

        }
    }
}
