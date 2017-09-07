using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    [Serializable]
    public class Book
    {
        public int bookid { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int status { get; set; }

        public Book (int bookid, string title, string author, int status=0)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.status = status;
        }
    }
}
