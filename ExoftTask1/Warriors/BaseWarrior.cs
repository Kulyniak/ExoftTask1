using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoftTask1.Warriors
{
    public abstract class BaseWarrior
    {
        public int Health = 100;
       public int Armor { get; set; }
        public int Punch { get; set; }

        public virtual void AddSuperPower(ISuperPower super, int power) { }
    }
}
