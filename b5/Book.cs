using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b5
{
    internal class Book
    {
        protected int id { get; set; }
        protected string Title { get; set; }
        protected string Author { get; set; }

        public  Book(int id, string title, string author)
        {
            this.id = id;
            this.Title = title;
            this.Author = author;
        }

        public void display()
        {
            Console.WriteLine($"Id : {id},Title:{Title},Author:{Author} ");
        }

    }
}
