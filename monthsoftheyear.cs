using System.Collections;
using System.Collections.Generic;
using System;

namespace Fibonacci
{
    public class monthsoftheyear : IEnumerable
    {
        private string[] _months = {"January",
        "February",
        "March",
        "April",
        "May",
        "June",
        "July",
        "August",
        "September",
        "October",
        "November",
        "December"};



        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _months.Length; i++)
            {
                yield return _months[i];
            }
        }

        public void LogMonths()
        {
            foreach (var month in _months)
            {
                Console.WriteLine(month);
            }
        }
    }
}