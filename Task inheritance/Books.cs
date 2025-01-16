using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_inheritance
{
    struct Books
    {
        #region Properties
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }

        #endregion
        #region Constructors
        public Books(string? title = "", string? author = "", string? ISBN = "")
        {
            Title = title;
            Author = author;
            this.ISBN = ISBN;
        }

        #endregion
    }
}
