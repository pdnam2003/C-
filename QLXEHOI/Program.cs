using QLXEHOI.Manage;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManage carManage = new CarManage();
        while (true)
        {
            Console.WriteLine("MENU QUAN LY XE HOI ");
            Console.WriteLine("1 them xe moi");
            Console.WriteLine("2 hien thi cac xe dang co");
            Console.WriteLine("3 tim kiem xe theo ten");
            Console.WriteLine("4 xoa xe theo id");
            Console.WriteLine("5 sap xep theo gia tang dan");
            Console.WriteLine("6 chinh sua theo id");
            Console.WriteLine("7 thoat");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    carManage.Add();
                    break;
                case "2":
                    carManage.Display();
                    break;
                case "3":
                    carManage.SearchByName();
                    break;
                case "4":
                    carManage.DeleteById();
                    break;
                case "5":
                    carManage.SortByPrice();
                    break;
                case "6":
                    carManage.EditById();
                    break;
                case "7":
                    Console.WriteLine("dang thoat...");
                    return;
                 default:
                    Console.WriteLine("hay nhap lai gia tri");
                    break;


            }




        }
    }
}