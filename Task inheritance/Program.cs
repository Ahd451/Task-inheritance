namespace Task_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books book = new Books("Programming" , "Ahmed Ramzy" , "1254");
            BorrowedBook borrowedBook = new BorrowedBook(book, "Ahd Ahmed", new DateTime(2025, 1, 1), 11, true);
            borrowedBook.CheckOut();
            borrowedBook.ReturnItem();
            Console.WriteLine(borrowedBook.CalcualteBorrowDuration());

        }
    }
}
