﻿using System;
namespace bai1
{
    class BasicExercises47
    {
        public static void Main()
        {
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", nums));
            var sum = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
