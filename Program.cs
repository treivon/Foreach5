using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var domains = new Dictionary<string, string>
            {
                {"est", "Estonia"},
                {"lat", "Latvia" },
                {"fin", "Finland" },
                {"swe", "Sweden" },
            };
            int i = 1;
            foreach (var pair in domains)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} - {i}");
                i++;
            }
        }
    }
}
