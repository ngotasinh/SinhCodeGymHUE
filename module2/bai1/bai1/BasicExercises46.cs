using System;
namespace bai1
{
    class BasicExercises46
    {
        static void Main()
        {
            int[] inputArray = { 25, 5, 3, 4, 5, 6, 7, 5, 7, 5, 9 };
            Console.Write("Input a number to check:");
            int number2Chk = Convert.ToInt32(Console.ReadLine());

            if (inputArray[0] == number2Chk || inputArray[inputArray.Length - 1] == number2Chk)
                Console.Write("True");
            else
                Console.Write("False");
        }
    }
}
