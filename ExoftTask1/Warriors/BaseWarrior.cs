using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoftTask1.Warriors
{
    internal abstract class BaseWarrior
    {
        int Health = 100;
        int Armor { get; set; }
        int Punch { get; set; }
    }
}
