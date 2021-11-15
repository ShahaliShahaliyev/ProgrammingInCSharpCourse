using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class PhotoBook
    {
        public int NumPages;
        public PhotoBook()
         {
            NumPages = 16;
         }
        public PhotoBook(int NumPages)
        {
            this.NumPages = NumPages;
        }
        public int GetNumPages()
        {
            return this.NumPages;
        }
}
}
