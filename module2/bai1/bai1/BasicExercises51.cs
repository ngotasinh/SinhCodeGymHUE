using System;
namespace bai1
{
    class BasicExercises51
    {
        public static void Main()
        {
            int[] nums = { 1, 2, 5, 7, 8 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", nums));
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }
            Console.WriteLine("Highest value between first and last values of the said array: {0}", max);
        }
    }
}
