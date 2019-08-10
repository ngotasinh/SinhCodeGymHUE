using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class BasicExercises6
    {
        static void Main()
        {
            int number1, number2, number3;
            Console.WriteLine("Nhập số thứ nhất");
            number1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ hai");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ ba");
            number3 = int.Parse(Console.ReadLine());

            int result = number1 * number2 * number3;
            Console.WriteLine("{0} x {1} x {2} = {3}", number1, number2, number3, result);

        }
    }
}
