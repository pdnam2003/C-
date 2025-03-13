using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ControllerClass1
    {
        public void controlbook()
        {
            string a = Console.ReadLine();
            int choice = int.Parse(a);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("them danh sach moi");
                    break;
                case 2:
                    Console.WriteLine("hien thi  danh sach ");

                    break;
                case 3:
                    Console.WriteLine("timm danh sach theo tieu de");
                    break;
                case 4:
                    Console.WriteLine("loc danh sach theo tac gia ");
                    break;
                default:
                    Console.WriteLine("nhan bat ki de exit");
                    return;


            }



        }
        


    }
}
