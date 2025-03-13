using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class Validation
    {
        public string valid(string input)
        {
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("nhap lai !!!");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
