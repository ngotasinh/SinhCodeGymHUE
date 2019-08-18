using System;
namespace bai1
{
    class BasicExercises50
    {
        static void Main()
        {
            int[] array = { 1, 2, 3 };
            Console.WriteLine("array: [{0}]", string.Join(",", array));
            int temp = array[0];
            for(int i=0; i<array.Length -1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;
            Console.WriteLine("After rotating array becomes: [{0}]", string.Join(",", array));
            Console.ReadKey();
        }
    }
}
