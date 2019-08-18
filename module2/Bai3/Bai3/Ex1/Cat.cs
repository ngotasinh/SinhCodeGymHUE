using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Ex1
{
    public class Cat : Animal, ICanEat, ICanDrink
    {
        public string Drink()
        {
            return "cats drink Tiger Beer";
        }

        public string Eat()
        {
            return "cats eats  food tiger";
        }

        public override string Move()
        {
            return "cats move by 4 legs";
        }
    }
}
