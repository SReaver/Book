using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    [Serializable]
    public struct Book
    {
        public int bookid { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public bool status { get; set; }

        public Book (int bookid=0, string title="Книга без названия", string author="Автор неизвестен", bool status=false)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.status = status;
        }
    }
}
