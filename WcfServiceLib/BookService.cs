using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCF.Common;
using SCF.Model;

namespace WcfServiceLib
{
    public class BookService : IBookService
    {
        public string GetBook(string Id)
        {
            int bookId = Convert.ToInt32(Id);
            Books book = SetBook(bookId);
            string xml = XMLHelper.ToXML<Books>(book);
            return xml;
        }

        public Books SetBook(int Id)
        {

            Books book = new Books();

            book.BookID = Id;

            book.AuthorID = 1;

            book.Category = "IBM";

            book.Price = 9.99M;

            book.Numberofcopies = 22;

            book.Name = "DB 2";

            book.PublishDate = new DateTime(1986, 2, 23);

            return book;

        }
    }
}
