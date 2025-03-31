using QUANLYHOCSINH.Service;

namespace QUANLYHOCSINH
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            StudentService studentService = new StudentService();

            while (true)
            {
                Console.WriteLine("Menu quan ly hoc sinh ");
                Console.WriteLine("1. Them hoc sinh");
                Console.WriteLine("2. Hien thi tat ca hoc sinh dang co");
                Console.WriteLine("3. Cap nhap hoc sinh dang co");
                Console.WriteLine("4. Xoa hoc sinh theo id");
                Console.WriteLine("5. Thoat");
                Console.WriteLine("Nhap lua chon cua ban: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        studentService.Add();
                        break;

                    case "2":
                      
                        studentService.DisplayAll();
                        break;

                    case "3": 
                        studentService.Update();
                        break;

                    case "4":
                       
                        Console.Write("Nhap ID hoc sinh can xoa: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                        {
                            studentService.Delete(id);
                        }
                        else
                        {
                            Console.WriteLine("ID khong hop le!");
                        }
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
                      
             }
        }
    }
}