using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXEHOI.Interface
{
    internal interface ICar
    {
        void Add();
        void Display();
        void SearchByName();
        void DeleteById();
        void SortByPrice();
        void EditById();

    }
}
