using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;


namespace Fibonacci
{
    public static class somenumbers
    {
        public static IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 3;
            yield return 5;
            yield return 7;
            yield return 9;
        }

        public static void LogNumbers()
        {
            var numbers = GetNumbers();
            string numbersAll = "";
            foreach (int num in numbers)
            {
                numbersAll += " " + num.ToString();
            }
            Console.WriteLine(numbersAll.Trim());
            Console.WriteLine("Average: " + numbers.Average());
        }

        public static IEnumerable<int> Fibonacci(int length)
        {
            int a = 0, b = 1;
            for (int i = 0; i < length; i++)
            {
                yield return a;
                int c = a + b;
                a = b;
                b = c;
            } 
        }

        public static void LogFibonacci()
        {
            foreach (int i in Fibonacci(10))
            {
                Console.Write(i + " ");
            }
        }
    }
}