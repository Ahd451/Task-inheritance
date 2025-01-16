using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_inheritance
{
    class BorrowedBook : LibraryItems
    {
        #region Feilds
        Books book;
        string? BorrowerName;
        DateTime BorrowedDate;
        #endregion

        #region Constructor
        public BorrowedBook(Books book = default, string? BorrowerName = "", DateTime date = default, int id = 0, bool avialable = true) : base(avialable, id)
        {
            this.book = book;
            this.BorrowerName = BorrowerName;
            BorrowedDate = date;
        }

        #endregion

        #region Methods
        public int CalcualteBorrowDuration()
        {
            return (DateTime.Now - BorrowedDate).Days;
        }
        #endregion

    }
}
