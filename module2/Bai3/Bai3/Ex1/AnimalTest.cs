using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Ex1
{
    public class AnimalTest
    {
        public static void Main()
        {
            Console.WriteLine("************Animal***************");
            var myAnimal = new Animal();
            Console.WriteLine("Animal: {0} ", myAnimal.Move());

            Console.WriteLine("************Cat***************");
            var Tom = new Cat();
            Console.WriteLine (Tom.Move());
            Console.WriteLine(Tom.Drink());
            Console.WriteLine(Tom.Eat());
            
        }
    }
}
