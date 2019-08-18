using System;
namespace bai1
{
    class BasicExercises44
    {
        static void Main()
        {
            Console.WriteLine("input the String");
            string str = Console.ReadLine();
            string newstr = string.Empty;
            for(int i = 0; i < str.Length; i++)
            {
                if(i % 2 ==0)
                {
                    newstr += str[i];
                }
            }
            Console.WriteLine(newstr);
        }
    }
}
