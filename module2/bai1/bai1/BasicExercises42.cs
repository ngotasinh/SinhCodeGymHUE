using System;
namespace bai1
{
    class BasicExercises42
    {
        static void Main()
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();
            if(str.Length < 4)
            {
                Console.WriteLine(str.ToUpper());
            }
            else
            {
                Console.WriteLine(str.Substring(0, 4).ToUpper() + str.Substring(4, str.Length - 4));
            }
            Console.ReadKey();
        }
    }
}
