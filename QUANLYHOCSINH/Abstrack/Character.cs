using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYHOCSINH.Abstrack
{
    internal abstract class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Age { get; set; }
        public double Score { get; set; }
        public Character( int Id,string name, DateTime age, double score) {
            this.Id = Id;
            this.Name = name;
            this.Age = age;
            this.Score = score;
        }
        public abstract void Display();
    }
}
