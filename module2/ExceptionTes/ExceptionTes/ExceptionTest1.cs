using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExceptionTes
{
    public class ExceptionTest1
    {
        public static void Main()
        {
            FileStream file = new FileStream($"D:\\SinhCodeGymHUE\\module2\\ExceptionTes\\" +
                $"log{DateTime.Now.ToString("dd-MM-yyyy")}.txt",FileMode.Append);
            try
            {
                Console.Write("input a= ");
                var a = int.Parse(Console.ReadLine());
                Console.Write("input b= ");
                var b = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}/{1} = {2}", a, b, a/b);
            }
            catch (DivideByZeroException dze)
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine($"[Error] : {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss:tt")} : {dze.Message}");
                }
                Console.Write($"[Error]" + dze.Message);
            }
           /* catch (Exception ex)
            {

                Console.Write(ex.Message); 
            }*/
            finally
            {
                Console.WriteLine("Go to finally");
            }
            file.Close();
            FileStream file1 = new FileStream($"D:\\SinhCodeGymHUE\\module2\\ExceptionTes\\" +
                $"log{DateTime.Now.ToString("dd-MM-yyyy")}.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(file1))
            {
                var content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
        }
    }
}
