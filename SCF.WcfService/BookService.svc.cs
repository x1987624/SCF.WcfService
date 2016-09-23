using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using SCF.Model;
using SCF.Common;
using System.Data.Entity;

namespace SCF.WcfService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“BookService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 BookService.svc 或 BookService.svc.cs，然后开始调试。
    public class BookService : IBookService
    {
        BookEntities db = new BookEntities();
        public string AddBook(string mbook)
        {
            try

            {
                Books book = XMLHelper.DeSerializer<Books>(mbook);
                db.Books.Add(book);
                db.SaveChanges();
            }

            catch (Exception ex)
            {
                return ex.Message;

            }

            return "true";
        }

        public string EditBook(string mbook)
        {
            try
            {
                Books book = XMLHelper.DeSerializer<Books>(mbook);
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "true";
        }

        public string GetBook(string Id)
        {
            int bookId = Convert.ToInt32(Id);
            Books book = db.Books.Find(bookId);
            string xml = XMLHelper.ToXML<Books>(book);
            return xml;
        }

        public string Search(string Category, string searchString)
        {

            return XMLHelper.ToXML<List<Books>>(new List<Books> { SetBook(1) });  //调试

            var cateLst = new List<string>();
            var cateQry = from d in db.Books
                          orderby d.Category
                          select d.Category;
            cateLst.AddRange(cateQry.Distinct());

            var books = from m in db.Books
                        select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(s => s.Name.Contains(searchString));
            }

            List<Books> list = null;
            if (string.IsNullOrEmpty(Category))

            {
                list = books.ToList<Books>();
            }

            else

            {
                list = books.Where(x => x.Category == Category).ToList<Books>();

            }
            return XMLHelper.ToXML<List<Books>>(list);
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
