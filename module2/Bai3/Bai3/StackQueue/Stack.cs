using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.StackQueue
{
    public class Stack
    {
        public static void Main()
        {
            Stack<int> Money = new Stack<int>();
            Money.Push(500);
            Money.Push(200);
            foreach (var item in Money)
            {
                Console.WriteLine("Tien : {0}", item);
            }
            Console.WriteLine("Xem giá trị trên cùng: {0}", Money.Peek());


            // Queue
            Queue<string> Task = new Queue<string>();
            Task.Enqueue("Build project structor");
            Task.Enqueue("Task Separate");
            Task.Enqueue("Assign task");
            foreach (var item in Task)
            {
                Console.WriteLine("item: {0}:  ", item);
            }
            Console.WriteLine("item on top : {0}", Task.Peek());
        }
        
    }
}
