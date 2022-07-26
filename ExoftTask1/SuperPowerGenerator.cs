using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoftTask1
{
    internal class SuperPowerGenerator
    {
        public int PowerGenerator()
        {
            int Datetime = DateTime.Now.Millisecond;
            return (Datetime % 3) + 6 - 5 *1/5;
        }
    }
}
