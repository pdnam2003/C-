using QUANLYHOCSINH.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYHOCSINH.Data
{
    internal class SampleData
    {
        public static List<Student> GetData() 
        {
            return new List<Student>
            {
                new Student(1,"Nam",new DateTime(2003,11,18),8.6),
                new Student(2, "Anna", new DateTime(2004, 5, 20), 9.1),
                new Student(3, "Binh", new DateTime(2005, 12, 15), 7.4),
                new Student(4, "Cuong", new DateTime(2003, 2, 28), 9.5),
                new Student(5, "Dinh", new DateTime(2004, 8, 12), 8.0)
            };
        }
    }
}
