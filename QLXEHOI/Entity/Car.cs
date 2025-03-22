using QLXEHOI.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXEHOI.Entity
{
    internal class Car : Vehicle
    {
        public Car(int Id, string Name, string Brand, double Price, int Quantity) 
            : base(Id, Name, Brand, Price, Quantity){ }

        public override void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Brand: {Brand}, Price: {Price}, Quantity: {Quantity}");
        }

    
    }
}
