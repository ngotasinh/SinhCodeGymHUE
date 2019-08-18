using System;
namespace bai1
{
    class BasicExercises43
    {
        static void Main()
        {
            Console.Write("Input the string ");
            string str = Console.ReadLine();
            Console.WriteLine(str.Substring(0, 3).Equals("www"));
            Console.ReadKey();
        }
    }
}
