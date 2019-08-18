using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Ex1
{
    public class Animal : ICanMove
    {
        public virtual string Move()
        {
            return "Moving";
        }
    }
}
