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

            var input = Console.ReadLine()
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToList();
            input.Sort();
            input.Add(0); //adding one last unimportant element in the List 
                          //because the used algorithm is not counting the last element
            var count = 1;
            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{input[i]} -> {count}");
                    count = 1;
                }
            }

        }
    }
}
