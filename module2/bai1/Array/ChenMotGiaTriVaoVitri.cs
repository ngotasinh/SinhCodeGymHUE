using System;
using System.Collections.Generic;
using System.Text;

namespace BTmang
{
    public class ChenMotGiaTriVaoVitri
    {
        public static void Main()
        {
            Console.Write("\n\nInsert New value in the unsorted array : \n");
            Console.Write("-----------------------------------------\n");
            Console.Write("Input the size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[size +1];
           
            Console.Write("Input {0} elements in the array in ascending order:\n", size);
            for (int i = 0; i < size; i++)
            {
                Console.Write("element - {0} : ", i);
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Input the value to be inserted : ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Position, where the value to be inserted :");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.Write("The current list of the array :\n");
            for (int i = 0; i < size; i++)
                Console.Write("{0} ", Array[i]);
            
            for (int i = size; i >= index; i--)
                Array[i] = Array[i - 1];
           
            Array[index] = value;


            Console.Write("\n\nAfter Insert the element the new list is :\n");
            for (int i = 0; i <= size; i++)
            Console.Write("{0} ", Array[i]);
            Console.Write("\n\n");
        }
    }
}

