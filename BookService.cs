using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class BookService
    {
        private List<Book> books;
        public BookService(List<Book> books)
        {
            this.books = books;
        }
        public void AddNewBook(Book book)
        {
            books.Add(book);

        }
        public List<Book> displayBook()
        {
            return books;
        }
        public Book Search(String keyword)
        {
            return books.Where(b => b.GetTitle().ToLower().Contains(keyword.ToLower())).FirstOrDefault();
        }
        public List<Book> FilterByAuthor(String keyword)
        {
            return books.Where(b => b.GetAuthor().ToLower().Contains(keyword.ToLower())).ToList();
        }
        public int getLengindex()
        {
            return books.Count > 0 ? books.Max(b => b.GetId()) + 1 :1;
        }

    }
}
