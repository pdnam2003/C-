using QUANLYHOCSINH.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYHOCSINH.Entity
{
    internal class Student : Character
    {

        public Student(int Id, string name, DateTime age, double score) : base(Id, name, age, score){}
         public int  AgeNow( DateTime age )
        {
            int ageNow = DateTime.Now.Year - age.Year;
            if (DateTime.Now<this.Age.AddYears(ageNow)) {
                ageNow--;            
            }
            return ageNow;

        }
        public override void Display()
        {
            Console.WriteLine($"id : {Id}, name : {Name}, tuoi : {AgeNow}, diem :{Score}  ");
        }
    }
}
