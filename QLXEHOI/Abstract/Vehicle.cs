using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXEHOI.Abstract
{
    abstract class Vehicle
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Vehicle(int Id, string Name, string Brand, double Price, int Quantity)
        {
            this.ID = Id;
            this.Name = Name;
            this.Brand = Brand;
            this.Price = Price;
            this.Quantity = Quantity;
        }
        public void Update(int id, string name, string brand, double price, int quantity)
        {
            ID = id; 
            Name = name;
            Brand = brand;
            Price = price;
            Quantity = quantity;
        }

        public abstract void Display();
    }
}
