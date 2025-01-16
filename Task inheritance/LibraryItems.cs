using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_inheritance
{
    internal class LibraryItems
    {

        #region Feilds
        bool IsAvailable;
        #endregion
        #region Properties
        public int ItemID { get; set; }
        #endregion

        #region Methods
        public void CheckOut()
        {
            IsAvailable = false;
        }
        public void ReturnItem()
        {
            IsAvailable = true;
        }
        #endregion

        #region Constructor

        public LibraryItems(bool IsAvailable = true, int Id = 0)
        {
            this.IsAvailable = IsAvailable;
            ItemID = Id;
        }

        #endregion

    }
}
