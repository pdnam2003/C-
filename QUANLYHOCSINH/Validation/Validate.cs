using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYHOCSINH.Validation
{
    internal class Validate
    {
        public static string ValiString(string keyword, string error)
        {
                    while (true)
            {
                string input = Console.ReadLine() ?? "";
                if (string.IsNullOrEmpty(input)) {
                    Console.WriteLine(error);
                }
                else
                {
                    return input;
                }
            }
        }
        public static int ValiInt(string keyword, string error)
        {
         
            while (true)
            {

                if (int.TryParse(Console.ReadLine(), out int val)){
                    if (val <= 0)
                    {
                        Console.WriteLine(error);
                        continue;
                    }
                    return val;
                }
                Console.WriteLine(error);
            }
        }

        public static double ValiDouble(string keyword, string error)
        {
           
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double val)){
                    if (val <= 0)
                    {
                        Console.WriteLine(error);
                        continue;
                    }
                    else
                    {
                        return val;
                    }
                }
                Console.WriteLine(error);
            }
        } 

        public static DateTime ValiDateTime(string keywords, string error)
        {
         
            while (true)
            {
                string input = Console.ReadLine() ?? "";
                if(!DateTime.TryParse(input, out DateTime result)){
                    Console.WriteLine(error);
                }
                else
                {
                    return result;
                }
            }
        }

    }

}

