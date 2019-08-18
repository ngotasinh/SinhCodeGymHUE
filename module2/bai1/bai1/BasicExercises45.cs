using System;
namespace bai1
{
    class BasicExercises45
    {
        static void Main()
        {
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.WriteLine("Enter the number which you want info about: ");
            int num = int.Parse(Console.ReadLine());
            int ctr = 0;
            for (int i = 0; i<nums.Length; i++)
            {
                if(nums[i] == num) ctr++;
            }
            Console.WriteLine("The number {0} occured {1} times in the array.", num, ctr);

            Console.ReadKey();
        }
    }
}
