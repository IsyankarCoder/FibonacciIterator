using System;

namespace Fibonacci {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
            somenumbers.LogNumbers ();
            somenumbers.LogFibonacci ();
            monthsoftheyear my = new monthsoftheyear ();
            my.LogMonths ();
            new StackQueueManager ().LogStack ();
            
        }
    }
}