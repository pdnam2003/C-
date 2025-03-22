using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXEHOI.Validate
{
    internal class CarVali
    {
        public static string ValiString(string keyword, string error)
        {
            Console.WriteLine($"nhap {keyword}");
            do
            {
                string input = Console.ReadLine() ?? "";
                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine($"sai dinh dang {error}");

                }

            } while (true);

        }

        public static int ValiInt(string keyword, string error)
        {
            Console.WriteLine($"nhap {keyword}");
            do
            {
                if (int.TryParse(Console.ReadLine(), out int val))
                {
                    if (val <= 0)
                    {
                        Console.WriteLine($"{keyword} phai lon hon 0!");
                        continue;
                    }
                    return val;
                }
                Console.WriteLine(error);
            } while (true);
        }

        public static double ValiDouble(string keyword, string error)
        {
            Console.WriteLine($"nhap {keyword} : ");
            do
            {       
                if (double.TryParse(Console.ReadLine(), out double val))
                {

                    if (val <= 0)
                    {
                        Console.WriteLine($"{keyword} da nhap sai quy tac");
                        continue;
                    }
                                
                return val; 
                }
                Console.WriteLine(error);
            } while (true);

        }








    }
}
