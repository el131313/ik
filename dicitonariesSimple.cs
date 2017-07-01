using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication65
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<double, int>();

            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (var item in input)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item]=1;
                }
                else
                dict[item]++;
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
//Read a list of real numbers and print them in ascending order along with their number of occurrences.

//Input
//8 2,5 2,5 8 2,5

// Output
//2.5 -> 3
//8 -> 2
