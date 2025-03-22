using QLXEHOI.Data;
using QLXEHOI.Entity;
using QLXEHOI.Interface;
using QLXEHOI.Validate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXEHOI.Manage
{
    internal class CarManage : ICar
    {
        private List<Car> cars = new List<Car>();
        public CarManage() {
            cars = Simple.GetData();
        }
        public void Add()
        {
            Console.Write("Enter ID: ");
            int Id = CarVali.ValiInt("id","Id phai lon hon khong") ;

            Console.Write("Enter Name: ");
            string Name = CarVali.ValiString("name", "Name");

            Console.Write("Enter Brand: ");
            string Brand = CarVali.ValiString("Brand", "Brand");

            Console.Write("Enter Price: ");
            double Price = CarVali.ValiDouble("price", "khong dung dinh dang price");

            Console.Write("Enter Quantity: ");
            int Quantity = CarVali.ValiInt("Quantity", "Quantity phai lon hon khong");

             cars.Add(new Car(Id, Name, Brand, Price, Quantity));
            Console.WriteLine("them thanh cong");
          
        }

        public void DeleteById()
        {
            Console.WriteLine("nhap id :");
            int id = int.Parse(Console.ReadLine());
           var car = cars.FirstOrDefault(c=> c.ID == id);
            if(car != null)
            {
                cars.Remove(car);
                Console.WriteLine("xoa thanh cong");
            }else
            {
                Console.WriteLine($"khong tim thay xe co id {id}");
            }
        }

        public void Display()
        {
            if (cars.Count <= 0)
            {
                Console.WriteLine("khong co xe de hien thi");
            }
            else
            {
                foreach (Car car in cars)
                {
                    car.Display();
                }
            }
        }

        public void EditById()
        {
            Console.WriteLine("nhap id :");
            int id = int.Parse(Console.ReadLine()) ;
            var car = cars.FirstOrDefault(c=> c.ID==id);
            car.Display();
            if (car != null)
            {
                Console.Write("Enter ID: ");
                int Id = CarVali.ValiInt("id", "Id phai lon hon khong");

                Console.Write("Enter Name: ");
                string Name = CarVali.ValiString("name", "Name");

                Console.Write("Enter Brand: ");
                string Brand = CarVali.ValiString("Brand", "Brand");

                Console.Write("Enter Price: ");
                double Price = CarVali.ValiDouble("price", "khong dung dinh dang price");

                Console.Write("Enter Quantity: ");
                int Quantity = CarVali.ValiInt("Quantity", "Quantity phai lon hon khong");

                car.Update(Id, Name, Brand, Price,Quantity);              
                car.Display();
            }
        }

        public void SearchByName()
        {
            throw new NotImplementedException();
        }

        public void SortByPrice()
        {
            throw new NotImplementedException();
        }

    }
}
