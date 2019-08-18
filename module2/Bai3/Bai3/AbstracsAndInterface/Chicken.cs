using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.AbstracsAndInterface
{
    class Chicken : Animal, IEdible
    {
        public override string MakeSound()
        {
            return "chip chip";
        }
        public string howtoEat()
        {
            return "Checken eats rice";
        }
    }
}
