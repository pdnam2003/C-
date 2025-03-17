using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aoe2
{
   public interface Ihero
    {
        
        void AttackWin(Ihero general);
        void AttackLoss(Ihero general);
    }
}
