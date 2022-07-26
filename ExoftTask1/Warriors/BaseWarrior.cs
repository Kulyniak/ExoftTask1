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

        public bool isAlive()
        {
            if (Health > 0)
            {
                return true;
            }
            else { return false; }
        }

        public void Defence(int enemy_damage)
        {
            if (Armor > 0)
            {
                if (enemy_damage > 1)
                {
                    if ((enemy_damage / 2) > Armor)
                    
                    {
                        Health -= enemy_damage - Armor;
                        Armor = 0;
                    }
                    Armor -= enemy_damage / 2;
                    Health -= enemy_damage - (enemy_damage / 2); 
                }
                else if (enemy_damage == 1)
                {
                    Armor -= enemy_damage;
                }
            }
            Console.WriteLine($"Armor left: {Armor}");
        }

        public int Damage()
        {
            if (Armor > 0)
            {
                return Punch;
            }
            else
            {
                if (Punch > 1)
                {
                    Punch--;
                }
                return Punch;
            }
        }

        public virtual void AddSuperPower(ISuperPower super, int power) { }
    }
}
