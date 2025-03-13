using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int price { get; set; }
        public int year { get; set; }
        public Type type { get; set; }
    }
    enum Type
    {
        Horrified, detective, delicious
    }
    public void serviceBook() { 
    }




}
