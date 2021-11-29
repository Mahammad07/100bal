using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 11;
            int count = 0;

            if (number <= 0)
            {
                Console.WriteLine("eded 0 dan boyuk olmalidir");
            }
            else if (number == 1)
            {
                Console.WriteLine("1 ne sade nede murekkeb ededlere aiddir");
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
            }
            if (count > 2)
            {
                Console.WriteLine("murekkebv");
            }
            else 
            {
                Console.WriteLine("sade");
            }




        }
    }
}
