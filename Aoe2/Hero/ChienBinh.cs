using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aoe2.Hero
{
    class ChienBinh : Ihero
    {
        public string name { get; }
        public string position { get; }

        public ChienBinh(string name)
        {
            this.name = name;
            this.position = "Chiến Binh";
        }
        public string GetName()
        {
            return name;
        }
        public string GetPosition()
        {
            return position;
        }
        public void AttackWin(Ihero general)
        {
            Console.WriteLine($"{name} ({position}) da giup ban chien thang )");
        }
        public void AttackLoss(Ihero general)
        {
            Console.WriteLine($"{name} ({position}) cua ban that bai  )");
        }
    }
}
