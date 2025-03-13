using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class BookController
    {
        private BookService bookServices;
        Validation validations = new Validation();
        private static int autoId = 1;

        public BookController(BookService bookServices)
        {
            this.bookServices = bookServices;
            autoId = bookServices.getLengindex();
        }
        public void AddNewBook()
        {
            int id = autoId++;

            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            title = validations.valid(title);

            Console.WriteLine("Enter author: ");
            string author = Console.ReadLine();
            author = validations.valid(author);

            Book book = new Book(id, title, author);
            bookServices.AddNewBook(book);
            Console.WriteLine("complete add book!!");
        }
        public void displayBook()
        {
            List<Book> all = bookServices.displayBook();
            if(all.Count == 0)
            {
                Console.WriteLine("not found");

            }
            else
            {
                foreach(var item in all)
                {
                    item.DisplayInfo();
                }
            }
        }
        public Book Search()
        {
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Book all = bookServices.Search(title);
            if(all == null)
            {
                Console.WriteLine("Not found book: " + title);
                return null;
            }
            else
            {
                Console.WriteLine("Result search: ");
                all.DisplayInfo();
            }
            return all;
        }
        public List<Book> FilterByAuthor()
        {
            Console.WriteLine("Enter author: ");
            string keyword = Console.ReadLine();
            List<Book> all = bookServices.FilterByAuthor(keyword);
            if(all.Count == 0)
            {
                Console.WriteLine("no info");

            }
            else
            {
                Console.WriteLine("ket qua : ");
                foreach (var book in all)
                {
                    book.DisplayInfo();
                }
                        }
            return all;
        }




    }
}
