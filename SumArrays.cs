using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = Math.Max(array1.Length, array2.Length);
            int[] result = new int[len];

            for(int i=0; i<len; i++)
            {
                result[i] = array1[i % array1.Length] + array2[i % array2.Length];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
//Write a program that reads two arrays of integers and sums them.
//When the arrays are not of the same size, duplicate the smaller array a few times.

//1 2 3 4 5
//2 3
//    =
//    3 5 5 7 7
