namespace b5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            while (true)
            {
                Console.WriteLine("1 them sach");
                Console.WriteLine("2 liet ke sach");
                Console.WriteLine("3 tim kiem theo ten");
                Console.WriteLine("4 thoat");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        addBook();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        
                        return;

                    default:
                        Console.WriteLine("nhap lai so khac ");
                        break;

                }
            }
        }  
        public static void addBook()
        {
            
            Console.WriteLine("nhap id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap title");
            string title = Console.ReadLine();
            Console.WriteLine("nhap tg");
            string author = Console.ReadLine();
            //Book books = new Book(id,title,author);
            List<Book> books = new List<Book>(  
            );

            books.Add(new Book(id, title, author));
            foreach(var item in books)
            {
                item.display();
            }

        }
     








    }
}