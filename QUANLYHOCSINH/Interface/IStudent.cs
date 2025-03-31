using QUANLYHOCSINH.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYHOCSINH.Interface
{
    public interface IStudent<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add();
        void Update();
        void Delete(int id);
    }
}
