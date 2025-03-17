using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aoe2.Hero
{
   
        class CungThu : Ihero
        {
            string name { get; }
            string position { get; }
            public CungThu(string name)
            {
                this.name = name;
            this.position = "cung thu ";
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
                Console.WriteLine($"{name} ({position}) da giup ban chien thang)");
            }
            public void AttackLoss(Ihero general)
            {
                Console.WriteLine($"{name} ({position}) cua ban that bai ");
            }
        }
    
}
