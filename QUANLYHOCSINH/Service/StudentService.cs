using QUANLYHOCSINH.Entity;
using QUANLYHOCSINH.Interface;
using QUANLYHOCSINH.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QUANLYHOCSINH.Service
{
    internal class StudentService : IStudent<Student>
    {
        private readonly List<Student> _students = new List<Student>();
        private static int autoIncrementId = 1;

        public IEnumerable<Student> GetAll()
        {
            return _students.AsEnumerable();
        }

        public Student GetById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public  void Add()
        {
            Console.WriteLine("Nhap Name: ");
            string name = Validate.ValiString("Nhap ten hoc sinh", "Sai dinh dang du lieu");

            Console.Write("Nhap age: ");
            DateTime age = Validate.ValiDateTime("Nhap ngay sinh hoc sinh  dinh dang mm/dd/yy", "Sai dinh dang ngay thang");

            Console.Write("Nhap tong diem: ");
            double score = Validate.ValiDouble("Nhap tong diem", "Sai du lieu ve diem");

         
            var student = new Student(
                Id: autoIncrementId++,
                name: name,
                age: age,
                score: score
            );

            _students.Add(student);
            Console.WriteLine("Them thanh cong");
        }

        public void Update()
        {
            Console.Write("Nhap ID hoc sinh can cap nhat: ");
            int id = int.Parse(Console.ReadLine());

            var student = GetById(id);
            if (student == null)
            {
                Console.WriteLine("Khong tim thay hoc sinh");
                return;
            }

            Console.WriteLine("Nhap thong tin moi:");
            Console.Write("Ten: ");
            student.Name = Validate.ValiString("Nhap ten hoc sinh", "Sai dinh dang du lieu");

            Console.Write("Tuoi: ");
            student.Age = Validate.ValiDateTime("Nhap age hoc sinh", "Sai dinh dang ngay thang");

            Console.Write("Diem: ");
            student.Score = Validate.ValiDouble("Nhap tong diem", "Sai du lieu ve diem");

            Console.WriteLine("Cap nhat thanh cong");
        }

        public void Delete(int id)
        {
            var student = GetById(id);
            if (student != null)
            {
                _students.Remove(student);
                Console.WriteLine("Xoa thanh cong");
            }
            else
            {
                Console.WriteLine("Khong tim thay hoc sinh");
            }
        }

        public void DisplayAll()
        {
            foreach (var student in _students)
            {
                Console.WriteLine($"ID: {student.Id}, Ten: {student.Name}, Tuoi: {student.Age.ToShortDateString()}, Diem: {student.Score}");
            }
        }
    }
}