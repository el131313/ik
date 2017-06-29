using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication61
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine()
             .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToList();

            var counts = numbers.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            foreach (var number in counts)
            {
                var currentNumber = number.Key;
                var count = number.Value;

                Console.WriteLine($"{currentNumber} -> {count}");

            }
        }
    }
}
