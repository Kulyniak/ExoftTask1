﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExoftTask1.Warriors;


namespace ExoftTask1
{
    public  class HealthManipulator : ISuperPower
    {
        public void AddSuperPower(BaseWarrior warior, int power)
        {
            warior.Health += power;
        }
    }

}
