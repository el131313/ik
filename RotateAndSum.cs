using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication60
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] sumArr = new int[arr.Count];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                arr.Insert(0, arr[arr.Count - 1]);// insert laste element at first position
                arr.RemoveAt(arr.Count - 1); //remove last element
                //only this rotates the arrays

                //sum
                for (int j = 0; j < arr.Count; j++)
                {
                    sumArr[j] += arr[j];
                }
               
            }

            Console.WriteLine(string.Join(" ", sumArr));

        }

    }
}
//3 2 4 -1
//2

//rotated1[] = -1  3  2  4
//rotated2[] =  4 -1  3  2
//sum[] =  3  2  5  6
